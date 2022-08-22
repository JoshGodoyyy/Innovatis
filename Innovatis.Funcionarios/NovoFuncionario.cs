using Innovatis.Funcionarios.Entity;
using System;
using System.Windows.Forms;

namespace Innovatis.Funcionarios {
    public partial class NovoFuncionario : Form {
        public NovoFuncionario() {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            try {
                Funcionario funcionario = new Funcionario() {
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

                Banco.Inserir(funcionario);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
        }

        private void LimparCampos() {
            txt_nome.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
            txt_empresa.Clear();
            chk_registrado.Checked = false;
            chk_ativo.Checked = false;
            dt_aso.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
