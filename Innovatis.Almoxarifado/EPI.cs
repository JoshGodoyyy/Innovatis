using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Innovatis.Almoxarifado.Entity;
using Innovatis.Funcionarios.Entity;

namespace Innovatis.Almoxarifado {
    public partial class EPI : Form {
        public EPI() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            try {
                List<Estoque> itens = new List<Estoque>();
                itens = Banco.ListarTodosEPIs();

                lst_itens.DataSource = itens;
                lst_itens.DisplayMember = "descricao";
                lst_itens.ValueMember = "id";

                List<Funcionario> funcionarios = new List<Funcionario>();
                funcionarios = Funcionarios.Banco.Listar();
                cb_funcionarios.DataSource = funcionarios;
                cb_funcionarios.DisplayMember = "nome";
                cb_funcionarios.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e) {
            Estoque_EPI estoque_EPI = new Estoque_EPI();
            estoque_EPI.ShowDialog();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void porFuncionárioToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btn_entregar_Click(object sender, EventArgs e) {
            try {

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_itens_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedValue = lst_itens.SelectedValue;
            if(lst_itens.SelectedValue != selectedValue) {
                try {
                    List<Estoque> item = new List<Estoque>();
                    int id = int.Parse(lst_itens.SelectedValue.ToString());
                    item = Banco.SelecionarEPI(id);

                    foreach(var i in item) {
                        txt_descricao.Text = i.Descricao.ToString();
                        lbl_quantidade.Text = i.Quantidade.ToString();
                    }
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
