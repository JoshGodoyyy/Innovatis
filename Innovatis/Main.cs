using System;
using System.Windows.Forms;
using Innovatis.Clientes;
using Innovatis.Obra;
using Innovatis.Fornecedores;
using Innovatis.Almoxarifado;
using Innovatis.Funcionarios;
using System.Net;

namespace Innovatis {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            lbl_versao.Text = "V " + Global.Versao;
            timer1.Start();
            Conexao();
            CriarNos();
            lbl_computador.Text = Dns.GetHostName();
        }

        public void Conexao() {
            if(Global.logado == false) {
                Login login = new Login(this);
                login.MdiParent = this;
                login.Show();
                ribbon.Enabled = false;
                Global.Acesso = "Desconectado";
                lbl_usuario.Text = "Desconectado";
                lbl_funcao.Text = "";
            }
        }

        public void CriarNos() {
            if(Global.logado) {
                TreeNode raizObra, novaObra, obrasConcluidas,
                         pedido, raizClientes, andamento,
                         novoCliente, clientes, raizFornecedores, 
                         raizAlmoxarifado, raizFuncionarios, presenca, 
                         novoFuncionario, dadosFuncionarios, manutencao, cestas, configuracoes, epi;
                switch(Global.Acesso) {
                    case "Obras":
                        raizObra = tr_caminhos.Nodes.Add("Obra");

                        novaObra = raizObra.Nodes.Add("Nova Obra");
                        novaObra.Name = "novaObra";
                        novaObra.Tag = "novaObra";

                        obrasConcluidas = raizObra.Nodes.Add("Obras Concluidas");
                        obrasConcluidas.Name = "obrasConcluidas";
                        obrasConcluidas.Tag = "obrasConcluidas";

                        pedido = raizObra.Nodes.Add("Pedido de Material");
                        pedido.Name = "pedido";
                        pedido.Tag = "pedido";

                        andamento = raizObra.Nodes.Add("Obras em Andamento");
                        andamento.Name = "andamento";
                        andamento.Tag = "andamento";

                        raizClientes = tr_caminhos.Nodes.Add("Cliente");

                        clientes = raizClientes.Nodes.Add("Clientes");
                        clientes.Name = "clientes";
                        clientes.Tag = "clientes";

                        novoCliente = raizClientes.Nodes.Add("Novo Cliente");
                        novoCliente.Name = "novoCliente";
                        novoCliente.Tag = "novoCliente";

                        raizFornecedores = tr_caminhos.Nodes.Add("Fornecedores");
                        raizFornecedores.Name = "raizFornecedores";
                        raizFornecedores.Tag = "raizFornecedores";
                        break;
                    case "Almoxarifado":
                        break;
                    case "Administrador":
                        raizAlmoxarifado = tr_caminhos.Nodes.Add("Almoxarifado");
                        raizAlmoxarifado.Name = "almoxarifado";

                        manutencao = raizAlmoxarifado.Nodes.Add("Manutenção");
                        manutencao.Name = "manutencao";
                        manutencao.Tag = "manutencao";

                        cestas = raizAlmoxarifado.Nodes.Add("Cestas");
                        cestas.Name = "cestas";
                        cestas.Tag = "cestas";

                        epi = raizAlmoxarifado.Nodes.Add("EPIs");
                        epi.Name = "epis";
                        epi.Tag = "epis";

                        raizObra = tr_caminhos.Nodes.Add("Obra");
                        novaObra = raizObra.Nodes.Add("Nova Obra");
                        novaObra.Name = "novaObra";
                        novaObra.Tag = "novaObra";

                        obrasConcluidas = raizObra.Nodes.Add("Obras Concluidas");
                        obrasConcluidas.Name = "obrasConcluidas";
                        obrasConcluidas.Tag = "obrasConcluidas";

                        pedido = raizObra.Nodes.Add("Pedido de Material");
                        pedido.Name = "pedido";
                        pedido.Tag = "pedido";

                        andamento = raizObra.Nodes.Add("Obras em Andamento");
                        andamento.Name = "andamento";
                        andamento.Tag = "andamento";

                        raizClientes = tr_caminhos.Nodes.Add("Cliente");
                        clientes = raizClientes.Nodes.Add("Clientes");
                        clientes.Name = "clientes";
                        clientes.Tag = "clientes";

                        novoCliente = raizClientes.Nodes.Add("Novo Cliente");
                        novoCliente.Name = "novoCliente";
                        novoCliente.Tag = "novoCliente";

                        raizFornecedores = tr_caminhos.Nodes.Add("Fornecedores");
                        raizFornecedores.Tag = "raizFornecedores";
                        raizFornecedores.Name = "raizFornecedores";

                        raizFuncionarios = tr_caminhos.Nodes.Add("Funcionários");

                        dadosFuncionarios = raizFuncionarios.Nodes.Add("Todos os Funcionários");
                        dadosFuncionarios.Name = "informacoesFuncionario";
                        dadosFuncionarios.Tag = "informacoesFuncionario";

                        novoFuncionario = raizFuncionarios.Nodes.Add("Incluir Funcionário");
                        novoFuncionario.Name = "novoFuncionario";
                        novoFuncionario.Tag = "novoFuncionario";

                        presenca = raizFuncionarios.Nodes.Add("Folha de Presença");
                        presenca.Name = "presenca";
                        presenca.Tag = "presenca";

                        configuracoes = tr_caminhos.Nodes.Add("Configurações");
                        configuracoes.Name = "configuracoes";
                        configuracoes.Tag = "configuracoes";
                        break;
                }
            }
        }

        private void tr_caminhos_AfterSelect(object sender, TreeViewEventArgs e) {
            if(tr_caminhos.SelectedNode.Tag != null) {
                Form formOpenned;
                switch(tr_caminhos.SelectedNode.Tag) {
                    case "novaObra":
                        formOpenned = Application.OpenForms["Nova"];
                        if(formOpenned == null) formOpenned = new Nova();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "obrasConcluidas":
                        formOpenned = Application.OpenForms["Finalizadas"];
                        if(formOpenned == null) formOpenned = new Finalizadas();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "pedido":
                        formOpenned = Application.OpenForms["Incluir"];
                        if(formOpenned == null) formOpenned = new Incluir();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "andamento":
                        formOpenned = Application.OpenForms["Acompanhamento"];
                        if(formOpenned == null) formOpenned = new Acompanhamento();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "clientes":
                        formOpenned = Application.OpenForms["Clientes"];
                        if(formOpenned == null) formOpenned = new Clientes.Clientes();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "novoCliente":
                        formOpenned = Application.OpenForms["NovoCliente"];
                        if(formOpenned == null) formOpenned = new NovoCliente();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "raizFornecedores":
                        formOpenned = Application.OpenForms["NovoFornecedor"];
                        if(formOpenned == null) formOpenned = new NovoFornecedor();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "configuracoes":
                        formOpenned = Application.OpenForms["Configuracoes"];
                        if(formOpenned == null) formOpenned = new Configuracoes();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "cestas":
                        formOpenned = Application.OpenForms["Cestas"];
                        if(formOpenned == null) formOpenned = new Cestas();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "informacoesFuncionario":
                        formOpenned = Application.OpenForms["TodosFuncionarios"];
                        if(formOpenned == null) formOpenned = new TodosFuncionarios();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "novoFuncionario":
                        formOpenned = Application.OpenForms["NovoFuncionario"];
                        if(formOpenned == null) formOpenned = new NovoFuncionario();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                    case "epis":
                        formOpenned = Application.OpenForms["EPI"];
                        if(formOpenned == null) formOpenned = new EPI();
                        formOpenned.MdiParent = this;
                        formOpenned.Show();
                        break;
                }
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
            Form formOpenned = Application.OpenForms["NovoCliente"];
            if(formOpenned == null) formOpenned = new NovoCliente();
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

        private void btn_sair_Click(object sender, EventArgs e) {
            if(Global.logado == false) Close();
            else {
                DialogResult dialog = MessageBox.Show("Deseja mesmo sair?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes) {
                    foreach(Form i in MdiChildren) i.Close(); 
                    Global.logado = false;
                    Global.Acesso = "Desconectado";
                    lbl_usuario.Text = "Desconectado";
                    Conexao();
                    tr_caminhos.Nodes.Clear();
                }
            }
        }
    }
}
