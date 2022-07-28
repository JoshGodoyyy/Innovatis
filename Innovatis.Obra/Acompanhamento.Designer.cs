namespace Innovatis.Obra {
    partial class Acompanhamento {
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_data = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_historico = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_obras = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_remover = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_dataFinal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_totalMO = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_moPaga = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_moContratada = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_saldoMaterial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_valorPagoMateriais = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_valorContratoMaterial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(116, 350);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(108, 23);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txt_local
            // 
            this.txt_local.Location = new System.Drawing.Point(12, 285);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(168, 20);
            this.txt_local.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Local de entrega:";
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(116, 324);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(189, 20);
            this.txt_nota.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nota:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(186, 285);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(119, 20);
            this.txt_valor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor:";
            // 
            // dt_data
            // 
            this.dt_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_data.Location = new System.Drawing.Point(12, 324);
            this.dt_data.Name = "dt_data";
            this.dt_data.Size = new System.Drawing.Size(98, 20);
            this.dt_data.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(12, 246);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(293, 20);
            this.txt_descricao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Descrição:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_historico);
            this.groupBox2.Location = new System.Drawing.Point(288, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 200);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histórico";
            // 
            // list_historico
            // 
            this.list_historico.FormattingEnabled = true;
            this.list_historico.Location = new System.Drawing.Point(6, 18);
            this.list_historico.Name = "list_historico";
            this.list_historico.Size = new System.Drawing.Size(258, 173);
            this.list_historico.TabIndex = 1;
            this.list_historico.SelectedIndexChanged += new System.EventHandler(this.list_historico_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_obras);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 200);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obras";
            // 
            // list_obras
            // 
            this.list_obras.FormattingEnabled = true;
            this.list_obras.Location = new System.Drawing.Point(6, 19);
            this.list_obras.Name = "list_obras";
            this.list_obras.Size = new System.Drawing.Size(258, 173);
            this.list_obras.TabIndex = 0;
            this.list_obras.SelectedIndexChanged += new System.EventHandler(this.list_obras_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarObraToolStripMenuItem});
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.obraToolStripMenuItem.Text = "Obra";
            // 
            // finalizarObraToolStripMenuItem
            // 
            this.finalizarObraToolStripMenuItem.Name = "finalizarObraToolStripMenuItem";
            this.finalizarObraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finalizarObraToolStripMenuItem.Text = "Finalizar obra";
            this.finalizarObraToolStripMenuItem.Click += new System.EventHandler(this.finalizarObraToolStripMenuItem_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(230, 350);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 9;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_dataFinal);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lbl_totalMO);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.lbl_moPaga);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbl_moContratada);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.lbl_saldoMaterial);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.lbl_valorPagoMateriais);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbl_valorContratoMaterial);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(311, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 140);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da Obra";
            // 
            // lbl_dataFinal
            // 
            this.lbl_dataFinal.AutoSize = true;
            this.lbl_dataFinal.Location = new System.Drawing.Point(88, 16);
            this.lbl_dataFinal.Name = "lbl_dataFinal";
            this.lbl_dataFinal.Size = new System.Drawing.Size(0, 13);
            this.lbl_dataFinal.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Prazo da obra:";
            // 
            // lbl_totalMO
            // 
            this.lbl_totalMO.AutoSize = true;
            this.lbl_totalMO.Location = new System.Drawing.Point(92, 69);
            this.lbl_totalMO.Name = "lbl_totalMO";
            this.lbl_totalMO.Size = new System.Drawing.Size(0, 13);
            this.lbl_totalMO.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Saldo M.O.: R$";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(6, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 1);
            this.panel3.TabIndex = 42;
            // 
            // lbl_moPaga
            // 
            this.lbl_moPaga.AutoSize = true;
            this.lbl_moPaga.Location = new System.Drawing.Point(90, 49);
            this.lbl_moPaga.Name = "lbl_moPaga";
            this.lbl_moPaga.Size = new System.Drawing.Size(0, 13);
            this.lbl_moPaga.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "M.O. Paga: R$";
            // 
            // lbl_moContratada
            // 
            this.lbl_moContratada.AutoSize = true;
            this.lbl_moContratada.Location = new System.Drawing.Point(117, 36);
            this.lbl_moContratada.Name = "lbl_moContratada";
            this.lbl_moContratada.Size = new System.Drawing.Size(0, 13);
            this.lbl_moContratada.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "M.O. Contratada: R$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 1);
            this.panel2.TabIndex = 36;
            // 
            // lbl_saldoMaterial
            // 
            this.lbl_saldoMaterial.AutoSize = true;
            this.lbl_saldoMaterial.Location = new System.Drawing.Point(106, 122);
            this.lbl_saldoMaterial.Name = "lbl_saldoMaterial";
            this.lbl_saldoMaterial.Size = new System.Drawing.Size(0, 13);
            this.lbl_saldoMaterial.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Saldo Material: R$";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1);
            this.panel1.TabIndex = 35;
            // 
            // lbl_valorPagoMateriais
            // 
            this.lbl_valorPagoMateriais.AutoSize = true;
            this.lbl_valorPagoMateriais.Location = new System.Drawing.Point(104, 102);
            this.lbl_valorPagoMateriais.Name = "lbl_valorPagoMateriais";
            this.lbl_valorPagoMateriais.Size = new System.Drawing.Size(0, 13);
            this.lbl_valorPagoMateriais.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Material Pago: R$";
            // 
            // lbl_valorContratoMaterial
            // 
            this.lbl_valorContratoMaterial.AutoSize = true;
            this.lbl_valorContratoMaterial.Location = new System.Drawing.Point(131, 89);
            this.lbl_valorContratoMaterial.Name = "lbl_valorContratoMaterial";
            this.lbl_valorContratoMaterial.Size = new System.Drawing.Size(0, 13);
            this.lbl_valorContratoMaterial.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Material Contratado: R$";
            // 
            // Acompanhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_local);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acompanhamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obras em Andamento";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_historico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_obras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarObraToolStripMenuItem;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_valorPagoMateriais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_valorContratoMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_saldoMaterial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_dataFinal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_totalMO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_moPaga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_moContratada;
        private System.Windows.Forms.Label label14;
    }
}