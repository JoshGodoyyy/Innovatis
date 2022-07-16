using System;
using System.Windows.Forms;

namespace Innovatis {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void btn_novaObra_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["NovaObra"];
            if(formOpenned == null) formOpenned = new NovaObra();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void btn_obrasConcluidas_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["ObrasConcluidas"];
            if(formOpenned == null) formOpenned = new ObrasConcluidas();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void btn_obrasEmAndamento_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Acompanhamento"];
            if(formOpenned == null) formOpenned = new Acompanhamento();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Clientes"];
            if(formOpenned == null) formOpenned = new Clientes();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void btn_novoCliente_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["NovoCliente"];
            if(formOpenned == null) formOpenned = new NovoCliente();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }
    }
}
