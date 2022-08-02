using System;
using System.Windows.Forms;
using Innovatis.Clientes;
using Innovatis.Obra;
using Innovatis.Fornecedores;

namespace Innovatis {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            lbl_versao.Text = "V " + Global.Versao;
            timer1.Start();
            Conexao();
        }

        public void Conexao() {
            if(Global.logado == false) {
                Login login = new Login(this);
                login.MdiParent = this;
                login.Show();
                panel1.Enabled = false;
                menuToolStripMenuItem.Enabled = false;
                lbl_usuario.Text = "Desconectado";
                lbl_funcao.Text = "";
            }
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

        private void btn_fornecedores_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["NovoFornecedor"];
            if(formOpenned == null) formOpenned = new NovoFornecedor();
            formOpenned.MdiParent = this;
            formOpenned.Show();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lbl_horario.Text = DateTime.Now.ToString("HH:mm");
            lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            if(Global.logado == false) Close();
            else {
                DialogResult dialog = MessageBox.Show("Deseja mesmo sair?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes) {
                    Global.logado = false;
                    Conexao();
                }
            }
        }
    }
}
