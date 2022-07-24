using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatis.Obra {
    public partial class Acompanhamento : Form {
        public Acompanhamento() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            List<Entity.Obra> obras = new List<Entity.Obra>();
            obras = Cadastro.LoadData();

            list_obras.DataSource = obras;
            list_obras.DisplayMember = "logradouro";
            list_obras.ValueMember = "id";
        }
    }
}
