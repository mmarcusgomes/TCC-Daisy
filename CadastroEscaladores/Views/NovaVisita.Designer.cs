namespace CadastroEscaladores
{
    partial class NovaVisita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVisita));
            this.dtpAlterarData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddSaida = new System.Windows.Forms.TextBox();
            this.txtAddEntrada = new System.Windows.Forms.TextBox();
            this.txtAlterarPulseira = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarNovaVisitaEscalador = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbValorPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumPlacaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckbCortesia = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpAlterarData
            // 
            this.dtpAlterarData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlterarData.Location = new System.Drawing.Point(57, 12);
            this.dtpAlterarData.Name = "dtpAlterarData";
            this.dtpAlterarData.Size = new System.Drawing.Size(111, 21);
            this.dtpAlterarData.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 131;
            this.label3.Text = "Data:";
            // 
            // txtAddSaida
            // 
            this.txtAddSaida.Location = new System.Drawing.Point(305, 22);
            this.txtAddSaida.Name = "txtAddSaida";
            this.txtAddSaida.Size = new System.Drawing.Size(88, 21);
            this.txtAddSaida.TabIndex = 3;
            this.txtAddSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlterarSaida_KeyPress);
            // 
            // txtAddEntrada
            // 
            this.txtAddEntrada.Location = new System.Drawing.Point(100, 22);
            this.txtAddEntrada.Name = "txtAddEntrada";
            this.txtAddEntrada.Size = new System.Drawing.Size(88, 21);
            this.txtAddEntrada.TabIndex = 2;
            this.txtAddEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlterarEntrada_KeyPress);
            // 
            // txtAlterarPulseira
            // 
            this.txtAlterarPulseira.Location = new System.Drawing.Point(100, 20);
            this.txtAlterarPulseira.Name = "txtAlterarPulseira";
            this.txtAlterarPulseira.Size = new System.Drawing.Size(88, 21);
            this.txtAlterarPulseira.TabIndex = 4;
            this.txtAlterarPulseira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlterarPulseira_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 128;
            this.label6.Text = "N° da Pulseira:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 127;
            this.label5.Text = "Saída:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 126;
            this.label4.Text = " Entrada:";
            // 
            // btnSalvarNovaVisitaEscalador
            // 
            this.btnSalvarNovaVisitaEscalador.Location = new System.Drawing.Point(381, 303);
            this.btnSalvarNovaVisitaEscalador.Name = "btnSalvarNovaVisitaEscalador";
            this.btnSalvarNovaVisitaEscalador.Size = new System.Drawing.Size(101, 43);
            this.btnSalvarNovaVisitaEscalador.TabIndex = 8;
            this.btnSalvarNovaVisitaEscalador.Text = "Salvar Nova Visita";
            this.btnSalvarNovaVisitaEscalador.UseVisualStyleBackColor = true;
            this.btnSalvarNovaVisitaEscalador.Click += new System.EventHandler(this.btnSalvarNovaVisitaEscalador_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(274, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAddEntrada);
            this.groupBox2.Controls.Add(this.txtAddSaida);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 58);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 17);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 128;
            this.label8.Text = "*";
            // 
            // cmbValorPago
            // 
            this.cmbValorPago.FormattingEnabled = true;
            this.cmbValorPago.Items.AddRange(new object[] {
            "",
            "R$5,00 - Meia Entrada",
            "R$10,00 - Inteira"});
            this.cmbValorPago.Location = new System.Drawing.Point(98, 20);
            this.cmbValorPago.Name = "cmbValorPago";
            this.cmbValorPago.Size = new System.Drawing.Size(156, 23);
            this.cmbValorPago.TabIndex = 6;
            this.cmbValorPago.SelectedIndexChanged += new System.EventHandler(this.cmbValorPago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 139;
            this.label1.Text = "Valor Pago:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumPlacaID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAlterarPulseira);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(18, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 59);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
            // 
            // txtNumPlacaID
            // 
            this.txtNumPlacaID.Location = new System.Drawing.Point(305, 23);
            this.txtNumPlacaID.Name = "txtNumPlacaID";
            this.txtNumPlacaID.Size = new System.Drawing.Size(88, 21);
            this.txtNumPlacaID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 129;
            this.label2.Text = "Placa ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 141;
            this.label7.Text = "Nome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(75, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 15);
            this.lblNome.TabIndex = 143;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ckbCortesia);
            this.groupBox3.Controls.Add(this.cmbValorPago);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(18, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 58);
            this.groupBox3.TabIndex = 144;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 141;
            this.label10.Text = "ou";
            // 
            // ckbCortesia
            // 
            this.ckbCortesia.AutoSize = true;
            this.ckbCortesia.Location = new System.Drawing.Point(303, 22);
            this.ckbCortesia.Name = "ckbCortesia";
            this.ckbCortesia.Size = new System.Drawing.Size(71, 19);
            this.ckbCortesia.TabIndex = 7;
            this.ckbCortesia.Text = "Cortesia";
            this.ckbCortesia.UseVisualStyleBackColor = true;
            this.ckbCortesia.CheckedChanged += new System.EventHandler(this.ckbCortesia_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 15);
            this.label9.TabIndex = 145;
            this.label9.Text = "(*) Campo não obrigatorio";
            // 
            // NovaVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 358);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpAlterarData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvarNovaVisitaEscalador);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovaVisita";
            this.Text = "Nova Visita";
            this.Load += new System.EventHandler(this.NovaVisita_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAlterarData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddSaida;
        private System.Windows.Forms.TextBox txtAddEntrada;
        private System.Windows.Forms.TextBox txtAlterarPulseira;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarNovaVisitaEscalador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbValorPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumPlacaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckbCortesia;
    }
}