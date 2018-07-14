using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CadastroEscaladores;

namespace CadastroEscalador
{
    public partial class Principal : Form
    {

        public Principal()
        {

            InitializeComponent();

            dgvEscaladores.AutoGenerateColumns = false;
            #region Marca D´agua
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtAddHorarioSaida);
            sList.Add("00:00");
            tList.Add(txtNovaEntrada);
            sList.Add("Digite o N° de Identificação");
            SetCueBanner(ref tList, sList);
            #endregion
               
            AtualizarTabela();
            

        }
        #region Marca D´agua
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        public void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }

        #endregion


        public class DadosTabelaDTO
        {
            public string EscaladorIdentidade { get; set; }
            public string Nome { get; set; }
            public string País { get; set; }
            public string Estado { get; set; }
            public string  Cidade { get; set; }
            public string TelefoneEmergencia { get; set; }
            public int NumPulseira { get; set; }
            public TimeSpan? Saida { get; set; }
            public TimeSpan Entrada { get; set; }
            public string Genero { get; set; }
            public DateTime Data { get; set; }
            public int ID { get; set; }
            public int NumPlacaID { get; set; }
        }
        private void AtualizarTabela()
        {

            {              
                
                using (var banco = new DBEscaladores())
                {

                    var hoje = DateTime.Now.Date;/*Pega a data do dia*/




                    var dadosBanco = banco.Registros.Where(e => e.data == hoje)
                       .Join(banco.Escaladores,  // a tabela de origem da união interna
                       regID => regID.escaladorIdentidade,  // Selecione a chave primária (a primeira parte da cláusula "on" em uma instrução sql "join")
                       escaladorID => escaladorID.identidade,  // Selecione a chave estrangeira(a segunda parte da cláusula "on")
                       (regID, escaladorID) => new { regID, escaladorID })  // seleção
                       .Select(x => new DadosTabelaDTO   // onde declaração
                       {
                           EscaladorIdentidade = x.escaladorID.identidade,
                           Nome = x.escaladorID.nome,
                           Estado = x.escaladorID.UF,
                           Genero = x.escaladorID.genero,
                           Saida =  x.regID.saida,
                           Entrada = x.regID.entrada,
                           Cidade=x.escaladorID.cidade,
                           País=x.escaladorID.país,
                           ID =x.regID.id,
                           NumPulseira=x.regID.numPulseira,
                           NumPlacaID=x.regID.numPlacaID,
                           TelefoneEmergencia = x.escaladorID.telefoneEmergencia,
                           Data=x.regID.data                           
                           
                       }).ToList();


                    /*Ordena e formata os horarios de entrada e saida*/
                    var registrosOrdenados = dadosBanco.OrderByDescending(E => E.Entrada)
                        .Select(E => new
                        {
                            EscaladorIdentidade = E.EscaladorIdentidade,
                            Nome = E.Nome,
                            Cidade = E.Cidade,
                            Entrada = E.Entrada.ToString(@"hh\:mm"),
                            País = E.País,
                            NumPulseira = E.NumPulseira,
                            NumPlacaID = E.NumPlacaID,
                            TelefoneEmergencia = E.TelefoneEmergencia,
                            Genero = E.Genero,
                            ID = E.ID,
                            Estado = E.Estado,
                            Saida = E.Saida == null ? "" : E.Saida.Value.ToString(@"hh\:mm"),
                        }).ToList();



                    lblContador.Text = registrosOrdenados.Count().ToString();
                  
                    dgvEscaladores.DataSource = registrosOrdenados;
                    dgvEscaladores.Refresh();


                }


            }
        }
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            new Cadastro().ShowDialog();
           
           AtualizarTabela();
        }
        private void BtnEditarEscalador_Click(object sender, EventArgs e)
        {
            new EditarEscalador().ShowDialog();
            AtualizarTabela();
            
        }
        private void DgvEscaladores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvEscaladores.SelectedRows.Count > 0)
            //{
            //    string identidadeEscalador = dgvEscaladores.SelectedRows[0].Cells[8].Value.ToString();
            //    string selecEscalador = dgvEscaladores.SelectedRows[0].Cells[11].Value.ToString();
            //    new EditarEscalador(identidadeEscalador, selecEscalador).ShowDialog();
            //    AtualizarTabela();
            //}
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) && dgvEscaladores.SelectedRows.Count > 0)
            {
                if (dgvEscaladores.SelectedRows.Count > 0)
                {
                    string identidadeEscaladorExcluir = dgvEscaladores.SelectedRows[0].Cells[11].Value.ToString();/*Pega  celula q tem o ID do registros selecionado no datagrid view*/ 
                   // int teste = int.Parse(dgvEscaladores.SelectedRows[0].Cells[11].Value.ToString());

                    
                   

                    using (var banco = new DBEscaladores())
                    {
                        var excluirEscalador = banco.Registros.Find(long.Parse( identidadeEscaladorExcluir)); /*Apaga somente registros*/ 
                        banco.Registros.Remove(excluirEscalador);                    
                        banco.SaveChanges();
                    }
                   
                   
                    AtualizarTabela();
                }
                else
                {
                    this.Close();
                }
            }
        }     
        private void BtnBuscarEscalador_Click(object sender, EventArgs e)
        {
            using (var banco = new DBEscaladores())
            {

                try
                {
                    var identidadeEscalador = txtNovaEntrada.Text;

                    var registrosIdentificacao = banco.Escaladores.Where(s => s.identidade == identidadeEscalador).Count();/*Lista filtrad usando o N° de IDENTIFICAÇÂO*/

                    if (registrosIdentificacao > 0)
                    {

                        new NovaVisita(identidadeEscalador).ShowDialog();
                      
                    }
                    else
                    {
                        MessageBox.Show("Não existe registro para esse número de identificação", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    AtualizarTabela();
                }
                catch (Exception)
                {

                    MessageBox.Show("Preencha o campo com a identificação!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                txtNovaEntrada.Text = "";

            }



    }
        private void BtnEscalador_Click(object sender, EventArgs e)
        {
            new BuscarEscalador().ShowDialog();
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            new Consultas().ShowDialog();
        }
        private void BtnSalvarHorarioSaida_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Deseja adicionar o horário de saída para esse escalador??", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                
                    if (dgvEscaladores.SelectedRows.Count > 0)
                    {
                        int addHorarioSaida = int.Parse(dgvEscaladores.SelectedRows[0].Cells[11].Value.ToString());/*Pega  celula q tem o ID do registros selecionado no datagrid view*/
                        
                        using (var banco = new DBEscaladores())
                        {
                            var addHorario = banco.Registros.Find(addHorarioSaida); /*Apaga somente registros*/
                           addHorario.saida =TimeSpan.Parse( txtAddHorarioSaida.Text);/*Adiciona o horario de saida ao escalador selecionar no datagridview*/
                          
                            banco.SaveChanges();
                        }

                    }
                txtAddHorarioSaida.Text = "";
                AtualizarTabela();
            }
        }
        private void TxtAddHorarioSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ':')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        //private void txtNovaEntrada_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //Se a tecla digitada não for número e nem backspace
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
        //    {
        //        //Atribui True no Handled para cancelar o evento
        //        e.Handled = true;
        //    }
        //}

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        
    }
}
