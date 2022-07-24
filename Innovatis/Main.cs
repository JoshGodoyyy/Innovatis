using System;
using System.Windows.Forms;
using Innovatis.Clientes;
using Innovatis.Obra;

namespace Innovatis {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            Text = Application.ProductName + " - V" + Global.Versao;
        }

        private void btn_novaObra_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Nova"];
            if(formOpenned == null) formOpenned = new Nova();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void btn_obrasConcluidas_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Finalizadas"];
            if(formOpenned == null) formOpenned = new Finalizadas();
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
            if(formOpenned == null) formOpenned = new Clientes.Clientes();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void btn_novoCliente_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Novo"];
            if(formOpenned == null) formOpenned = new Novo();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void btn_materiais_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Incluir"];
            if(formOpenned == null) formOpenned = new Incluir();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }
    }
}
