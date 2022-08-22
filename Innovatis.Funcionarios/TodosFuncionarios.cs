using Innovatis.Funcionarios.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatis.Funcionarios {
    public partial class TodosFuncionarios : Form {
        public TodosFuncionarios() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            try {
                List<Funcionario> funcionarios = new List<Funcionario>();
                funcionarios = Banco.Listar();

                lst_funcionario.DataSource = funcionarios;
                lst_funcionario.DisplayMember = "nome";
                lst_funcionario.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filtrar(bool value) {
            try {
                List<Funcionario> funcionarios = new List<Funcionario>();
                funcionarios = Banco.FiltrarRegistro(value);

                lst_funcionario.DataSource = funcionarios;
                lst_funcionario.DisplayMember = "nome";
                lst_funcionario.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e) {
            if(txt_pesquisar.Text == "") {
                Listar();
            } else {
                List<Funcionario> funcionarios = new List<Funcionario>();
                funcionarios = Banco.FiltrarNome("%" + txt_pesquisar.Text + "%");

                lst_funcionario.DataSource = funcionarios;
                lst_funcionario.DisplayMember = "nome";
                lst_funcionario.ValueMember = "id";
            }
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e) {
            Listar();
        }

        private void rb_nrs_CheckedChanged(object sender, EventArgs e) {
            txt_pesquisar.Clear();
            Filtrar(false);
        }

        private void rb_registrados_CheckedChanged(object sender, EventArgs e) {
            txt_pesquisar.Clear();
            Filtrar(true);
        }

        private void btn_editar_Click(object sender, EventArgs e) {
            try {
                Funcionario funcionario = new Funcionario() {
                    Id = int.Parse(lst_funcionario.SelectedValue.ToString()),
                    Nome = txt_nome.Text,
                    RG = txt_rg.Text,
                    CPF = txt_cpf.Text,
                    Empresa = txt_empresa.Text,
                    Data = DateTime.Parse(dt_aso.Text)
                };

                if(chk_registrado.Checked) funcionario.Registrado = true;
                else funcionario.Registrado = false;

                if(chk_ativo.Checked) funcionario.Status = true;
                else funcionario.Status = false;

                Banco.Editar(funcionario);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e) {
            try {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo realizar essa operação?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes) {
                    var selectedValue = lst_funcionario.SelectedValue;
                    if(selectedValue != lst_funcionario.SelectedValue) Banco.Remover(int.Parse(lst_funcionario.SelectedValue.ToString()));
                }
                Listar();
                LimparCampos();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void lst_funcionario_SelectedIndexChanged(object sender, EventArgs e) {
            var SelectedValue = lst_funcionario.SelectedValue;
            if(SelectedValue != lst_funcionario.SelectedValue) {
                List<Funcionario> dados = new List<Funcionario>();
                dados = Banco.ListarId(int.Parse(lst_funcionario.SelectedValue.ToString()));

                foreach(var i in dados) {
                    txt_nome.Text = i.Nome.ToString();
                    txt_rg.Text = i.RG.ToString();
                    txt_cpf.Text = i.CPF.ToString();
                    txt_empresa.Text = i.Empresa.ToString();
                    if(i.Registrado) chk_registrado.Checked = true;
                    else chk_registrado.Checked = false;
                    if(i.Status) chk_ativo.Checked = true;
                    else chk_ativo.Checked = false;

                    dt_aso.Value = DateTime.Parse(i.Data.ToString());
                }
            }
        }

        private void LimparCampos() {
            txt_nome.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
            txt_empresa.Clear();
            dt_aso.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
