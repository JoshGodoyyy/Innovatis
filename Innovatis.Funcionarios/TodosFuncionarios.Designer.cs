namespace Innovatis.Funcionarios {
    partial class TodosFuncionarios {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_funcionario = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_aso = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_nrs = new System.Windows.Forms.RadioButton();
            this.rb_registrados = new System.Windows.Forms.RadioButton();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.chk_registrado = new System.Windows.Forms.CheckBox();
            this.chk_ativo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_funcionario);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos";
            // 
            // lst_funcionario
            // 
            this.lst_funcionario.FormattingEnabled = true;
            this.lst_funcionario.Location = new System.Drawing.Point(6, 19);
            this.lst_funcionario.Name = "lst_funcionario";
            this.lst_funcionario.Size = new System.Drawing.Size(194, 95);
            this.lst_funcionario.TabIndex = 0;
            this.lst_funcionario.SelectedIndexChanged += new System.EventHandler(this.lst_funcionario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(6, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(300, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG.:";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(6, 71);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(147, 20);
            this.txt_rg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(159, 71);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(147, 20);
            this.txt_cpf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Empresa:";
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(6, 110);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(147, 20);
            this.txt_empresa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ASO:";
            // 
            // dt_aso
            // 
            this.dt_aso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_aso.Location = new System.Drawing.Point(6, 149);
            this.dt_aso.Name = "dt_aso";
            this.dt_aso.Size = new System.Drawing.Size(147, 20);
            this.dt_aso.TabIndex = 12;
            this.dt_aso.Value = new System.DateTime(2022, 8, 12, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_todos);
            this.groupBox2.Controls.Add(this.rb_nrs);
            this.groupBox2.Controls.Add(this.rb_registrados);
            this.groupBox2.Controls.Add(this.txt_pesquisar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Checked = true;
            this.rb_todos.Location = new System.Drawing.Point(145, 58);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 4;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_nrs
            // 
            this.rb_nrs.AutoSize = true;
            this.rb_nrs.Location = new System.Drawing.Point(93, 58);
            this.rb_nrs.Name = "rb_nrs";
            this.rb_nrs.Size = new System.Drawing.Size(46, 17);
            this.rb_nrs.TabIndex = 3;
            this.rb_nrs.Text = "N/R";
            this.rb_nrs.UseVisualStyleBackColor = true;
            this.rb_nrs.CheckedChanged += new System.EventHandler(this.rb_nrs_CheckedChanged);
            // 
            // rb_registrados
            // 
            this.rb_registrados.AutoSize = true;
            this.rb_registrados.Location = new System.Drawing.Point(6, 58);
            this.rb_registrados.Name = "rb_registrados";
            this.rb_registrados.Size = new System.Drawing.Size(81, 17);
            this.rb_registrados.TabIndex = 2;
            this.rb_registrados.Text = "Registrados";
            this.rb_registrados.UseVisualStyleBackColor = true;
            this.rb_registrados.CheckedChanged += new System.EventHandler(this.rb_registrados_CheckedChanged);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(6, 32);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(194, 20);
            this.txt_pesquisar.TabIndex = 1;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_ativo);
            this.groupBox3.Controls.Add(this.chk_registrado);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_nome);
            this.groupBox3.Controls.Add(this.dt_aso);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_rg);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_cpf);
            this.groupBox3.Controls.Add(this.txt_empresa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(224, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 175);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(224, 193);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 26);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(305, 193);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 26);
            this.btn_remover.TabIndex = 15;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(461, 193);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 26);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // chk_registrado
            // 
            this.chk_registrado.AutoSize = true;
            this.chk_registrado.Location = new System.Drawing.Point(159, 112);
            this.chk_registrado.Name = "chk_registrado";
            this.chk_registrado.Size = new System.Drawing.Size(77, 17);
            this.chk_registrado.TabIndex = 13;
            this.chk_registrado.Text = "Registrado";
            this.chk_registrado.UseVisualStyleBackColor = true;
            // 
            // chk_ativo
            // 
            this.chk_ativo.AutoSize = true;
            this.chk_ativo.Location = new System.Drawing.Point(242, 112);
            this.chk_ativo.Name = "chk_ativo";
            this.chk_ativo.Size = new System.Drawing.Size(50, 17);
            this.chk_ativo.TabIndex = 14;
            this.chk_ativo.Text = "Ativo";
            this.chk_ativo.UseVisualStyleBackColor = true;
            // 
            // TodosFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 231);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TodosFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_aso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_nrs;
        private System.Windows.Forms.RadioButton rb_registrados;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox chk_ativo;
        private System.Windows.Forms.CheckBox chk_registrado;
    }
}

