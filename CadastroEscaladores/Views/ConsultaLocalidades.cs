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
    public partial class ConsultaLocalidades : Form
    {
        public ConsultaLocalidades()
        {


            InitializeComponent();
            //dgvConsultaLocalidades.AutoGenerateColumns = false;

        }
        public class LocalidadesDTO
        {
            public string Estado { get; set; }
            public string Paises { get; set; }
            public string Cidade { get; set; }
           

        }



        //public class AuxDTO
        //{
        //    public string Nome { get; set; }
        //    public int Quantidade { get; set; }
        //}
       
        /*
        public List<AuxDTO> listaLocaisCompleto()
        {

            List<AuxDTO> lista = new List<AuxDTO>();
            var dadosBanco = listaLocalidades();

            var lugaresEstados = dadosBanco.GroupBy(E => E.Estado).Select(E => new { Estados = E.Key, QuantidadeEstados = E.Count() }).ToList();
            var lugaresPaíses = dadosBanco.GroupBy(E => E.Paises).Select(E => new { Paises = E.Key, QuantidadePaíses = E.Count() }).ToList();
            var lugaresCidades = dadosBanco.GroupBy(E => E.Cidade).Select(E => new { Cidade = E.Key, QuantidadeCidade = E.Count() }).ToList();


            foreach (var item in lugaresCidades)
            {
                lista.Add(new AuxDTO { Nome = item.Cidade, Quantidade = item.QuantidadeCidade });
            }
            foreach (var item in lugaresEstados)
            {
                lista.Add(new AuxDTO { Nome = item.Estados, Quantidade = item.QuantidadeEstados });
            }
            foreach (var item in lugaresPaíses)
            {
                lista.Add(new AuxDTO { Nome = item.Paises, Quantidade = item.QuantidadePaíses });
            }

            return lista;

        }
        */

        public List<LocalidadesDTO> ListaLocalidades()
        {
            
            using (var banco = new DBEscaladores())
            {
                DateTime dataInicio = dtpInicioConsulta.Value.Date;
                DateTime dataFim = dtpFimConsulta.Value.Date;

                var dadosBanco = banco.Registros.Where(c => c.data >= dataInicio && c.data <= dataFim)
                            .Join(banco.Escaladores, regID => regID.escaladorIdentidade, escaladorID => escaladorID.identidade, (regID, escaladorID) => new { regID, escaladorID })
                            .Select(x => new LocalidadesDTO
                            {
                                Estado = x.escaladorID.UF,
                                Cidade = x.escaladorID.cidade,
                                Paises = x.escaladorID.país,
                                                               
                               
                           }).ToList();


                #region tentar depois pra ver se funciona
                // List<AuxDTO> teste = new List<AuxDTO>();

                //var lugaresEstados = dadosBanco.GroupBy(E => E.Estado).Select(E => new { Estados = E.Key, QuantidadeEstados = E.Count() }).ToList();
                //var lugaresPaíses = dadosBanco.GroupBy(E => E.Paises).Select(E => new { Paises = E.Key, QuantidadePaíses = E.Count() }).ToList();
                //var lugaresCidades = dadosBanco.GroupBy(E => E.Cidade).Select(E => new { Cidade = E.Key, QuantidadeCidade = E.Count() }).ToList();

                //var tes = dadosBanco.GroupBy(E => E.Estado).ToList();
                //var teste2 = tes.Count();


                //foreach (var item in lugaresCidades)
                //{
                //    teste.Add(new AuxDTO { Nome = item.Cidade, Quantidade = item.QuantidadeCidade });

                //}
                //foreach (var item in lugaresEstados)
                //{
                //    teste.Add(new AuxDTO { Nome = item.Estados, Quantidade = item.QuantidadeEstados });
                //}
                //foreach (var item in lugaresPaíses)
                //{
                //    teste.Add(new AuxDTO { Nome = item.Paises, Quantidade = item.QuantidadePaíses });
                //}
                // var test = listaLocaisCompleto();
#endregion


                return dadosBanco;
            }
        }





        private void BtnDadosLocalizacao_Click(object sender, EventArgs e)
        {
           
              

            // var teste = listaLocaisCompleto();

            var dadosBanco = ListaLocalidades();


            var lugaresEstados = dadosBanco.GroupBy(E => E.Estado).Select(E => new { Estados = E.Key, QuantidadeEstados = E.Count() }).ToList();
            var lugaresPaíses = dadosBanco.GroupBy(E => E.Paises).Select(E => new { Paises = E.Key, QuantidadePaíses = E.Count() }).ToList();
            var lugaresCidades = dadosBanco.GroupBy(E => E.Cidade).Select(E => new { Cidade = E.Key, QuantidadeCidade = E.Count() }).ToList();


            dgvCidade.DataSource = lugaresCidades;
            dgvEstado.DataSource = lugaresEstados;
            dgvPaises.DataSource = lugaresPaíses;

            dgvPaises.Refresh();
            dgvEstado.Refresh();
            dgvCidade.Refresh();


            //foreach (var C in lugaresCidades)
            //{
            //    dgvConsultaLocalidades.Rows.Add(C.Cidade, C.QuantidadeCidade);

            //}
            //foreach (var E in lugaresEstados)
            //{
            //    dgvConsultaLocalidades.Rows[i].Cells[2].Value = E.Estados;
            //    dgvConsultaLocalidades.Rows[i].Cells[3].Value = E.QuantidadeEstados;
            //    i++;
            //}
            //i = 0;
            //foreach (var P in lugaresPaíses)
            //{

            //    dgvConsultaLocalidades.Rows[i].Cells[4].Value = P.Paises;
            //    dgvConsultaLocalidades.Rows[i].Cells[5].Value = P.QuantidadePaíses;
            //    i++;

            //    }

            }

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dadosBanco = ListaLocalidades();


            var lugaresEstados = dadosBanco.GroupBy(E => E.Estado).Select(E => new { Estados = E.Key, QuantidadeEstados = E.Count() }).ToList();
            var lugaresPaíses = dadosBanco.GroupBy(E => E.Paises).Select(E => new { Paises = E.Key, QuantidadePaíses = E.Count() }).ToList();
            var lugaresCidades = dadosBanco.GroupBy(E => E.Cidade).Select(E => new { Cidade = E.Key, QuantidadeCidade = E.Count() }).ToList();




            #region Salvar
            SaveFileDialog save = new SaveFileDialog()
            {
                Title = "Salvar",
                Filter = "  Documento do Word |* .doc | Excel | * .csv | Todos os arquivos(*. *) | *. *"
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
                            sw.WriteLine("DATA DE INÍCIO: {0}  ----- DATA DE TÉRMINO: {1} ", dtpInicioConsulta.Value.ToShortDateString(), dtpFimConsulta.Value.ToShortDateString());
                            sw.WriteLine("");
                            sw.WriteLine("LISTA DAS LOCALIDADES E A QUANTIDADE DE ESCALADORES POR REGIÃO");
                            
                            sw.WriteLine("CIDADE - QUANTIDADE CIDADE");
                            foreach (var c in lugaresCidades )
                            {
                            sw.WriteLine("{0} - {1} ",c.Cidade,c.QuantidadeCidade );
                            }
                            sw.WriteLine("");
                            sw.WriteLine("ESTADO - QUANTIDADE ESTADO");
                            foreach (var c in lugaresEstados)
                            {
                                sw.WriteLine("{0} - {1} ", c.Estados, c.QuantidadeEstados);
                            }
                            sw.WriteLine("");
                            sw.WriteLine("PAÍSES - QUANTIDADE PAÍSES");
                            foreach (var c in lugaresPaíses)
                            {
                                sw.WriteLine("{0} - {1} ", c.Paises, c.QuantidadePaíses);
                            }

                            



                        }
                        if (save.FilterIndex == 2)
                        {


                            sw.WriteLine("PERÍODO ESCOLHIDO");
                            sw.WriteLine("DATA DE INÍCIO:;{0}  ;DATA DE TÉRMINO:;{1} ", dtpInicioConsulta.Value.ToShortDateString(), dtpFimConsulta.Value.ToShortDateString());
                            sw.WriteLine("");
                            sw.WriteLine("LISTA DAS LOCALIDADES E A QUANTIDADE DE ESCALADORES POR REGIÃO");

                            sw.WriteLine("CIDADE;QUANTIDADE CIDADE");
                            foreach (var c in lugaresCidades)
                            {
                                sw.WriteLine("{0};{1} ", c.Cidade, c.QuantidadeCidade);
                            }
                            sw.WriteLine("");
                            sw.WriteLine("ESTADO;QUANTIDADE ESTADO");
                            foreach (var c in lugaresEstados)
                            {
                                sw.WriteLine("{0};{1} ", c.Estados, c.QuantidadeEstados);
                            }
                            sw.WriteLine("");
                            sw.WriteLine("CIDADE;QUANTIDADE CIDADE");
                            foreach (var c in lugaresPaíses)
                            {
                                sw.WriteLine("{0};{1} ", c.Paises, c.QuantidadePaíses);
                            }

                           


                        }
                        if (save.FilterIndex == 3)
                        {



                            sw.WriteLine("PERÍODO ESCOLHIDO");
                            sw.WriteLine("DATA DE INÍCIO: {0}  ----- DATA DE TÉRMINO: {1} ", dtpInicioConsulta.Value.ToShortDateString(), dtpFimConsulta.Value.ToShortDateString());
                            sw.WriteLine("");
                            sw.WriteLine("LISTA DAS LOCALIDADES E A QUANTIDADE DE ESCALADORES POR REGIÃO");

                            sw.WriteLine("CIDADE - QUANTIDADE CIDADE");
                            foreach (var c in lugaresCidades)
                            {
                                sw.WriteLine("{0} - {1} ", c.Cidade, c.QuantidadeCidade);
                            }
                            sw.WriteLine("");
                            sw.WriteLine("ESTADO - QUANTIDADE ESTADO");
                            foreach (var c in lugaresEstados)
                            {
                                sw.WriteLine("{0} - {1} ", c.Estados, c.QuantidadeEstados);
                            }
                            sw.WriteLine("");
                            sw.WriteLine("PAÍSES - QUANTIDADE PAÍSES");
                            foreach (var c in lugaresPaíses)
                            {
                                sw.WriteLine("{0} - {1} ", c.Paises, c.QuantidadePaíses);
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

        
    }
}

    
