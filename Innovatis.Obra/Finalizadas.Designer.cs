namespace Innovatis.Obra {
    partial class Finalizadas {
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
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.list_obras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.Location = new System.Drawing.Point(12, 178);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(300, 23);
            this.btn_relatorio.TabIndex = 3;
            this.btn_relatorio.Text = "Relatório";
            this.btn_relatorio.UseVisualStyleBackColor = true;
            // 
            // list_obras
            // 
            this.list_obras.FormattingEnabled = true;
            this.list_obras.Location = new System.Drawing.Point(12, 12);
            this.list_obras.Name = "list_obras";
            this.list_obras.Size = new System.Drawing.Size(300, 160);
            this.list_obras.TabIndex = 2;
            this.list_obras.SelectedIndexChanged += new System.EventHandler(this.list_obras_SelectedIndexChanged);
            // 
            // Finalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 213);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.list_obras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Finalizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizadas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.ListBox list_obras;
    }
}