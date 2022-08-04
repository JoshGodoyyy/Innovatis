namespace Innovatis {
    partial class Main {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_funcao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_versao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_horario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fornecedores = new System.Windows.Forms.Button();
            this.btn_novoCliente = new System.Windows.Forms.Button();
            this.btn_materiais = new System.Windows.Forms.Button();
            this.btn_obrasEmAndamento = new System.Windows.Forms.Button();
            this.btn_obrasConcluidas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_novaObra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_usuario,
            this.lbl_funcao,
            this.lbl_versao,
            this.toolStripStatusLabel1,
            this.lbl_horario,
            this.lbl_data});
            this.statusStrip1.Location = new System.Drawing.Point(0, 737);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(34, 19);
            this.lbl_usuario.Text = "User";
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(50, 19);
            this.lbl_funcao.Text = "Função";
            // 
            // lbl_versao
            // 
            this.lbl_versao.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(33, 19);
            this.lbl_versao.Text = "V3.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(945, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lbl_horario
            // 
            this.lbl_horario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(38, 19);
            this.lbl_horario.Text = "00:00";
            // 
            // lbl_data
            // 
            this.lbl_data.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(69, 19);
            this.lbl_data.Text = "01/01/2022";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fornecedores);
            this.panel1.Controls.Add(this.btn_novoCliente);
            this.panel1.Controls.Add(this.btn_materiais);
            this.panel1.Controls.Add(this.btn_obrasEmAndamento);
            this.panel1.Controls.Add(this.btn_obrasConcluidas);
            this.panel1.Controls.Add(this.btn_clientes);
            this.panel1.Controls.Add(this.btn_novaObra);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 100);
            this.panel1.TabIndex = 4;
            // 
            // btn_fornecedores
            // 
            this.btn_fornecedores.Image = global::Innovatis.Properties.Resources.Fornecedor;
            this.btn_fornecedores.Location = new System.Drawing.Point(626, 3);
            this.btn_fornecedores.Name = "btn_fornecedores";
            this.btn_fornecedores.Size = new System.Drawing.Size(94, 94);
            this.btn_fornecedores.TabIndex = 6;
            this.btn_fornecedores.Text = "Fornecedores";
            this.btn_fornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_fornecedores.UseVisualStyleBackColor = true;
            this.btn_fornecedores.Click += new System.EventHandler(this.btn_fornecedores_Click);
            // 
            // btn_novoCliente
            // 
            this.btn_novoCliente.Image = global::Innovatis.Properties.Resources.Cliente;
            this.btn_novoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_novoCliente.Location = new System.Drawing.Point(419, 3);
            this.btn_novoCliente.Name = "btn_novoCliente";
            this.btn_novoCliente.Size = new System.Drawing.Size(94, 94);
            this.btn_novoCliente.TabIndex = 4;
            this.btn_novoCliente.Text = "Novo cliente";
            this.btn_novoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novoCliente.UseVisualStyleBackColor = true;
            this.btn_novoCliente.Click += new System.EventHandler(this.btn_novoCliente_Click);
            // 
            // btn_materiais
            // 
            this.btn_materiais.Image = global::Innovatis.Properties.Resources.Material;
            this.btn_materiais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_materiais.Location = new System.Drawing.Point(212, 3);
            this.btn_materiais.Name = "btn_materiais";
            this.btn_materiais.Size = new System.Drawing.Size(94, 94);
            this.btn_materiais.TabIndex = 2;
            this.btn_materiais.Text = "Pedido de material";
            this.btn_materiais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_materiais.UseVisualStyleBackColor = true;
            this.btn_materiais.Click += new System.EventHandler(this.btn_materiais_Click);
            // 
            // btn_obrasEmAndamento
            // 
            this.btn_obrasEmAndamento.Image = global::Innovatis.Properties.Resources.Obra;
            this.btn_obrasEmAndamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_obrasEmAndamento.Location = new System.Drawing.Point(312, 3);
            this.btn_obrasEmAndamento.Name = "btn_obrasEmAndamento";
            this.btn_obrasEmAndamento.Size = new System.Drawing.Size(94, 94);
            this.btn_obrasEmAndamento.TabIndex = 3;
            this.btn_obrasEmAndamento.Text = "Obras em andamento";
            this.btn_obrasEmAndamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_obrasEmAndamento.UseVisualStyleBackColor = true;
            this.btn_obrasEmAndamento.Click += new System.EventHandler(this.btn_obrasEmAndamento_Click);
            // 
            // btn_obrasConcluidas
            // 
            this.btn_obrasConcluidas.Image = global::Innovatis.Properties.Resources.Obras_finalizadas;
            this.btn_obrasConcluidas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_obrasConcluidas.Location = new System.Drawing.Point(112, 3);
            this.btn_obrasConcluidas.Name = "btn_obrasConcluidas";
            this.btn_obrasConcluidas.Size = new System.Drawing.Size(94, 94);
            this.btn_obrasConcluidas.TabIndex = 1;
            this.btn_obrasConcluidas.Text = "Obras concluidas";
            this.btn_obrasConcluidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_obrasConcluidas.UseVisualStyleBackColor = true;
            this.btn_obrasConcluidas.Click += new System.EventHandler(this.btn_obrasConcluidas_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Image = global::Innovatis.Properties.Resources.Clientes;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clientes.Location = new System.Drawing.Point(519, 3);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(94, 94);
            this.btn_clientes.TabIndex = 5;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_novaObra
            // 
            this.btn_novaObra.Image = global::Innovatis.Properties.Resources.Nova_obra;
            this.btn_novaObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_novaObra.Location = new System.Drawing.Point(12, 3);
            this.btn_novaObra.Name = "btn_novaObra";
            this.btn_novaObra.Size = new System.Drawing.Size(94, 94);
            this.btn_novaObra.TabIndex = 0;
            this.btn_novaObra.Text = "Nova obra";
            this.btn_novaObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novaObra.UseVisualStyleBackColor = true;
            this.btn_novaObra.Click += new System.EventHandler(this.btn_novaObra_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(619, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 94);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(412, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 94);
            this.panel2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Innovatis.Properties.Resources.Icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovatis";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_versao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_horario;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.Button btn_fornecedores;
        private System.Windows.Forms.Button btn_novoCliente;
        private System.Windows.Forms.Button btn_materiais;
        private System.Windows.Forms.Button btn_obrasEmAndamento;
        private System.Windows.Forms.Button btn_obrasConcluidas;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_novaObra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel lbl_usuario;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripStatusLabel lbl_funcao;
        public System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}

