using Innovatis.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatis {
    public partial class Login : Form {
        Main main;
        public Login(Main main) {
            InitializeComponent();
            this.main = main;
        }

        private void btn_entrar_Click(object sender, EventArgs e) {
            Usuario usuario = new Usuario() {
                Nome = txt_usuario.Text,
                Senha = txt_senha.Text
            };

            List<Usuario> usuarios = new List<Usuario>();
            usuarios = Banco.Login(usuario);

            if(usuarios.Count > 0) {
                foreach(Usuario i in usuarios) {
                    main.lbl_usuario.Text = i.Nome;
                    Global.Acesso = i.Funcao;
                }
                Global.logado = true;
                main.panel1.Enabled = true;
                main.menuToolStripMenuItem.Enabled = true;
                main.lbl_funcao.Text = Global.Acesso;
                Close();
            } else {
                MessageBox.Show("Usuário e/ou senha inválido(s)", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

