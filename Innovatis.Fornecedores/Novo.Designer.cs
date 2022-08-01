namespace Innovatis.Fornecedores {
    partial class Novo {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_responsavel = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_fornecedores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(12, 65);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(256, 20);
            this.txt_empresa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contato:";
            // 
            // txt_contato
            // 
            this.txt_contato.Location = new System.Drawing.Point(12, 104);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(100, 20);
            this.txt_contato.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(118, 104);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 20);
            this.txt_email.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Responsável:";
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.Location = new System.Drawing.Point(12, 143);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.Size = new System.Drawing.Size(256, 20);
            this.txt_responsavel.TabIndex = 4;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 169);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(93, 169);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 6;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fornecedores:";
            // 
            // cb_fornecedores
            // 
            this.cb_fornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fornecedores.FormattingEnabled = true;
            this.cb_fornecedores.Location = new System.Drawing.Point(12, 25);
            this.cb_fornecedores.Name = "cb_fornecedores";
            this.cb_fornecedores.Size = new System.Drawing.Size(256, 21);
            this.cb_fornecedores.TabIndex = 0;
            this.cb_fornecedores.SelectedIndexChanged += new System.EventHandler(this.cb_fornecedores_SelectedIndexChanged);
            // 
            // Novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 204);
            this.Controls.Add(this.cb_fornecedores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_responsavel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_empresa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Novo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_fornecedores;
    }
}

