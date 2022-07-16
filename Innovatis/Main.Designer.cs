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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novoCliente = new System.Windows.Forms.Button();
            this.btn_obrasEmAndamento = new System.Windows.Forms.Button();
            this.btn_obrasConcluidas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_novaObra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_novoCliente);
            this.panel1.Controls.Add(this.btn_obrasEmAndamento);
            this.panel1.Controls.Add(this.btn_obrasConcluidas);
            this.panel1.Controls.Add(this.btn_clientes);
            this.panel1.Controls.Add(this.btn_novaObra);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_novoCliente
            // 
            this.btn_novoCliente.Image = global::Innovatis.Properties.Resources.Cliente;
            this.btn_novoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_novoCliente.Location = new System.Drawing.Point(319, 3);
            this.btn_novoCliente.Name = "btn_novoCliente";
            this.btn_novoCliente.Size = new System.Drawing.Size(94, 94);
            this.btn_novoCliente.TabIndex = 3;
            this.btn_novoCliente.Text = "Novo cliente";
            this.btn_novoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novoCliente.UseVisualStyleBackColor = true;
            this.btn_novoCliente.Click += new System.EventHandler(this.btn_novoCliente_Click);
            // 
            // btn_obrasEmAndamento
            // 
            this.btn_obrasEmAndamento.Image = global::Innovatis.Properties.Resources.Obra;
            this.btn_obrasEmAndamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_obrasEmAndamento.Location = new System.Drawing.Point(212, 3);
            this.btn_obrasEmAndamento.Name = "btn_obrasEmAndamento";
            this.btn_obrasEmAndamento.Size = new System.Drawing.Size(94, 94);
            this.btn_obrasEmAndamento.TabIndex = 2;
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
            this.btn_clientes.Location = new System.Drawing.Point(419, 3);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(94, 94);
            this.btn_clientes.TabIndex = 4;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(312, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 94);
            this.panel2.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovatis";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_novaObra;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_novoCliente;
        private System.Windows.Forms.Button btn_obrasEmAndamento;
        private System.Windows.Forms.Button btn_obrasConcluidas;
    }
}

