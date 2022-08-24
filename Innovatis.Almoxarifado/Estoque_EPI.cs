using Innovatis.Almoxarifado.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatis.Almoxarifado {
    public partial class Estoque_EPI : Form {

        public Estoque_EPI() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            try {
                List<Estoque> estoque = new List<Estoque>();
                estoque = Banco.ListarTodosEPIs();

                lst_itens.DataSource = estoque;
                lst_itens.DisplayMember = "descricao";
                lst_itens.ValueMember = "id";

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_itens_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedValue = lst_itens.SelectedValue;
            if(lst_itens.SelectedValue != selectedValue) {
                try {
                    btn_adicionar.Text = "Editar";

                    List<Estoque> item = new List<Estoque>();
                    int id = int.Parse(lst_itens.SelectedValue.ToString());
                    item = Banco.SelecionarEPI(id);

                    foreach(var i in item) {
                        txt_descricao.Text = i.Descricao.ToString();
                        nmr_quantidade.Value = int.Parse(i.Quantidade.ToString());
                        dt_compra.Value = DateTime.Parse(i.DataCompra.ToString());
                    }
                    
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e) {
            Estoque item = new Estoque() {
                Descricao = txt_descricao.Text,
                Quantidade = int.Parse(nmr_quantidade.Value.ToString()),
                DataCompra = DateTime.Parse(dt_compra.Value.ToString())
            };
            if(btn_adicionar.Text == "Adicionar") {
                try {
                    Banco.InserirEPI(item);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                try {
                    item.Id = int.Parse(lst_itens.SelectedValue.ToString());

                    Banco.EditarEPI(item);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimparCampos();
        }

        private void btn_remover_Click(object sender, EventArgs e) {
            try {
                int id = int.Parse(lst_itens.SelectedValue.ToString());

                Banco.RemoverEPI(id);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
        }

        private void LimparCampos() {
            txt_descricao.Clear();
            nmr_quantidade.Value = 0;
            dt_compra.Value = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
            Listar();
            btn_adicionar.Text = "Adicionar";
        }
    }
}
