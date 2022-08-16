using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Innovatis.Funcionarios.Entity;

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

                if(rb_registrado.Checked) funcionario.Registrado = true;
                else funcionario.Registrado = false;

                if(rb_ativo.Checked) funcionario.Status = true;
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
            dt_aso.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
