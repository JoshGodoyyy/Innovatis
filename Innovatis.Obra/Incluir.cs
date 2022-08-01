using Innovatis.Obra.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Innovatis.Fornecedores.Entity;

namespace Innovatis.Obra {
    public partial class Incluir : Form {
        public Incluir() {
            InitializeComponent();
            Listar();
            ListarFornecedores();
        }

        private void btn_incluir_Click(object sender, EventArgs e) {
            try {
                Material material = new Material() {
                    IdObra = int.Parse(cb_obras.SelectedValue.ToString()),
                    Descricao = txt_descricao.Text,
                    Data = DateTime.Parse(dt_data.Text),
                    Valor = double.Parse(txt_valor.Text),
                    LocalEntrega = txt_localEntrega.Text,
                    Fornecedor = cb_fornecedores.Text
                };
                if(txt_nota.Text == null) material.Nota = "S/N";
                else material.Nota = txt_nota.Text;

                Historicos.InserirMaterial(material);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
        }

        private void Listar() {
            try {
                List<Entity.Obra> obras = new List<Entity.Obra>();
                obras = Obras.ListarObras(0);

                cb_obras.DataSource = obras;
                cb_obras.ValueMember = "id";
                cb_obras.DisplayMember = "logradouro";

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarFornecedores() {
            try {
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                fornecedores = Fornecedores.Cadastro.Listar();

                cb_fornecedores.DataSource = fornecedores;
                cb_fornecedores.DisplayMember = "nome";
                cb_fornecedores.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos() {
            txt_descricao.Clear();
            dt_data.Value = DateTime.Now;
            txt_valor.Clear();
            txt_nota.Clear();
            txt_localEntrega.Clear();
        }

        private void chk_medicao_CheckedChanged(object sender, EventArgs e) {
            if(chk_medicao.Checked) {
                txt_descricao.Text = "Medição";
                txt_descricao.Enabled = false;
                txt_localEntrega.Clear();
                txt_localEntrega.Enabled = false;
            } else {
                txt_descricao.Clear();
                txt_descricao.Enabled = true;
                txt_localEntrega.Enabled = true;
            }
        }
    }
}
