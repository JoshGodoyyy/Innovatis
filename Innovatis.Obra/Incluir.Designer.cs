﻿namespace Innovatis.Obra {
    partial class Incluir {
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
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_localEntrega = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_obras = new System.Windows.Forms.ComboBox();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.chk_medicao = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_fornecedores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(12, 65);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(177, 20);
            this.txt_descricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(12, 104);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local de entrega:";
            // 
            // txt_localEntrega
            // 
            this.txt_localEntrega.Location = new System.Drawing.Point(118, 104);
            this.txt_localEntrega.Name = "txt_localEntrega";
            this.txt_localEntrega.Size = new System.Drawing.Size(144, 20);
            this.txt_localEntrega.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data:";
            // 
            // dt_data
            // 
            this.dt_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_data.Location = new System.Drawing.Point(12, 143);
            this.dt_data.Name = "dt_data";
            this.dt_data.Size = new System.Drawing.Size(100, 20);
            this.dt_data.TabIndex = 5;
            this.dt_data.Value = new System.DateTime(2022, 7, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota:";
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(121, 143);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(141, 20);
            this.txt_nota.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Obra:";
            // 
            // cb_obras
            // 
            this.cb_obras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_obras.FormattingEnabled = true;
            this.cb_obras.Location = new System.Drawing.Point(13, 25);
            this.cb_obras.Name = "cb_obras";
            this.cb_obras.Size = new System.Drawing.Size(249, 21);
            this.cb_obras.TabIndex = 0;
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(187, 180);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_incluir.TabIndex = 8;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // chk_medicao
            // 
            this.chk_medicao.AutoSize = true;
            this.chk_medicao.Location = new System.Drawing.Point(195, 67);
            this.chk_medicao.Name = "chk_medicao";
            this.chk_medicao.Size = new System.Drawing.Size(67, 17);
            this.chk_medicao.TabIndex = 2;
            this.chk_medicao.Text = "Medição";
            this.chk_medicao.UseVisualStyleBackColor = true;
            this.chk_medicao.CheckedChanged += new System.EventHandler(this.chk_medicao_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fornecedor:";
            // 
            // cb_fornecedores
            // 
            this.cb_fornecedores.FormattingEnabled = true;
            this.cb_fornecedores.Location = new System.Drawing.Point(12, 182);
            this.cb_fornecedores.Name = "cb_fornecedores";
            this.cb_fornecedores.Size = new System.Drawing.Size(169, 21);
            this.cb_fornecedores.TabIndex = 7;
            // 
            // Incluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 215);
            this.Controls.Add(this.cb_fornecedores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chk_medicao);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.cb_obras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_localEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Incluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_localEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_obras;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.CheckBox chk_medicao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_fornecedores;
    }
}