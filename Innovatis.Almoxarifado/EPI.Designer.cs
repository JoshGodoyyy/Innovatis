namespace Innovatis.Almoxarifado {
    partial class EPI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmr_quantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_entrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_funcionarios = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_itens = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_entregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(218, 43);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(200, 20);
            this.txt_descricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // nmr_quantidade
            // 
            this.nmr_quantidade.Location = new System.Drawing.Point(218, 82);
            this.nmr_quantidade.Name = "nmr_quantidade";
            this.nmr_quantidade.Size = new System.Drawing.Size(65, 20);
            this.nmr_quantidade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // dt_entrega
            // 
            this.dt_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_entrega.Location = new System.Drawing.Point(289, 82);
            this.dt_entrega.Name = "dt_entrega";
            this.dt_entrega.Size = new System.Drawing.Size(129, 20);
            this.dt_entrega.TabIndex = 5;
            this.dt_entrega.Value = new System.DateTime(2022, 8, 22, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Funcionário:";
            // 
            // cb_funcionarios
            // 
            this.cb_funcionarios.FormattingEnabled = true;
            this.cb_funcionarios.Location = new System.Drawing.Point(218, 121);
            this.cb_funcionarios.Name = "cb_funcionarios";
            this.cb_funcionarios.Size = new System.Drawing.Size(200, 21);
            this.cb_funcionarios.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_itens);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // lst_itens
            // 
            this.lst_itens.FormattingEnabled = true;
            this.lst_itens.Location = new System.Drawing.Point(6, 19);
            this.lst_itens.Name = "lst_itens";
            this.lst_itens.Size = new System.Drawing.Size(188, 121);
            this.lst_itens.TabIndex = 0;
            this.lst_itens.SelectedIndexChanged += new System.EventHandler(this.lst_itens_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensalToolStripMenuItem,
            this.porFuncionárioToolStripMenuItem});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.relatorioToolStripMenuItem.Text = "Relatórios";
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.relatorioToolStripMenuItem_Click);
            // 
            // mensalToolStripMenuItem
            // 
            this.mensalToolStripMenuItem.Name = "mensalToolStripMenuItem";
            this.mensalToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mensalToolStripMenuItem.Text = "Mensal";
            // 
            // porFuncionárioToolStripMenuItem
            // 
            this.porFuncionárioToolStripMenuItem.Name = "porFuncionárioToolStripMenuItem";
            this.porFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.porFuncionárioToolStripMenuItem.Text = "Por Funcionário";
            this.porFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.porFuncionárioToolStripMenuItem_Click);
            // 
            // btn_entregar
            // 
            this.btn_entregar.Location = new System.Drawing.Point(343, 148);
            this.btn_entregar.Name = "btn_entregar";
            this.btn_entregar.Size = new System.Drawing.Size(75, 25);
            this.btn_entregar.TabIndex = 10;
            this.btn_entregar.Text = "Entregar";
            this.btn_entregar.UseVisualStyleBackColor = true;
            this.btn_entregar.Click += new System.EventHandler(this.btn_entregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Em estoque:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(290, 154);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(13, 13);
            this.lbl_quantidade.TabIndex = 12;
            this.lbl_quantidade.Text = "0";
            // 
            // EPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 185);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_entregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_funcionarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_entrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmr_quantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPI";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmr_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_entrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_funcionarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_itens;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_entregar;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFuncionárioToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_quantidade;
    }
}