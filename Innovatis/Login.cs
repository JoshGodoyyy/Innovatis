using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Innovatis.Entity;

namespace Innovatis {
    enum Funcao {
        Desconectado,
        Financeiro,
        Obras,
        Administrador
    }
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
                    switch(i.Nivel) {
                        case 1:
                            main.lbl_funcao.Text = Convert.ToString(Funcao.Financeiro);
                            break;
                        case 2:
                            main.lbl_funcao.Text = Convert.ToString(Funcao.Obras);
                            break;
                        case 3:
                            main.lbl_funcao.Text = Convert.ToString(Funcao.Administrador);
                            break;
                        default:
                            main.lbl_funcao.Text = Convert.ToString(Funcao.Desconectado);
                            break;
                    }
                }
                Global.logado = true;
                main.panel1.Enabled = true;
                main.menuToolStripMenuItem.Enabled = true;
                Close();
            } else {
                MessageBox.Show("Usuário e/ou senha inválido(s)", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

