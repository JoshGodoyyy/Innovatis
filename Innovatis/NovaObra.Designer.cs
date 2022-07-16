namespace Innovatis {
    partial class NovaObra {
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
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.chk_numero = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.btn_clienteNaoCadastrado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_contrato = new System.Windows.Forms.TextBox();
            this.btn_procurarContrato = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_valorContrato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_valorMaoDeObra = new System.Windows.Forms.TextBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dt_final = new System.Windows.Forms.DateTimePicker();
            this.chk_naoIncluso = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logradouro:";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(12, 25);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(300, 20);
            this.txt_logradouro.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(318, 25);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 1;
            // 
            // chk_numero
            // 
            this.chk_numero.AutoSize = true;
            this.chk_numero.Location = new System.Drawing.Point(424, 28);
            this.chk_numero.Name = "chk_numero";
            this.chk_numero.Size = new System.Drawing.Size(46, 17);
            this.chk_numero.TabIndex = 2;
            this.chk_numero.Text = "S/N";
            this.chk_numero.UseVisualStyleBackColor = true;
            this.chk_numero.CheckedChanged += new System.EventHandler(this.chk_numero_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(12, 64);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(200, 20);
            this.txt_bairro.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(218, 64);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(146, 20);
            this.txt_cidade.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CEP:";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(370, 64);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cliente:";
            // 
            // cb_cliente
            // 
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(12, 103);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(300, 21);
            this.cb_cliente.TabIndex = 6;
            // 
            // btn_clienteNaoCadastrado
            // 
            this.btn_clienteNaoCadastrado.Location = new System.Drawing.Point(318, 101);
            this.btn_clienteNaoCadastrado.Name = "btn_clienteNaoCadastrado";
            this.btn_clienteNaoCadastrado.Size = new System.Drawing.Size(152, 23);
            this.btn_clienteNaoCadastrado.TabIndex = 7;
            this.btn_clienteNaoCadastrado.Text = "Não Cadastrado";
            this.btn_clienteNaoCadastrado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contrato:";
            // 
            // txt_contrato
            // 
            this.txt_contrato.Location = new System.Drawing.Point(12, 143);
            this.txt_contrato.Name = "txt_contrato";
            this.txt_contrato.Size = new System.Drawing.Size(352, 20);
            this.txt_contrato.TabIndex = 8;
            // 
            // btn_procurarContrato
            // 
            this.btn_procurarContrato.Location = new System.Drawing.Point(370, 141);
            this.btn_procurarContrato.Name = "btn_procurarContrato";
            this.btn_procurarContrato.Size = new System.Drawing.Size(100, 23);
            this.btn_procurarContrato.TabIndex = 9;
            this.btn_procurarContrato.Text = "Selecionar";
            this.btn_procurarContrato.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Valor de Contrato:";
            // 
            // txt_valorContrato
            // 
            this.txt_valorContrato.Location = new System.Drawing.Point(12, 182);
            this.txt_valorContrato.Name = "txt_valorContrato";
            this.txt_valorContrato.Size = new System.Drawing.Size(150, 20);
            this.txt_valorContrato.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor de Material:";
            // 
            // txt_valorMaoDeObra
            // 
            this.txt_valorMaoDeObra.Location = new System.Drawing.Point(168, 182);
            this.txt_valorMaoDeObra.Name = "txt_valorMaoDeObra";
            this.txt_valorMaoDeObra.Size = new System.Drawing.Size(150, 20);
            this.txt_valorMaoDeObra.TabIndex = 11;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(324, 218);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(146, 23);
            this.btn_finalizar.TabIndex = 15;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Início da obra:";
            // 
            // dt_Inicio
            // 
            this.dt_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicio.Location = new System.Drawing.Point(12, 221);
            this.dt_Inicio.Name = "dt_Inicio";
            this.dt_Inicio.Size = new System.Drawing.Size(150, 20);
            this.dt_Inicio.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Finalização da obra:";
            // 
            // dt_final
            // 
            this.dt_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_final.Location = new System.Drawing.Point(168, 221);
            this.dt_final.Name = "dt_final";
            this.dt_final.Size = new System.Drawing.Size(150, 20);
            this.dt_final.TabIndex = 14;
            // 
            // chk_naoIncluso
            // 
            this.chk_naoIncluso.AutoSize = true;
            this.chk_naoIncluso.Location = new System.Drawing.Point(324, 184);
            this.chk_naoIncluso.Name = "chk_naoIncluso";
            this.chk_naoIncluso.Size = new System.Drawing.Size(82, 17);
            this.chk_naoIncluso.TabIndex = 12;
            this.chk_naoIncluso.Text = "Não incluso";
            this.chk_naoIncluso.UseVisualStyleBackColor = true;
            this.chk_naoIncluso.CheckedChanged += new System.EventHandler(this.chk_naoIncluso_CheckedChanged);
            // 
            // NovaObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.chk_naoIncluso);
            this.Controls.Add(this.dt_final);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dt_Inicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.txt_valorMaoDeObra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_valorContrato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_procurarContrato);
            this.Controls.Add(this.txt_contrato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clienteNaoCadastrado);
            this.Controls.Add(this.cb_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_numero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaObra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova obra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.CheckBox chk_numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clienteNaoCadastrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_contrato;
        private System.Windows.Forms.Button btn_procurarContrato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_valorContrato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_valorMaoDeObra;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_Inicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_final;
        private System.Windows.Forms.CheckBox chk_naoIncluso;
        private System.Windows.Forms.ComboBox cb_cliente;
    }
}