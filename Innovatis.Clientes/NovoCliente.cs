using Innovatis.Clientes.Entity;
using System;
using System.Windows.Forms;

namespace Innovatis.Clientes {
    public partial class NovoCliente : Form {
        public NovoCliente() {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente() {
                Nome = txt_clienteNome.Text,
                RG = txt_rg.Text,
                CPF = txt_cpf.Text,
                Contato = txt_contatoCliente.Text,
                Email = txt_email.Text,
                Empresa = txt_nomeEmpresa.Text,
                CNPJ = txt_cnpj.Text,
                ContatoEmpresa = txt_contatoEmpresa.Text,
                Endereco = txt_endereco.Text,
                Numero = int.Parse(txt_numero.Text),
                Bairro = txt_bairro.Text,
                Cidade = txt_cidade.Text,
                CEP = txt_cep.Text,
                UF = txt_uf.Text
            };
            Cadastro.InsertData(cliente);
            LimparCampos();
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            LimparCampos();
        }

        private void LimparCampos() {
            txt_clienteNome.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
            txt_contatoCliente.Clear();
            txt_email.Clear();
            txt_nomeEmpresa.Clear();
            txt_cnpj.Clear();
            txt_contatoEmpresa.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_cep.Clear();
            txt_uf.Clear();
        }
    }
}
