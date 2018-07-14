using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace CadastroEscalador
{
    public partial class BuscarEscalador : Form
    {
        private string identidadeEscalador;
        Principal MarcaDagua = new Principal();
        public BuscarEscalador()    // construtor padrão da janela
        {
            InitializeComponent();
            dgvBuscarEscalador.AutoGenerateColumns = false;
            #region Marca D´agua
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtBuscarIdentidade);
            sList.Add("Digite o N° de Identificação ");
            MarcaDagua.SetCueBanner(ref tList, sList);
            #endregion
        }

        public BuscarEscalador(string identidadeEscalador, DateTime dataInicio, DateTime dataFim)//construtor que é usado no double click da janela de consulta
        {
            InitializeComponent();
             dataInicio = dtpInicioBuscarEscalador.Value.Date;/*data inicio da janela de buscar escalador*/
             dataFim = dtpTerminoBuscaEscalador.Value.Date;/*data fim da janela de buscar escalador*/

            dgvBuscarEscalador.AutoGenerateColumns = false;
            this.identidadeEscalador = identidadeEscalador;
            Mostrar(identidadeEscalador, dataInicio, dataFim);
            dtpInicioBuscarEscalador.Value = dataInicio;
            dtpTerminoBuscaEscalador.Value = dataFim;
        }
        private void BtnBuscarEscalador_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpInicioBuscarEscalador.Value.Date;/*data inicio da janela de buscar escalador*/
            DateTime dataFim = dtpTerminoBuscaEscalador.Value.Date;/*data fim da janela de buscar escalador*/

            identidadeEscalador = txtBuscarIdentidade.Text;/*identidade da janela de buscar escalador*/
            Mostrar(identidadeEscalador, dataInicio, dataFim);
            txtBuscarIdentidade.Text = "";
        }
        public class RegitrosDTO
        {
            public int NumPlacaID { get; set; }
            public int NumPulseira { get; set; }
            public TimeSpan? Saida { get; set; }
            public TimeSpan Entrada { get; set; }
            public decimal Valor { get; set; }
            public DateTime Data { get; set; }
            public int ID { get; set; }
        }
        public class EscaladorDTO
        {
            public string TipoIdentidade { get; set; }
            public string Telefone { get; set; }
            public string TipoSanguineo { get; set; }
            public string Genero { get; set; }
            public string Identidade { get; set; }
            public string Nome { get; set; }
            public string Bairro { get; set; }
            public string CEP { get; set; }
            public string ClubeAssociacao { get; set; }
            public string ComplementoEndereco { get; set; }
            public string NomeContatoEmergencia { get; set; }
            public string TelefoneEmergencia { get; set; }
            public string Email { get; set; }
            public string Endereco { get; set; }
            public int? NumEndereco { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Paises { get; set; }
        }
        private List<RegitrosDTO> BuscarRegistros(string identidadeEscalador, DateTime dataInicio, DateTime dataFim)
        {

            using (var banco = new DBEscaladores())
            {
                /*Filtra os registros atraves das datas informadas */
                var registroFiltradosData = banco.Registros
                    .Where(t => t.data >= dataInicio && t.data <= dataFim && identidadeEscalador == t.escaladorIdentidade)
                    .Select(E => new RegitrosDTO
                    {
                        NumPlacaID = E.numPlacaID,
                        Valor = E.valor,
                        ID = E.id,
                        NumPulseira = E.numPulseira,
                        Saida = E.saida,
                        Entrada = E.entrada,
                        Data = E.data
                    }).ToList();




                /*Ordena e formata os horarios de entrada e saida para o datagrid*/
                var registrosOrdenados = registroFiltradosData.OrderByDescending(E => E.Data)
                    .Select(E => new RegitrosDTO
                    {

                        NumPlacaID = E.NumPulseira,
                        Valor = E.Valor,
                        ID = E.ID,
                        NumPulseira = E.NumPulseira,
                        Entrada = E.Entrada,
                       //Saida = E.Saida == null ? E.Entrada : E.Saida,
                       Saida = E.Saida,
                        Data = E.Data
                    }).ToList();

                return registrosOrdenados;

            }
        }
        private List<EscaladorDTO> DadosEscalador(string identidadeEscalador)
        {
            using (var banco = new DBEscaladores())
            {
                /*Procura no banco usando a  identidade*/
                var dadosEscalador = banco.Escaladores.Where(E => identidadeEscalador == E.identidade)
                   .Select(E => new EscaladorDTO
                   {
                       TelefoneEmergencia = E.telefoneEmergencia,
                       NomeContatoEmergencia = E.nomeContatoEmergencia,
                       TipoIdentidade = E.tipoIdentidade,
                       Telefone = E.telefone,
                       TipoSanguineo = E.tipoSanguineo,
                       Genero = E.genero,
                       Identidade = E.identidade,
                       Nome = E.nome,
                       Bairro = E.bairro,
                       CEP = E.CEP,
                       ClubeAssociacao = E.clubeAssociacao,
                       ComplementoEndereco = E.complementoEndereco,
                       Email = E.email,
                       Endereco = E.endereco,
                       NumEndereco = E.numEndereco,
                       Cidade = E.cidade,
                       Estado = E.UF,
                       Paises = E.país
                   }).ToList();

                return dadosEscalador;


            }

        }
        private void Mostrar(string identidadeEscalador, DateTime dataInicio, DateTime dataFim)
        {
            var horaVazia = new TimeSpan();
            decimal total = 0;
            decimal valorTotal = 0;
            var regitros = BuscarRegistros(identidadeEscalador, dataInicio, dataFim);


            var dadosEscalador = DadosEscalador(identidadeEscalador);
            if (dadosEscalador == null)
            {
                MessageBox.Show("Não existe cadastro para esse número de identificação", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {                
                foreach (var dados in dadosEscalador)
                {


                    if (dados.TipoIdentidade == "Outro Documento")
                    {
                        txtTipoDocumento.Text = "Outro Documento";
                    }
                    else
                    {
                        txtTipoDocumento.Text = dados.TipoIdentidade;
                    }

                    txtTelefone.Text = dados.Telefone;
                    txtTipoSanguineo.Text = dados.TipoSanguineo;
                    txtGenero.Text = dados.Genero;
                    txtIdentidade.Text = dados.Identidade;
                    txtNome.Text = dados.Nome;
                    txtBairro.Text = dados.Bairro;
                    txtCEP.Text = dados.CEP;
                    txtClubeAssociacao.Text = dados.ClubeAssociacao;
                    txtComplemento.Text = dados.ComplementoEndereco;
                    txtNomeContatoEmergencia.Text = dados.NomeContatoEmergencia;
                    txtNumeroContatoEmergencia.Text = dados.TelefoneEmergencia;

                    txtEmail.Text = dados.Email;
                    txtEndereco.Text = dados.Endereco;
                    txtNumeroEndereco.Text = Convert.ToString(dados.NumEndereco);
                    txtCidade.Text = dados.Cidade;
                    txtEstado.Text = dados.Estado;
                    txtPaís.Text = dados.Paises;
                }
            }          

            txtQuantVisitas.Text = regitros.Count().ToString();/*Conta e escreve a quantidade de registros do periodo escolhido*/

            /*Formata os horarios*/   /*TENTAR MELHORAR ISSO*/
            var registroFormatados = regitros.Select(E => new
            {
                NumPlacaID = E.NumPlacaID,
                Valor = E.Valor,
                ID = E.ID,
                NumPulseira = E.NumPulseira,
                //Saida = E.Saida.Value.ToString(@"hh\:mm"),
                 Saida = E.Saida==null ?  "" :E.Saida.Value.ToString(@"hh\:mm"),
                Entrada = E.Entrada.ToString(@"hh\:mm"),
                Data = E.Data
            }).ToList();
            dgvBuscarEscalador.DataSource = registroFormatados;
            //dgvBuscarEscalador.Refresh();

            #region Total de visitas e valor pago

            using (var banco = new DBEscaladores())
            {
                /*Todas as visitas do escalador,e todos dos valores*/
                var totalVisitas = banco.Registros.Where(t => identidadeEscalador == t.escaladorIdentidade).Select(E => new { visitas = E.IdentidadeEscalador.identidade, valorTotal = E.valor }).ToList();
                var visitasTotal = totalVisitas.Count();

                txtTotalVisitas.Text = visitasTotal.ToString(); /*total das visitas do escalador*/
                foreach (var t in totalVisitas)
                {
                    valorTotal = valorTotal + t.valorTotal;/*Total pago de todas as vezes*/

                }

                txtTotalPago.Text = valorTotal.ToString();
            }




            #endregion
            #region Total Pago Periodo
            var totalPago = regitros.Select(E => new { total = E.Valor }).ToList();

            foreach (var v in totalPago)
            {
                total = total + v.total;
                txtValorPagoPeriodo.Text = total.ToString();/*Total de pagamentos no periodo escolhido*/
            }
            #endregion
            #region Total Horas 
            /*LIsta os horarios */
            var totalHora = regitros.Select(E => new { E.Saida, E.Entrada }).ToList();
            int contador = 0;
          
            foreach (var i in totalHora)
            {
                if (i.Saida != null)
                {
                    var entrada = Convert.ToDateTime(i.Entrada.ToString());
                    var saida = Convert.ToDateTime(i.Saida.ToString());
                    

                    var dif = saida.Subtract(entrada);
                    //mostra o tempo de permanencia no parque
                    var totalHoras = horaVazia.Add(dif);
                    horaVazia = totalHoras;
                    var hora = totalHoras.TotalHours.ToString().Split(',');
                    //txtTotalHorasParque.Text = totalHoras.ToString(@"d\.hh\:mm");
                    txtTotalHorasParque.Text =   hora[0] +":"+totalHoras.Minutes.ToString();
                }

                 if(i.Saida ==null && contador< 1 )
                {
                    
                    MessageBox.Show("Algum horário de saída não foi incluido!!\nPode ocorrer diferenças no total de \"Horas de permanência no parque\"!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    contador++;
                }
            }

            #endregion

            dgvBuscarEscalador.Refresh();





        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpInicioBuscarEscalador.Value.Date;
            DateTime dataFim = dtpTerminoBuscaEscalador.Value.Date;
            identidadeEscalador = txtBuscarIdentidade.Text;

            decimal totalPagoPeriodo = 0;
            var  totalHoras = new TimeSpan();
            var horaVazia = new TimeSpan();
            var visitasTotal = 0;
            decimal valorTotal = 0;
            var horaFormatada="";



            var listaRegistros = BuscarRegistros(identidadeEscalador, dataInicio, dataFim);
            var EscaladorDados = DadosEscalador(identidadeEscalador);
            #region Total de visitas e valor pago

            using (var banco = new DBEscaladores())
            {
                /*Todas as visitas do escalador,e todos dos valores*/
                var totalVisitas = banco.Registros.Where(t => identidadeEscalador == t.escaladorIdentidade).Select(E => new { visitas = E.IdentidadeEscalador.identidade, valorTotal = E.valor }).ToList();
                 visitasTotal = totalVisitas.Count();

               // lblTotalVisitas.Text = visitasTotal.ToString(); /*total das visitas do escalador*/
                foreach (var t in totalVisitas)
                {
                    valorTotal = valorTotal + t.valorTotal;/*Total pago de todas as vezes*/

                }

                //lblTotalPago.Text = valorTotal.ToString();
            }




            #endregion
            #region Total Pago Periodo
            var totalPago = listaRegistros.Select(E => new { total = E.Valor }).ToList();

            foreach (var v in totalPago)
            {
                totalPagoPeriodo = totalPagoPeriodo + v.total;
                //lblValorPagoPeriodo.Text = total.ToString();/*Total de pagamentos no periodo escolhido*/
            }
            #endregion
            #region Total Horas 
            /*LIsta os horarios */
            var listaHorarios = listaRegistros.Select(E => new { E.Saida, E.Entrada }).ToList();
            int contador = 0;

            foreach (var i in listaHorarios)
            {
                if (i.Saida != null)
                {
                    var entrada = Convert.ToDateTime(i.Entrada.ToString());
                    var saida = Convert.ToDateTime(i.Saida.ToString());

                    var dif = saida.Subtract(entrada);
                    //mostra o tempo de permanencia no parque
                     totalHoras = horaVazia.Add(dif);
                    horaVazia = totalHoras;
                    // lblTotalHorasParque.Text = totalHoras.ToString(@"d\.hh\:mm");                    
                    var hora = totalHoras.TotalHours.ToString().Split(',');
                    //txtTotalHorasParque.Text = totalHoras.ToString(@"d\.hh\:mm");
                    horaFormatada = hora[0] + ":" + totalHoras.Minutes.ToString();

                }
                else if (i.Saida == null && contador < 1)
                {

                    MessageBox.Show("Algum horário de saida não foi incluido!!\nPode ocorrer diferenças no total de \"Horas de permanência no parque\"", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    contador++;
                }
            }

            #endregion
            #region Salvar
            var save = new SaveFileDialog
            {
                Title = "Salvar",
                Filter = " Documento do Word |* .doc | Excel | * .csv | Todos os arquivos(*. *) | * .txt *"
            };
            save.ShowDialog();


            if (string.IsNullOrEmpty(save.FileName) == false)
            {
                //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)
                //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente
                try
                {


                    using (StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8))
                    {
                        if (save.FilterIndex == 1)
                        {

                            sw.WriteLine("PERÍODO ESCOLHIDO");
                            sw.WriteLine("DATA DE INÍCIO: {0}  ----- DATA DE TÉRMINO: {1} ", dataInicio.ToShortDateString(), dataFim.ToShortDateString());
                            sw.WriteLine("");
                            sw.WriteLine("DADOS PESSOAIS");
                            foreach (var p in EscaladorDados)
                            {
                                sw.WriteLine("NOME :{0} , NUMERO DE IDETIFICAÇÃO : {1} , TIPO : {2}", p.Nome, p.Identidade, p.TipoIdentidade);
                                sw.WriteLine("EMAIL : {0} , CLUBE/ASSOCIAÇÃO DE ESCALADA : {1}", p.Email, p.ClubeAssociacao);
                                sw.WriteLine("TELEFONE : {0} , TIPO SANGUÍNEO : {1} , GENÊRO : {2}", p.Telefone, p.TipoSanguineo, p.Genero);
                                sw.WriteLine("CONTATO EMERGENCIA : {0} , NUMERO DO CONTATO : {1}", p.NomeContatoEmergencia, p.TelefoneEmergencia);
                                sw.WriteLine("");
                                sw.WriteLine("DADOS DE ENDEREÇO");
                                sw.WriteLine("ENDEREÇO : {0} , NUMERO : {1} , COMPLEMENTO : {2}", p.Endereco, p.NumEndereco, p.ComplementoEndereco);
                                sw.WriteLine("BAIRRO : {0} , CIDADE : {1} , ESTADO : {2}", p.Bairro, p.Cidade, p.Estado);
                                sw.WriteLine("CEP : {0} , PAÍS :{1}", p.CEP, p.Paises);
                            }
                            sw.WriteLine("");
                            sw.WriteLine("REGISTROS");
                            sw.WriteLine(" ENTRADA -  SAÍDA  - N° PULSEIRA - N° PLACA - VALOR PAGO - DATA"); 
                            foreach (var r in listaRegistros)
                            {

                                sw.WriteLine("{0} - {1} -   {2}   -   {3}   -   {4}   - {5}", r.Entrada.ToString(@"hh\:mm"),r.Saida ==null? "" : r.Saida.Value.ToString(@"hh\:mm"), r.NumPulseira, r.NumPlacaID, r.Valor, r.Data.ToShortDateString());
                            }
                            sw.WriteLine("");
                            sw.WriteLine("DADOS REFERENTES AO PERIODO ESCOLHIDO");
                            sw.WriteLine("QUANTIDADE DE VISITAS : {0} , HORAS DE PERMANÊNCIA NO PARQUE : {1} , VALOR PAGO : {2}", listaRegistros.Count(), horaFormatada, totalPagoPeriodo);
                            sw.WriteLine("");
                            sw.WriteLine("TOTAIS GERAIS DO ESCALADOR");
                            sw.WriteLine("TOTAL DE VISITA : {0} , TOTAL PAGO : {1}", visitasTotal, valorTotal);
                            

                           


                        }
                        if (save.FilterIndex == 2)
                        {
                            
                                sw.WriteLine("PERÍODO ESCOLHIDO");
                                sw.WriteLine("DATA DE INÍCIO:;{0};DATA DE TÉRMINO:;{1}", dataInicio.ToShortDateString(), dataFim.ToShortDateString());
                                sw.WriteLine("");
                                sw.WriteLine("DADOS PESSOAIS");
                                foreach (var p in EscaladorDados)
                                {
                                    sw.WriteLine("NOME:;{0};NUMERO DE IDETIFICAÇÃO:;{1};TIPO:;{2}", p.Nome, p.Identidade, p.TipoIdentidade);
                                    sw.WriteLine("EMAIL:;{0} ;CLUBE/ASSOCIAÇÃO DE ESCALADA:;{1}", p.Email, p.ClubeAssociacao);
                                    sw.WriteLine("TELEFONE:;{0};TIPO SANGUÍNEO:;{1};GENÊRO:;{2}", p.Telefone, p.TipoSanguineo, p.Genero);
                                    sw.WriteLine("CONTATO EMERGENCIA:;{0} ; NUMERO DO CONTATO:; {1}", p.NomeContatoEmergencia, p.TelefoneEmergencia);
                                    sw.WriteLine("");
                                    sw.WriteLine("DADOS DE ENDEREÇO");
                                    sw.WriteLine("ENDEREÇO:;{0};NUMERO:;{1};COMPLEMENTO:;{2}", p.Endereco, p.NumEndereco, p.ComplementoEndereco);
                                    sw.WriteLine("BAIRRO:;{0};CIDADE:;{1};ESTADO:;{2}", p.Bairro, p.Cidade, p.Estado);
                                    sw.WriteLine("CEP:;{0};PAÍS:;{1}", p.CEP, p.Paises);
                                }
                                sw.WriteLine("");
                                sw.WriteLine("REGISTROS");
                                sw.WriteLine("ENTRADA;SAÍDA;N° PULSEIRA;N° PLACA;VALOR PAGO;DATA");
                                foreach (var r in listaRegistros)
                                {

                                    sw.WriteLine("{0};{1};{2};{3};{4};{5}", r.Entrada.ToString(@"hh\:mm"), r.Saida == null ? "" : r.Saida.Value.ToString(@"hh\:mm"), r.NumPulseira, r.NumPlacaID, r.Valor, r.Data.ToShortDateString());
                                }
                                sw.WriteLine("");
                                sw.WriteLine("DADOS REFERENTES AO PERIODO ESCOLHIDO");
                                sw.WriteLine("QUANTIDADE DE VISITAS:;{0};HORAS DE PERMANÊNCIA NO PARQUE:;{1};VALOR PAGO:;{2}", listaRegistros.Count(), horaFormatada, totalPagoPeriodo);
                                sw.WriteLine("");
                                sw.WriteLine("TOTAIS GERAIS DO ESCALADOR");
                                sw.WriteLine("TOTAL DE VISITA:;{0};TOTAL PAGO:;{1}", visitasTotal, valorTotal);
                                
                            
                           
                        }
                        if (save.FilterIndex == 3)
                        {

                            sw.WriteLine("PERÍODO ESCOLHIDO");
                            sw.WriteLine("DATA DE INÍCIO: {0}  ----- DATA DE TÉRMINO: {1} ", dataInicio.ToShortDateString(), dataFim.ToShortDateString());
                            sw.WriteLine("");
                            sw.WriteLine("DADOS PESSOAIS");
                            foreach (var p in EscaladorDados)
                            {
                                sw.WriteLine("NOME :{0} , NUMERO DE IDETIFICAÇÃO : {1} , TIPO : {2}", p.Nome, p.Identidade, p.TipoIdentidade);
                                sw.WriteLine("EMAIL : {0} , CLUBE/ASSOCIAÇÃO DE ESCALADA : {1}", p.Email, p.ClubeAssociacao);
                                sw.WriteLine("TELEFONE : {0} , TIPO SANGUÍNEO : {1} , GENÊRO : {2}", p.Telefone, p.TipoSanguineo, p.Genero);
                                sw.WriteLine("CONTATO EMERGENCIA : {0} , NUMERO DO CONTATO : {1}", p.NomeContatoEmergencia, p.TelefoneEmergencia);
                                sw.WriteLine("");
                                sw.WriteLine("DADOS DE ENDEREÇO");
                                sw.WriteLine("ENDEREÇO : {0} , NUMERO : {1} , COMPLEMENTO : {2}", p.Endereco, p.NumEndereco, p.ComplementoEndereco);
                                sw.WriteLine("BAIRRO : {0} , CIDADE : {1} , ESTADO : {2}", p.Bairro, p.Cidade, p.Estado);
                                sw.WriteLine("CEP : {0} , PAÍS :{1}", p.CEP, p.Paises);
                            }
                            sw.WriteLine("");
                            sw.WriteLine("REGISTROS");
                            sw.WriteLine(" ENTRADA -  SAÍDA  - N° PULSEIRA - N° PLACA - VALOR PAGO - DATA");
                            foreach (var r in listaRegistros)
                            {

                                sw.WriteLine("{0} - {1} -   {2}   -   {3}   -   {4}   - {5}", r.Entrada.ToString(@"hh\:mm"), r.Saida == null ? "" : r.Saida.Value.ToString(@"hh\:mm"), r.NumPulseira, r.NumPlacaID, r.Valor, r.Data.ToShortDateString());
                            }
                            sw.WriteLine("");
                            sw.WriteLine("DADOS REFERENTES AO PERIODO ESCOLHIDO");
                            sw.WriteLine("QUANTIDADE DE VISITAS : {0} , HORAS DE PERMANÊNCIA NO PARQUE : {1} , VALOR PAGO : {2}", listaRegistros.Count(), horaFormatada, totalPagoPeriodo);
                            sw.WriteLine("");
                            sw.WriteLine("TOTAIS GERAIS DO ESCALADOR");
                            sw.WriteLine("TOTAL DE VISITA : {0} , TOTAL PAGO : {1}", visitasTotal, valorTotal);





                        }
                        sw.Dispose();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Não foi possivel salvar o arquivo \n\n ERRO: "+ ex.Message,"AVISO",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }

      
    }
}

