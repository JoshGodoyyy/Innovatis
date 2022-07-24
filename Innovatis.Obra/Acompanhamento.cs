using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Innovatis.Obra.Entity;

namespace Innovatis.Obra {
    public partial class Acompanhamento : Form {
        public Acompanhamento() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            List<Entity.Obra> obras = new List<Entity.Obra>();
            obras = Cadastro.LoadData();

            list_obras.DataSource = obras;
            list_obras.DisplayMember = "logradouro";
            list_obras.ValueMember = "id";
        }

        private void list_obras_SelectedIndexChanged(object sender, System.EventArgs e) {
            var aux = list_obras.SelectedValue;
            if(list_obras.SelectedValue != aux) {
                try {
                    List<Material> materiais = new List<Material>();
                    materiais = Cadastro.ListarMateriais(int.Parse(list_obras.SelectedValue.ToString()));

                    list_historico.DataSource = materiais;
                    list_historico.DisplayMember = "descricao";
                    list_historico.ValueMember = "id";
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
