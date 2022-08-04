using Innovatis.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatis {
    public partial class Configuracoes : Form {
        public Configuracoes() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            cb_acesso.DataSource = Enum.GetValues(typeof(Funcao));
            try {
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = Banco.Usuarios();

                cb_usuarios.DataSource = usuarios;
                cb_usuarios.DisplayMember = "nome";
                cb_usuarios.ValueMember = "id";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            Usuario usuario = new Usuario() {
                Nome = txt_usuario.Text,
                Senha = txt_senha.Text,
                Funcao = cb_acesso.SelectedItem.ToString()
            };
            if(btn_salvar.Text == "Editar") {
                try {
                    usuario.Id = int.Parse(cb_usuarios.SelectedValue.ToString());
                    Banco.EditarUsuario(usuario);
                    LimparCampos();
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                try {
                    Banco.NovoUsuario(usuario);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Listar();
        }

        private void cb_usuarios_SelectedIndexChanged(object sender, EventArgs e) {
            object selected = cb_usuarios.SelectedValue;
            if(cb_usuarios.SelectedValue != selected) {
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = Banco.SelecionarUsuario(int.Parse(cb_usuarios.SelectedValue.ToString()));
                foreach(var i in usuarios) {
                    txt_usuario.Text = i.Nome;
                    txt_senha.Text = i.Senha;
                    cb_acesso.Text = i.Funcao;
                }
                btn_salvar.Text = "Editar";
            }
        }

        private void btn_remover_Click(object sender, EventArgs e) {
            try {
                DialogResult dialog = MessageBox.Show("Tem certeza que deseja apagar esse usuário?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(dialog == DialogResult.Yes) Banco.RemoverUsuario(int.Parse(cb_usuarios.SelectedValue.ToString()));
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listar();
        }

        private void LimparCampos() {
            txt_usuario.Clear();
            txt_senha.Clear();
            btn_salvar.Text = "Salvar";
        }

        private void chk_senha_CheckedChanged(object sender, EventArgs e) {
            if(chk_senha.Checked) txt_senha.UseSystemPasswordChar = false;
            else txt_senha.UseSystemPasswordChar = true;
        }
    }
}
