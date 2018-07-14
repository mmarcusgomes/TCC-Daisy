using System;

namespace CadastroEscalador
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnEscalador = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditarEscalador = new System.Windows.Forms.Button();
            this.dgvEscaladores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneEmergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtNovaEntrada = new System.Windows.Forms.TextBox();
            this.btnBuscarEscalador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvarHorarioSaida = new System.Windows.Forms.Button();
            this.txtAddHorarioSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaladores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblContador);
            this.groupBox1.Location = new System.Drawing.Point(978, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 63);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HOJE";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(28, 26);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 29);
            this.lblContador.TabIndex = 6;
            // 
            // btnEscalador
            // 
            this.btnEscalador.Location = new System.Drawing.Point(814, 14);
            this.btnEscalador.Name = "btnEscalador";
            this.btnEscalador.Size = new System.Drawing.Size(101, 43);
            this.btnEscalador.TabIndex = 13;
            this.btnEscalador.Text = "Escalador";
            this.btnEscalador.UseVisualStyleBackColor = true;
            this.btnEscalador.Click += new System.EventHandler(this.BtnEscalador_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(626, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 43);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultas";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(438, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 43);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir Registro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditarEscalador
            // 
            this.btnEditarEscalador.Location = new System.Drawing.Point(223, 14);
            this.btnEditarEscalador.Name = "btnEditarEscalador";
            this.btnEditarEscalador.Size = new System.Drawing.Size(128, 43);
            this.btnEditarEscalador.TabIndex = 9;
            this.btnEditarEscalador.Text = "Editar Escalador";
            this.btnEditarEscalador.UseVisualStyleBackColor = true;
            this.btnEditarEscalador.Click += new System.EventHandler(this.BtnEditarEscalador_Click);
            // 
            // dgvEscaladores
            // 
            this.dgvEscaladores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEscaladores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEscaladores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscaladores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column9,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.telefoneEmergencia,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvEscaladores.Location = new System.Drawing.Point(12, 128);
            this.dgvEscaladores.Name = "dgvEscaladores";
            this.dgvEscaladores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEscaladores.Size = new System.Drawing.Size(1059, 469);
            this.dgvEscaladores.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome Completo";
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Cidade";
            this.Column9.HeaderText = "Cidade";
            this.Column9.Name = "Column9";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Estado";
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "País";
            this.Column10.HeaderText = "País";
            this.Column10.Name = "Column10";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Entrada";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Horário de Entrada";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Saida";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Horário de Saída";
            this.Column5.Name = "Column5";
            // 
            // telefoneEmergencia
            // 
            this.telefoneEmergencia.DataPropertyName = "TelefoneEmergencia";
            this.telefoneEmergencia.HeaderText = "Telefone de Emergência";
            this.telefoneEmergencia.Name = "telefoneEmergencia";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EscaladorIdentidade";
            this.Column2.HeaderText = "Número de Identificação";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NumPulseira";
            this.Column6.HeaderText = "Número da Pulseira";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NumPlacaID";
            this.Column7.HeaderText = "Número da Placa";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Genero";
            this.Column8.HeaderText = "Gênero";
            this.Column8.Name = "Column8";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(35, 12);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(101, 43);
            this.btnCadastro.TabIndex = 8;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // txtNovaEntrada
            // 
            this.txtNovaEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNovaEntrada.Location = new System.Drawing.Point(102, 21);
            this.txtNovaEntrada.Name = "txtNovaEntrada";
            this.txtNovaEntrada.Size = new System.Drawing.Size(217, 21);
            this.txtNovaEntrada.TabIndex = 15;
            // 
            // btnBuscarEscalador
            // 
            this.btnBuscarEscalador.Location = new System.Drawing.Point(346, 18);
            this.btnBuscarEscalador.Name = "btnBuscarEscalador";
            this.btnBuscarEscalador.Size = new System.Drawing.Size(87, 27);
            this.btnBuscarEscalador.TabIndex = 16;
            this.btnBuscarEscalador.Text = "Novo";
            this.btnBuscarEscalador.UseVisualStyleBackColor = true;
            this.btnBuscarEscalador.Click += new System.EventHandler(this.BtnBuscarEscalador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nova Entrada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCadastro);
            this.groupBox2.Controls.Add(this.btnEditarEscalador);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.btnEscalador);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 63);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnSalvarHorarioSaida
            // 
            this.btnSalvarHorarioSaida.Location = new System.Drawing.Point(460, 16);
            this.btnSalvarHorarioSaida.Name = "btnSalvarHorarioSaida";
            this.btnSalvarHorarioSaida.Size = new System.Drawing.Size(87, 29);
            this.btnSalvarHorarioSaida.TabIndex = 19;
            this.btnSalvarHorarioSaida.Text = "Salvar ";
            this.btnSalvarHorarioSaida.UseVisualStyleBackColor = true;
            this.btnSalvarHorarioSaida.Click += new System.EventHandler(this.BtnSalvarHorarioSaida_Click);
            // 
            // txtAddHorarioSaida
            // 
            this.txtAddHorarioSaida.Location = new System.Drawing.Point(361, 21);
            this.txtAddHorarioSaida.Name = "txtAddHorarioSaida";
            this.txtAddHorarioSaida.Size = new System.Drawing.Size(84, 21);
            this.txtAddHorarioSaida.TabIndex = 20;
            this.txtAddHorarioSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddHorarioSaida_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adicione o horário de saída para o escalador selecionado:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtNovaEntrada);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.btnBuscarEscalador);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1059, 53);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtAddHorarioSaida);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnSalvarHorarioSaida);
            this.groupBox3.Location = new System.Drawing.Point(497, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 53);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEscaladores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaladores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnEscalador;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditarEscalador;
        private System.Windows.Forms.DataGridView dgvEscaladores;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox txtNovaEntrada;
        private System.Windows.Forms.Button btnBuscarEscalador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvarHorarioSaida;
        private System.Windows.Forms.TextBox txtAddHorarioSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneEmergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}