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
                obras = Cadastro.ListarFinalizadas();

                list_obras.DataSource = obras;
                list_obras.DisplayMember = "logradouro";
                list_obras.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list_obras_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
