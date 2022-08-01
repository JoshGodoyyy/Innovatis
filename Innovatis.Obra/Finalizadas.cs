using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatis.Obra {
    public partial class Finalizadas : Form {
        public Finalizadas() {
            InitializeComponent();
            ListarObras();
        }

        private void ListarObras() {
            try {
                List<Entity.Obra> obras = new List<Entity.Obra>();
                obras = Obras.ListarObras(1);

                list_obras.DataSource = obras;
                list_obras.DisplayMember = "logradouro";
                list_obras.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_relatorio_Click(object sender, EventArgs e) {
            try {
                if (list_obras.Items.Count == 0) {
                    MessageBox.Show("Nenhuma obra selecionada", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = int.Parse(list_obras.SelectedValue.ToString());
                Relatorio relatorio = new Relatorio(id);
                relatorio.ShowDialog();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
