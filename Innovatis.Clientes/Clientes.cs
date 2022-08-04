using Innovatis.Clientes.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatis.Clientes {
    public partial class Clientes : Form {
        private int? id;
        public Clientes() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            try {
                List<Cliente> clientes = new List<Cliente>();
                clientes = Cadastro.LoadData();
                dt_clientes.DataSource = clientes;

                dt_clientes.Columns[0].Visible = false;
                dt_clientes.Columns[1].Visible = true;
                dt_clientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dt_clientes.Columns[2].Visible = false;
                dt_clientes.Columns[3].Visible = false;
                dt_clientes.Columns[4].Visible = true;
                dt_clientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dt_clientes.Columns[5].Visible = false;
                dt_clientes.Columns[6].Visible = true;
                dt_clientes.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dt_clientes.Columns[7].Visible = false;
                dt_clientes.Columns[8].Visible = false;
                dt_clientes.Columns[9].Visible = false;
                dt_clientes.Columns[10].Visible = false;
                dt_clientes.Columns[11].Visible = false;
                dt_clientes.Columns[12].Visible = true;
                dt_clientes.Columns[13].Visible = false;
                dt_clientes.Columns[14].Visible = false;
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dt_clientes_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(dt_clientes.Rows.Count == 0) {
                MessageBox.Show("Nenhum item selecionado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                try {
                    id = int.Parse(dt_clientes.CurrentRow.Cells[0].Value.ToString());
                    txt_nome.Text = dt_clientes.CurrentRow.Cells[1].Value.ToString();
                    txt_rg.Text = dt_clientes.CurrentRow.Cells[2].Value.ToString();
                    txt_cpf.Text = dt_clientes.CurrentRow.Cells[3].Value.ToString();
                    txt_contato.Text = dt_clientes.CurrentRow.Cells[4].Value.ToString();
                    txt_email.Text = dt_clientes.CurrentRow.Cells[5].Value.ToString();
                    txt_nomeEmpresa.Text = dt_clientes.CurrentRow.Cells[6].Value.ToString();
                    txt_cnpj.Text = dt_clientes.CurrentRow.Cells[7].Value.ToString();
                    txt_contatoEmpresa.Text = dt_clientes.CurrentRow.Cells[8].Value.ToString();
                    txt_endereco.Text = dt_clientes.CurrentRow.Cells[9].Value.ToString();
                    txt_numero.Text = dt_clientes.CurrentRow.Cells[10].Value.ToString();
                    txt_bairro.Text = dt_clientes.CurrentRow.Cells[11].Value.ToString();
                    txt_cidade.Text = dt_clientes.CurrentRow.Cells[12].Value.ToString();
                    txt_cep.Text = dt_clientes.CurrentRow.Cells[13].Value.ToString();
                    txt_uf.Text = dt_clientes.CurrentRow.Cells[14].Value.ToString();
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            if(id != null) {
                int id = (int)this.id;
                try {
                    Cliente cliente = new Cliente() {
                        Id = id,
                        Nome = txt_nome.Text,
                        RG = txt_rg.Text,
                        CPF = txt_cpf.Text,
                        Contato = txt_contato.Text,
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
                    Cadastro.EditItem(cliente);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                LimparCampos();
                Listar();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e) {
            if(id != null) {
                int id = (int)this.id;
                try {
                    Cadastro.RemoveData(id);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                LimparCampos();
                Listar();
            }
        }

        private void LimparCampos() {
            id = null;
            txt_nome.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
            txt_contato.Clear();
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

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e) {
            Listar();
        }

        private void salvarComoPDFToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
