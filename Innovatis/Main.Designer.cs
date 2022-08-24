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
            this.lbl_computador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_horario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbon = new System.Windows.Forms.Panel();
            this.btn_novaObra = new System.Windows.Forms.Button();
            this.btn_fornecedores = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_novoCliente = new System.Windows.Forms.Button();
            this.btn_obrasConcluidas = new System.Windows.Forms.Button();
            this.btn_materiais = new System.Windows.Forms.Button();
            this.btn_obrasEmAndamento = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tr_caminhos = new System.Windows.Forms.TreeView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ribbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_usuario,
            this.lbl_funcao,
            this.lbl_versao,
            this.lbl_computador,
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
            // lbl_computador
            // 
            this.lbl_computador.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_computador.Name = "lbl_computador";
            this.lbl_computador.Size = new System.Drawing.Size(122, 19);
            this.lbl_computador.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(690, 19);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.ribbon);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 100);
            this.panel1.TabIndex = 4;
            // 
            // ribbon
            // 
            this.ribbon.Controls.Add(this.btn_novaObra);
            this.ribbon.Controls.Add(this.btn_fornecedores);
            this.ribbon.Controls.Add(this.btn_clientes);
            this.ribbon.Controls.Add(this.btn_novoCliente);
            this.ribbon.Controls.Add(this.btn_obrasConcluidas);
            this.ribbon.Controls.Add(this.btn_materiais);
            this.ribbon.Controls.Add(this.btn_obrasEmAndamento);
            this.ribbon.Location = new System.Drawing.Point(12, 0);
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(706, 100);
            this.ribbon.TabIndex = 8;
            // 
            // btn_novaObra
            // 
            this.btn_novaObra.Image = global::Innovatis.Properties.Resources.Nova_obra;
            this.btn_novaObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_novaObra.Location = new System.Drawing.Point(3, 3);
            this.btn_novaObra.Name = "btn_novaObra";
            this.btn_novaObra.Size = new System.Drawing.Size(94, 94);
            this.btn_novaObra.TabIndex = 0;
            this.btn_novaObra.Text = "Nova obra";
            this.btn_novaObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novaObra.UseVisualStyleBackColor = true;
            this.btn_novaObra.Click += new System.EventHandler(this.btn_novaObra_Click);
            // 
            // btn_fornecedores
            // 
            this.btn_fornecedores.Image = global::Innovatis.Properties.Resources.Fornecedor;
            this.btn_fornecedores.Location = new System.Drawing.Point(603, 3);
            this.btn_fornecedores.Name = "btn_fornecedores";
            this.btn_fornecedores.Size = new System.Drawing.Size(94, 94);
            this.btn_fornecedores.TabIndex = 6;
            this.btn_fornecedores.Text = "Fornecedores";
            this.btn_fornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_fornecedores.UseVisualStyleBackColor = true;
            this.btn_fornecedores.Click += new System.EventHandler(this.btn_fornecedores_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Image = global::Innovatis.Properties.Resources.Clientes;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clientes.Location = new System.Drawing.Point(503, 3);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(94, 94);
            this.btn_clientes.TabIndex = 5;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_novoCliente
            // 
            this.btn_novoCliente.Image = global::Innovatis.Properties.Resources.Cliente;
            this.btn_novoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_novoCliente.Location = new System.Drawing.Point(403, 3);
            this.btn_novoCliente.Name = "btn_novoCliente";
            this.btn_novoCliente.Size = new System.Drawing.Size(94, 94);
            this.btn_novoCliente.TabIndex = 4;
            this.btn_novoCliente.Text = "Novo cliente";
            this.btn_novoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novoCliente.UseVisualStyleBackColor = true;
            this.btn_novoCliente.Click += new System.EventHandler(this.btn_novoCliente_Click);
            // 
            // btn_obrasConcluidas
            // 
            this.btn_obrasConcluidas.Image = global::Innovatis.Properties.Resources.Obras_finalizadas;
            this.btn_obrasConcluidas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_obrasConcluidas.Location = new System.Drawing.Point(103, 3);
            this.btn_obrasConcluidas.Name = "btn_obrasConcluidas";
            this.btn_obrasConcluidas.Size = new System.Drawing.Size(94, 94);
            this.btn_obrasConcluidas.TabIndex = 1;
            this.btn_obrasConcluidas.Text = "Obras concluidas";
            this.btn_obrasConcluidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_obrasConcluidas.UseVisualStyleBackColor = true;
            this.btn_obrasConcluidas.Click += new System.EventHandler(this.btn_obrasConcluidas_Click);
            // 
            // btn_materiais
            // 
            this.btn_materiais.Image = global::Innovatis.Properties.Resources.Material;
            this.btn_materiais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_materiais.Location = new System.Drawing.Point(203, 3);
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
            this.btn_obrasEmAndamento.Location = new System.Drawing.Point(303, 3);
            this.btn_obrasEmAndamento.Name = "btn_obrasEmAndamento";
            this.btn_obrasEmAndamento.Size = new System.Drawing.Size(94, 94);
            this.btn_obrasEmAndamento.TabIndex = 3;
            this.btn_obrasEmAndamento.Text = "Obras em andamento";
            this.btn_obrasEmAndamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_obrasEmAndamento.UseVisualStyleBackColor = true;
            this.btn_obrasEmAndamento.Click += new System.EventHandler(this.btn_obrasEmAndamento_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.Location = new System.Drawing.Point(1078, 3);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(94, 94);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tr_caminhos
            // 
            this.tr_caminhos.Dock = System.Windows.Forms.DockStyle.Left;
            this.tr_caminhos.Location = new System.Drawing.Point(0, 100);
            this.tr_caminhos.Name = "tr_caminhos";
            this.tr_caminhos.Size = new System.Drawing.Size(228, 637);
            this.tr_caminhos.TabIndex = 6;
            this.tr_caminhos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tr_caminhos_AfterSelect);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(0, 575);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Innovatis.Properties.Resources.Icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tr_caminhos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovatis";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ribbon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_versao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_horario;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data;
        private System.Windows.Forms.Button btn_fornecedores;
        private System.Windows.Forms.Button btn_novoCliente;
        private System.Windows.Forms.Button btn_materiais;
        private System.Windows.Forms.Button btn_obrasEmAndamento;
        private System.Windows.Forms.Button btn_obrasConcluidas;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_novaObra;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel lbl_usuario;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripStatusLabel lbl_funcao;
        private System.Windows.Forms.TreeView tr_caminhos;
        private System.Windows.Forms.Button btn_sair;
        public System.Windows.Forms.Panel ribbon;
        private System.Windows.Forms.ToolStripStatusLabel lbl_computador;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

