using CadastroEscalador;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroEscaladores
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
            dgvConsultasEscaladores.AutoGenerateColumns = false;
        }      
        public class RegistroDTO
        {

            public string Nome { get; set; }
            public string EscaladorIdentidade { get; set; }
            public string Estado { get; set; }
            public string Cidade { get; set; }
            public string Paises { get; set; }
            public string Genero { get; set; }
            public decimal Valor { get; set; }
            public int Quantidade { get; set; }
            public int Cortesia { get; set; }

        }  
        public List<RegistroDTO> ListaDados()
        {
            
            using (var banco = new DBEscaladores())
            {
                
                DateTime dataInicio = dtpInicioConsulta.Value.Date;
                DateTime dataFim = dtpFimConsulta.Value.Date;

                
                var dadosBanco = banco.Registros.Where(c=> c.data >= dataInicio && c.data <= dataFim)
                        .Join(banco.Escaladores, regID => regID.escaladorIdentidade, escaladorID => escaladorID.identidade, (regID, escaladorID) => new { regID, escaladorID })
                        .Select(x => new RegistroDTO
                        {
                            EscaladorIdentidade = x.escaladorID.identidade,
                            Nome =x.escaladorID.nome,
                            Estado=x.escaladorID.UF,
                            Paises=x.escaladorID.país,
                            Cidade=x.escaladorID.cidade,
                            Genero=x.escaladorID.genero,
                            Valor=x.regID.valor,                            
                        }).ToList();

                var cortesia = dadosBanco.Where(t => t.Valor == 0).Count();


                var dadosAgrupados = dadosBanco.GroupBy(E => E.EscaladorIdentidade)
                    .Select(E => new RegistroDTO
                    {
                        EscaladorIdentidade = E.Key,
                        Nome = E.First().Nome,
                        Cortesia = cortesia,
                        Genero = E.First().Genero,
                        Estado = E.First().Estado,
                        Cidade = E.First().Cidade,
                        Paises=E.First().Paises,
                        Valor = E.Sum(F => F.Valor),
                        Quantidade = E.Count()
                    }).OrderByDescending(E=>E.Quantidade).ToList();
                return dadosAgrupados;
            }
        }        
        private void BtnGerarConsulta_Click(object sender, EventArgs e)
        {
            decimal valorTotal = 0;
            var quantidade = 0;
           
            var listaRegistros = ListaDados();


            foreach (var l in listaRegistros)
            {
                valorTotal += l.Valor;
                
                quantidade += l.Quantidade ;
               
                lblCortesia.Text = l.Cortesia.ToString();
            }

            lblTotalVisitas.Text = quantidade.ToString();
            lblTotalPago.Text = valorTotal.ToString();

            #region Quantidade por Sexo

            var quantMasc = listaRegistros.Where(s => s.Genero == "MASCULINO").Count(); /*conta todos os homens cadastrados no intervalo de tempo selecionado*/
            lblQuantHomens.Text = Convert.ToString(quantMasc);
            var quantFem = listaRegistros.Where(s => s.Genero == "FEMININO").Count();/*conta todas as mulheres cadastrados no intervalo de tempo selecionado*/
            lblQuantMulheres.Text = Convert.ToString(quantFem);
            #endregion
            dgvConsultasEscaladores.DataSource = listaRegistros;
            dgvConsultasEscaladores.Refresh();




            //var cortesia = listaRegistros.Where(t => t.Valor == 0).Count();
            //lblCortesia.Text = cortesia.ToString();


            //var totalEscaladores = listaRegistros.Count();
            //lblConsultaTotalEscaladores.Text = totalEscaladores.ToString();

            ////var dadosAgrupados = listaRegistros.Select(E => new { Identidade = E.EscaladorIdentidade, Estado = E.Estado, Nome = E.Nome, Sexo = E.Genero, Quantidade = E.EscaladorIdentidade.Count() }).OrderByDescending(E => E.Quantidade).ToList();

            ///*ESSE ABAIXO MOSTRA TUDO MENOS A QUANTIDADE DE VEZES*/
            //  var dadosAgrupados = listaRegistros.Select(E => new { Identidade = E.EscaladorIdentidade, Estado = E.Estado, Nome = E.Nome, Sexo = E.Genero,Valor = E.Valor}).Distinct().ToList();


            //var aux = listaRegistros.Select(E => new { Identidade = E.EscaladorIdentidade, Estado = E.Estado, Nome = E.Nome, Sexo = E.Genero }).GroupBy(E => E.Identidade).ToList();

            //var teste = listaRegistros.GroupBy(E => E.EscaladorIdentidade).Select(E => new { Identidade = E.Key, Quantidade = E.Count(), Nome = E.Select(F => F.EscaladorIdentidade), Estado = E.Select(F => F.Estado), Genero = E.Select(F => F.Genero) }).ToList();


            // var quantidade = listaRegistros.GroupBy(E => E.EscaladorIdentidade).ToList();

            //foreach (var l in quantidade)
            //{
            //    foreach (var i in dadosAgrupados)
            //    {
            //        if (l.Key == i.Identidade)
            //        {
            //            reg.Add(new RegistroDTO { EscaladorIdentidade = i.Identidade, Estado = i.Estado, Nome = i.Nome, Genero = i.Sexo,Quantidade=l.Count()});

            //        }
            //        else
            //        {
            //            reg.Add(new RegistroDTO { EscaladorIdentidade = i.Identidade, Estado = i.Estado, Nome = i.Nome, Genero = i.Sexo, Quantidade = l.Count(), });

            //        }

            //    }
            //}



            // dgvConsultasEscaladores.DataSource = reg;
            // dgvConsultasEscaladores.Refresh();




        }
        private void DgvConsultasEscaladores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultasEscaladores.SelectedRows.Count > 0)
            {
                DateTime dataInicio = dtpInicioConsulta.Value;
                DateTime dataFim = dtpFimConsulta.Value;
                string identidadeEscalador = dgvConsultasEscaladores.SelectedRows[0].Cells[0].Value.ToString();

                new BuscarEscalador(identidadeEscalador, dataInicio, dataFim).ShowDialog();

            }
        }
        private void BtnPesquisarLocalidades_Click(object sender, EventArgs e)
        {
            new ConsultaLocalidades().ShowDialog();
        }
        private void SalvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            DateTime dataInicio = dtpInicioConsulta.Value.Date;
            DateTime dataFim = dtpFimConsulta.Value.Date;

            decimal valorTotal = 0;
            var quantidade = 0;
            var cortesia = 0;

            var listaRegistros = ListaDados();


            foreach (var l in listaRegistros)
            {
                valorTotal += l.Valor;

                quantidade += l.Quantidade;
                cortesia = l.Cortesia;
                //lblCortesia.Text = l.Cortesia.ToString();
            }

            //lblTotalVisitas.Text = quantidade.ToString();
            //lblTotalPago.Text = valorTotal.ToString();

            #region Quantidade por Sexo

            var quantMasc = listaRegistros.Where(s => s.Genero == "MASCULINO").Count(); /*conta todos os homens cadastrados no intervalo de tempo selecionado*/
                                                                                        // lblQuantHomens.Text = Convert.ToString(quantMasc);
            var quantFem = listaRegistros.Where(s => s.Genero == "FEMININO").Count();/*conta todas as mulheres cadastrados no intervalo de tempo selecionado*/
                                                                                     //  lblQuantMulheres.Text = Convert.ToString(quantFem);
            #endregion
            #region Salvar
            SaveFileDialog save = new SaveFileDialog()
            {
                Title = "Salvar",
                Filter = "  Documento do Word |* .doc | Excel | * .csv | Todos os arquivos(*.txt *) | *.txt *"
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
                            sw.WriteLine("TOTAL VISITAS : {0} - VALOR TOTAL : {1} - CORTESIA : {2}", quantidade, valorTotal, cortesia);

                            sw.WriteLine("QUANTIDADE HOMENS : {0} - QUANTIDADE MULHERES : {1}", quantMasc, quantFem);
                            //sw.WriteLine("{0}  {1}  {2}  {3}  {4} ", quantidade, valorTotal, quantMasc, quantFem, cortesia);
                            sw.WriteLine("");
                            sw.WriteLine("");
                            sw.WriteLine("NOME COMPLETO - IDENTIDADE - ESTADO - SEXO - VISITAS");
                            foreach (var d in listaRegistros)
                            {
                                sw.WriteLine("{0} - {1} - {2} - {3} - {4}", d.Nome, d.EscaladorIdentidade, d.Estado, d.Genero, d.Quantidade);
                            }

                            



                        }
                        if (save.FilterIndex == 2)
                        {

                            sw.WriteLine("PERÍODO ESCOLHIDO");
                            sw.WriteLine(" DATA DE INÍCIO:;{0}; DATA DE TÉRMINO:;{1} ", dataInicio.ToShortDateString(), dataFim.ToShortDateString());
                            sw.WriteLine("");
                            sw.WriteLine("TOTAL VISITAS; VALOR TOTAL ; QUANTIDADE HOMENS ; QUANTIDADE MULHERES; CORTESIA");
                            sw.WriteLine("{0} ; {1} ; {2} ; {3} ; {4} ", quantidade, valorTotal, quantMasc, quantFem, cortesia);

                            sw.WriteLine("");
                            sw.WriteLine("NOME COMPLETO; IDENTIDADE ; ESTADO ; SEXO ; VISITAS");
                            foreach (var d in listaRegistros)
                            {
                                sw.WriteLine("{0} ; {1} ; {2} ; {3} ; {4}   ", d.Nome, d.EscaladorIdentidade, d.Estado, d.Genero, d.Quantidade);
                            }
                            sw.WriteLine("");
                           


                        }
                        if (save.FilterIndex == 3)
                        {

                            sw.WriteLine("PERÍODO ESCOLHIDO");
                            sw.WriteLine("DATA DE INÍCIO: {0}  ----- DATA DE TÉRMINO: {1} ", dataInicio.ToShortDateString(), dataFim.ToShortDateString());
                            sw.WriteLine("");
                            sw.WriteLine("TOTAL VISITAS : {0} - VALOR TOTAL : {1} - CORTESIA : {2}", quantidade, valorTotal, cortesia);

                            sw.WriteLine("QUANTIDADE HOMENS : {0} - QUANTIDADE MULHERES : {1}", quantMasc, quantFem);
                            //sw.WriteLine("{0}  {1}  {2}  {3}  {4} ", quantidade, valorTotal, quantMasc, quantFem, cortesia);
                            sw.WriteLine("");
                            sw.WriteLine("");
                            sw.WriteLine("NOME COMPLETO - IDENTIDADE - ESTADO - SEXO - VISITAS");
                            foreach (var d in listaRegistros)
                            {
                                sw.WriteLine("{0} - {1} - {2} - {3} - {4}", d.Nome, d.EscaladorIdentidade, d.Estado, d.Genero, d.Quantidade);
                            }
                        }
                        sw.Dispose();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Não foi possivel salvar o arquivo \n\n ERRO : " + ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion



            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }
    }
}
        
    


        

 

