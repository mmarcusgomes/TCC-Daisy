using CadastroEscaladores;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CadastroEscalador
{

    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();
           // dtoCadastro.Format = DateTimePickerFormat.Custom;
          //  dtoCadastro.CustomFormat = "dd/MM/yyyy ";
        }       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novoEscalador = new Escalador();
            // var novoRegistro = new Registro();
            if (txtIdentidade.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Os campos de \"Documento de identificação e Nome\" são obrigatórios !!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                using (var _dbeEscalador = new DBEscaladores())
                {
                    var identidadeProcurar = txtIdentidade.Text;
                    var registros = _dbeEscalador.Escaladores.Where(E => E.identidade == identidadeProcurar).Count();
                    if (registros == 0)
                    {
                        try
                        {

                            novoEscalador.nome = RemoverAcentos(txtNome.Text);
                            novoEscalador.identidade = txtIdentidade.Text;
                            novoEscalador.país = cmbPaísEscalador.Text;
                            novoEscalador.cidade = cmbCidadeEscalador.Text;
                            novoEscalador.UF = cmbEstadoEscalador.Text;
                            novoEscalador.CEP = txtCEP.Text;
                            if (txtNumeroEndereco.Text == "")
                            {
                                novoEscalador.numEndereco = null;
                            }
                            else
                            {
                                novoEscalador.numEndereco = int.Parse(txtNumeroEndereco.Text);
                            }

                            novoEscalador.clubeAssociacao = txtClubeAssociacao.Text;
                            novoEscalador.bairro = txtBairro.Text;
                            novoEscalador.telefone = txtTelefoneEscalador.Text;
                            novoEscalador.email = txtEmail.Text;
                            novoEscalador.tipoSanguineo = txtTipoSanguineo.Text;
                            novoEscalador.profissao = txtProfissao.Text;
                            novoEscalador.nomeContatoEmergencia = txtContatoEmergencia.Text;
                            novoEscalador.telefoneEmergencia = txtTelefoneEmergencia.Text;
                            novoEscalador.complementoEndereco = txtComplemento.Text;
                            novoEscalador.endereco = txtEndereco.Text;



                            if (rbtCPF.Checked)
                            {
                                novoEscalador.tipoIdentidade = "CPF";
                            }
                            else if (rbtRG.Checked)
                            {
                                novoEscalador.tipoIdentidade = "RG";
                            }
                            else if (rbtOutroDocumento.Checked)
                            {
                                novoEscalador.tipoIdentidade = "Outro Documento";
                            }



                            if (rbtMasculino.Checked)
                            {
                                novoEscalador.genero = "MASCULINO";
                            }
                            else if (rbtFeminino.Checked)
                            {
                                novoEscalador.genero = "FEMININO";
                            }

                            _dbeEscalador.Escaladores.Add(novoEscalador);
                            // novoRegistro.IdentidadeEscalador = novoEscalador;
                            // _dbeEscalador.Registros.Add(novoRegistro);
                            _dbeEscalador.SaveChanges();


                            string mensagem = "Cadastro Feito com Sucesso!!!";
                            MessageBox.Show(mensagem);


                            this.Close();

                        }

                        catch
                        {
                            MessageBox.Show("O campo de \" Documento de identificação\" é obrigatório !!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Já existe um usuário com este numero de identificação,apenas adicione uma nova entrada!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }
        public static string RemoverAcentos(string texto)
        {

            string s = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < s.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(s[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[k]);
                }
            }
            return sb.ToString();
        }
        #region KeyPress ApenasNumeros

        private void txtPulseira_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtNome_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        
        
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ':')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ':')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        #endregion
        #region KeyPress ApenasLetras

        
        private void txtProfissao_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void txtContatoEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cmbCidadeEscalador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cmbPaísEscalador_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void cmbEstadoEscalador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                // MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void cmbEstadoEscalador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //habilitar a abertura automatica da combo.
            // cmbEstadoEscalador.DroppedDown = true;
        }
        private void cmbEstadoEscalador_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstadoEscalador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEstadoEscalador.KeyPress += new KeyPressEventHandler(cmbEstadoEscalador_KeyPress);

        }
        private void cmbCidadeEscalador_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidadeEscalador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCidadeEscalador.KeyPress += new KeyPressEventHandler(cmbEstadoEscalador_KeyPress);
        }
        private void cmbCidadeEscalador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");            // Se pressionar ENTER então envia um TAB 
            }
        }
        private void cmbEstadoEscalador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");            // Se pressionar ENTER então envia um TAB 
            }
        }
        private void cmbPaísEscalador_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPaísEscalador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaísEscalador.KeyPress += new KeyPressEventHandler(cmbEstadoEscalador_KeyPress);
        }
        private void cmbPaísEscalador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");            // Se pressionar ENTER então envia um TAB 
            }
        }
        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void cmbEstadoEscalador_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbPaísEscalador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbCidadeEscalador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

       
    }
}