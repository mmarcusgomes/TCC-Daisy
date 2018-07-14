namespace CadastroEscaladores
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.dgvConsultasEscaladores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtpFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalVisitas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuantHomens = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuantMulheres = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarConsulta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCortesia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPesquisarLocalidades = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasEscaladores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultasEscaladores
            // 
            this.dgvConsultasEscaladores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultasEscaladores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultasEscaladores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasEscaladores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column3,
            this.Quantidade});
            this.dgvConsultasEscaladores.Location = new System.Drawing.Point(14, 260);
            this.dgvConsultasEscaladores.Name = "dgvConsultasEscaladores";
            this.dgvConsultasEscaladores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultasEscaladores.Size = new System.Drawing.Size(612, 366);
            this.dgvConsultasEscaladores.TabIndex = 0;
            this.dgvConsultasEscaladores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultasEscaladores_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EscaladorIdentidade";
            this.Column1.HeaderText = "Número de Identificação";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Paises";
            this.Column5.HeaderText = "País";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Estado";
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cidade";
            this.Column6.HeaderText = "Cidade";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Genero";
            this.Column3.HeaderText = "Gênero";
            this.Column3.Name = "Column3";
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // dtpInicioConsulta
            // 
            this.dtpInicioConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioConsulta.Location = new System.Drawing.Point(115, 26);
            this.dtpInicioConsulta.Name = "dtpInicioConsulta";
            this.dtpInicioConsulta.Size = new System.Drawing.Size(118, 21);
            this.dtpInicioConsulta.TabIndex = 1;
            // 
            // dtpFimConsulta
            // 
            this.dtpFimConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimConsulta.Location = new System.Drawing.Point(367, 26);
            this.dtpFimConsulta.Name = "dtpFimConsulta";
            this.dtpFimConsulta.Size = new System.Drawing.Size(116, 21);
            this.dtpFimConsulta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Pago:";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(141, 67);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(0, 15);
            this.lblTotalPago.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total de Visitas:";
            // 
            // lblTotalVisitas
            // 
            this.lblTotalVisitas.AutoSize = true;
            this.lblTotalVisitas.Location = new System.Drawing.Point(141, 29);
            this.lblTotalVisitas.Name = "lblTotalVisitas";
            this.lblTotalVisitas.Size = new System.Drawing.Size(0, 15);
            this.lblTotalVisitas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Homens:";
            // 
            // lblQuantHomens
            // 
            this.lblQuantHomens.AutoSize = true;
            this.lblQuantHomens.Location = new System.Drawing.Point(385, 29);
            this.lblQuantHomens.Name = "lblQuantHomens";
            this.lblQuantHomens.Size = new System.Drawing.Size(0, 15);
            this.lblQuantHomens.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mulheres:";
            // 
            // lblQuantMulheres
            // 
            this.lblQuantMulheres.AutoSize = true;
            this.lblQuantMulheres.Location = new System.Drawing.Point(385, 68);
            this.lblQuantMulheres.Name = "lblQuantMulheres";
            this.lblQuantMulheres.Size = new System.Drawing.Size(0, 15);
            this.lblQuantMulheres.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data de Início:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data de Término:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnGerarConsulta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpInicioConsulta);
            this.groupBox1.Controls.Add(this.dtpFimConsulta);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // btnGerarConsulta
            // 
            this.btnGerarConsulta.Location = new System.Drawing.Point(507, 17);
            this.btnGerarConsulta.Name = "btnGerarConsulta";
            this.btnGerarConsulta.Size = new System.Drawing.Size(75, 33);
            this.btnGerarConsulta.TabIndex = 16;
            this.btnGerarConsulta.Text = "Pesquisar";
            this.btnGerarConsulta.UseVisualStyleBackColor = true;
            this.btnGerarConsulta.Click += new System.EventHandler(this.BtnGerarConsulta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblCortesia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblQuantMulheres);
            this.groupBox2.Controls.Add(this.lblTotalPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTotalVisitas);
            this.groupBox2.Controls.Add(this.lblQuantHomens);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 104);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantidade";
            // 
            // lblCortesia
            // 
            this.lblCortesia.AutoSize = true;
            this.lblCortesia.Location = new System.Drawing.Point(530, 29);
            this.lblCortesia.Name = "lblCortesia";
            this.lblCortesia.Size = new System.Drawing.Size(0, 15);
            this.lblCortesia.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cortesia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnPesquisarLocalidades);
            this.groupBox3.Location = new System.Drawing.Point(14, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 54);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Informações sobre ciddaes,estados e países :";
            // 
            // btnPesquisarLocalidades
            // 
            this.btnPesquisarLocalidades.Location = new System.Drawing.Point(354, 15);
            this.btnPesquisarLocalidades.Name = "btnPesquisarLocalidades";
            this.btnPesquisarLocalidades.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisarLocalidades.TabIndex = 0;
            this.btnPesquisarLocalidades.Text = "Pesquisar";
            this.btnPesquisarLocalidades.UseVisualStyleBackColor = true;
            this.btnPesquisarLocalidades.Click += new System.EventHandler(this.BtnPesquisarLocalidades_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem1});
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.salvarToolStripMenuItem.Text = "&Arquivo";
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.salvarToolStripMenuItem1.Text = "&Salvar Como";
            this.salvarToolStripMenuItem1.Click += new System.EventHandler(this.SalvarToolStripMenuItem1_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 638);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvConsultasEscaladores);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasEscaladores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultasEscaladores;
        private System.Windows.Forms.DateTimePicker dtpInicioConsulta;
        private System.Windows.Forms.DateTimePicker dtpFimConsulta;       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalVisitas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuantHomens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuantMulheres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPesquisarLocalidades;
        private System.Windows.Forms.Label lblCortesia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerarConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}