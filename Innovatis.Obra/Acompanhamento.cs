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

            foreach(var i in obras) {
                string num;
                if(i.Numero == 0) num = "S/N";
                else num = i.Numero.ToString();
                list_obras.Items.Add(i.Logradouro + ", " + num);
            }
        }

        private void list_obras_SelectedIndexChanged(object sender, System.EventArgs e) {
            string m = list_historico.SelectedItems.ToString();
            MessageBox.Show(m);
        }
    }
}
