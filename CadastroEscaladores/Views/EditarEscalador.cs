using CadastroEscaladores;
using System;
using System.IO;
using System.Windows.Forms;

namespace CadastroEscalador
{
    public partial class EditarEscalador : Form
    {

        private Escalador _editarEscalador;
        
        public EditarEscalador()
        {
            InitializeComponent();

        }
        #region KeyPress ApenasLetras

        private void txtAlterarContatoEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }
        private void txtAlterarNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CmbCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
      
        #endregion
        #region KeyPress ApenasNumeros

        private void TxtAlterarIdentidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

       

        



        #endregion

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAlterarCidadeEscalador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAlterarCidadeEscalador.KeyPress += new KeyPressEventHandler(CmbCidade_KeyPress);
        }
        private void CmbCidade_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");            // Se pressionar ENTER então envia um TAB 
            }
        }
        private void BtnCancelar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void BtnSalvarAteracoes_Click(object sender, EventArgs e)
        {
                try
                {

                    if (rbtMasculino.Checked)
                    {
                        _editarEscalador.genero = "MASCULINO";
                    }
                    else if (rbtFeminino.Checked)
                    {
                        _editarEscalador.genero = "FEMININO";
                    }
                    _editarEscalador.nome = txtAlterarNome.Text;
                    _editarEscalador.cidade = cmbAlterarCidadeEscalador.Text;
                    _editarEscalador.bairro = txtAlterarBairro.Text;
                    _editarEscalador.CEP = txtAlterarCEP.Text;
                    _editarEscalador.clubeAssociacao = txtAlterarClubeAssociacao.Text;
                    _editarEscalador.complementoEndereco = txtAlterarComplemento.Text;
                    _editarEscalador.email = txtAlterarEmail.Text;
                    _editarEscalador.endereco = txtAlterarEndereco.Text;
                    _editarEscalador.nomeContatoEmergencia = txtAlterarContatoEmergencia.Text;

                    if (txtAlterarNumeroEndereco.Text == "")
                    {
                        _editarEscalador.numEndereco = null;
                    }
                    else
                    {
                        _editarEscalador.numEndereco = int.Parse(txtAlterarNumeroEndereco.Text);
                    }


                    _editarEscalador.país = cmbAlterarPaísEscalador.Text;
                    _editarEscalador.profissao = txtAlterarProfissao.Text;
                    _editarEscalador.telefone = txtAlterarTelefoneEscalador.Text;
                    _editarEscalador.telefoneEmergencia = txtAlterarTelefoneEmergencia.Text;
                    _editarEscalador.UF = cmbAlterarEstadoEscalador.Text;

                    using (var banco = new DBEscaladores())
                    {
                        banco.Entry(_editarEscalador).State = System.Data.Entity.EntityState.Modified;

                        banco.SaveChanges();
                    }
                    string mensagem = "Alteração feita com Sucesso!!!";
                    MessageBox.Show(mensagem);
                    this.Close();
                }
                catch (IOException E)
                {
                    MessageBox.Show((E.Source));
                    MessageBox.Show("ERRO{0}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
            
          

        }
        private void BtnBuscarEscalador_Click(object sender, EventArgs e)
        {


          
            
          
                using (var banco = new DBEscaladores())
                {
                    _editarEscalador = banco.Escaladores.Find(txtBuscarIdentidade.Text);

                }
                if (_editarEscalador != null)
                {

                    txtAlterarNome.Text = _editarEscalador.nome;
                    txtAlterarBairro.Text = _editarEscalador.bairro;
                    txtAlterarCEP.Text = _editarEscalador.CEP;
                txtAlterarClubeAssociacao.Text = _editarEscalador.clubeAssociacao;
                    txtAlterarComplemento.Text = _editarEscalador.complementoEndereco;
                    txtAlterarContatoEmergencia.Text = _editarEscalador.nomeContatoEmergencia;
                    txtAlterarEmail.Text = _editarEscalador.email;
                    txtAlterarEndereco.Text = _editarEscalador.endereco;
                    txtAlterarNumeroEndereco.Text = Convert.ToString(_editarEscalador.numEndereco);
                    txtAlterarProfissao.Text = _editarEscalador.profissao;
                    txtAlterarTelefoneEmergencia.Text = _editarEscalador.telefoneEmergencia;
                    txtAlterarTelefoneEscalador.Text = _editarEscalador.telefone;
                    cmbAlterarCidadeEscalador.Text = _editarEscalador.cidade;
                    cmbAlterarEstadoEscalador.Text = _editarEscalador.UF;
                    cmbAlterarPaísEscalador.Text = _editarEscalador.país;

               
                    

                }
                
                else
                {
                    MessageBox.Show("Não existe registro para esse número de identificação", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtBuscarIdentidade.Text = "";
            
               
        }

        private void EditarEscalador_Load(object sender, EventArgs e)
        {

        }

        private void cmbAlterarCidadeEscalador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbAlterarEstadoEscalador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbAlterarPaísEscalador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtAlterarNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                {
                    e.Handled = true;
                    // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
        }

        
    }
}

        
    
