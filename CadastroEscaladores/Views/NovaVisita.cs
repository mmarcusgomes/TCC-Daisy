using CadastroEscalador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace CadastroEscaladores
{
    public partial class NovaVisita : Form
    {
        private string identidadeEscalador;

        //private IList regIdentidades;

            Principal MarcaDagua = new Principal();
       
        public NovaVisita(string identidadeEscalador)
        {
            InitializeComponent();
            this.identidadeEscalador = identidadeEscalador;

            #region Marca D´agua
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtAddEntrada);
            sList.Add("00:00");
            tList.Add(txtAddSaida);
            sList.Add("00:00");
            MarcaDagua.SetCueBanner(ref tList, sList);
            #endregion
            using (var banco = new DBEscaladores())
            {
                var nome = banco.Escaladores.Where(s => s.identidade == identidadeEscalador).First();
               

                lblNome.Text = nome.nome.ToString();
            }

        }       
        private void btnSalvarNovaVisitaEscalador_Click(object sender, EventArgs e)
        {
            var novoRegistro = new Registro();
            // Não é um campo obrigatorio
            try
            {
                var identidade = identidadeEscalador.ToString();
                using (var banco = new DBEscaladores())
                {
                    
                    
                    if (txtAddSaida.Text == "")
                    {
                        novoRegistro.saida = null;
                    }
                    else
                    {
                        novoRegistro.saida = TimeSpan.Parse(txtAddSaida.Text);
                    }
                    novoRegistro.numPulseira = int.Parse(txtAlterarPulseira.Text);

                    novoRegistro.escaladorIdentidade = identidade;
                    
                    novoRegistro.data = Convert.ToDateTime(dtpAlterarData.Value.Date);
                    novoRegistro.entrada =TimeSpan.Parse( txtAddEntrada.Text);
                    
                    novoRegistro.numPlacaID = int.Parse(txtNumPlacaID.Text);
                                       
                    //novoRegistro.valor = decimal.Parse(txtValor.Text);
                    if(cmbValorPago.Text == "R$5,00 - Meia Entrada")
                    {
                        novoRegistro.valor = 5;
                    }else if(cmbValorPago.Text == "R$10,00 - Inteira")
                    {
                        novoRegistro.valor = 10;
                    }else if(ckbCortesia.Checked)
                    {
                        novoRegistro.valor = 0;
                    }else
                    {
                        novoRegistro.valor = decimal.Parse( cmbValorPago.Text);
                    }

                    banco.Registros.Add(novoRegistro);
                    banco.SaveChanges();


                    string mensagem = "Cadastro Feito com Sucesso!!!";
                    MessageBox.Show(mensagem);
                   
                  
                    
                    this.Close();
                   
                }
                
            }
            catch 
            {

                MessageBox.Show("Preencha todos os campos obrigatórios", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        #region Apenas Numeros
        private void txtAlterarPulseira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void txtAlterarSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ':')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        private void txtAlterarEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ':')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void NovaVisita_Load(object sender, EventArgs e)
        {

        }

        private void ckbCortesia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCortesia.Checked)
            {
                cmbValorPago.Enabled=false;
            }else
            {
                cmbValorPago.Enabled = true;
            }
        }
        private void cmbValorPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbValorPago.SelectedIndex != 0)
            {
                ckbCortesia.Enabled = false;
            }
            else
            {
                ckbCortesia.Enabled = true;
            }
        }
    }


}
