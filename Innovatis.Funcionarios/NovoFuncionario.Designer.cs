﻿namespace Innovatis.Funcionarios {
    partial class NovoFuncionario {
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.dt_aso = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.chk_registrado = new System.Windows.Forms.CheckBox();
            this.chk_ativo = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 175);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
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
            this.txt_nome.TabIndex = 0;
            // 
            // dt_aso
            // 
            this.dt_aso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_aso.Location = new System.Drawing.Point(6, 149);
            this.dt_aso.Name = "dt_aso";
            this.dt_aso.Size = new System.Drawing.Size(147, 20);
            this.dt_aso.TabIndex = 6;
            this.dt_aso.Value = new System.DateTime(2022, 8, 12, 0, 0, 0, 0);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ASO:";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(6, 71);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(147, 20);
            this.txt_rg.TabIndex = 1;
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
            this.txt_cpf.TabIndex = 2;
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(6, 110);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(147, 20);
            this.txt_empresa.TabIndex = 3;
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
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(249, 193);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // chk_registrado
            // 
            this.chk_registrado.AutoSize = true;
            this.chk_registrado.Location = new System.Drawing.Point(159, 112);
            this.chk_registrado.Name = "chk_registrado";
            this.chk_registrado.Size = new System.Drawing.Size(77, 17);
            this.chk_registrado.TabIndex = 12;
            this.chk_registrado.Text = "Registrado";
            this.chk_registrado.UseVisualStyleBackColor = true;
            // 
            // chk_ativo
            // 
            this.chk_ativo.AutoSize = true;
            this.chk_ativo.Location = new System.Drawing.Point(242, 112);
            this.chk_ativo.Name = "chk_ativo";
            this.chk_ativo.Size = new System.Drawing.Size(50, 17);
            this.chk_ativo.TabIndex = 13;
            this.chk_ativo.Text = "Ativo";
            this.chk_ativo.UseVisualStyleBackColor = true;
            // 
            // NovoFuncionario
            // 
            this.AcceptButton = this.btn_salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 228);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Funcionário";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DateTimePicker dt_aso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.CheckBox chk_ativo;
        private System.Windows.Forms.CheckBox chk_registrado;
    }
}