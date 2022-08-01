using Innovatis.Fornecedores.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Innovatis.Fornecedores {
    public partial class Novo : Form {
        public Novo() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            try {
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                fornecedores = Cadastro.Listar();

                cb_fornecedores.DataSource = fornecedores;
                cb_fornecedores.DisplayMember = "nome";
                cb_fornecedores.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
        }

        private void cb_fornecedores_SelectedIndexChanged(object sender, EventArgs e) {
           object var = cb_fornecedores.SelectedValue;
            if(cb_fornecedores.SelectedValue != var) {
                try {
                    DataTable data = new DataTable();
                    data = Cadastro.SelecionarFornecedor(int.Parse(cb_fornecedores.SelectedValue.ToString()));

                    foreach(DataRow i in data.Rows) {
                        txt_empresa.Text = i["empresa"].ToString();
                        txt_contato.Text = i["contato"].ToString();
                        txt_email.Text = i["email"].ToString();
                        txt_responsavel.Text = i["responsavel"].ToString();
                    }
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_salvar.Text = "Editar";
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            Fornecedor fornecedor = new Fornecedor() {
                Nome = txt_empresa.Text,
                Contato = txt_contato.Text,
                Email = txt_email.Text,
                Responsavel = txt_responsavel.Text
            };

            if(btn_salvar.Text == "Editar") {
                try {
                    fornecedor.Id = int.Parse(cb_fornecedores.SelectedValue.ToString());
                    Cadastro.Editar(fornecedor);
                    btn_salvar.Text = "Salvar";
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                try {
                    Cadastro.Inserir(fornecedor);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Listar();
            LimparCampos();
        }

        private void btn_remover_Click(object sender, EventArgs e) {
            try {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo remover este item?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) Cadastro.Remover(int.Parse(cb_fornecedores.SelectedValue.ToString()));
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listar();
            LimparCampos();
        }

        private void LimparCampos() {
            btn_salvar.Text = "Salvar";
            txt_empresa.Clear();
            txt_contato.Clear();
            txt_email.Clear();
            txt_responsavel.Clear();
        }
    }
}
