using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Innovatis.Obra.Entity;
using System.Data;

namespace Innovatis.Obra {
    public partial class Acompanhamento : Form {
        private int id;
        public Acompanhamento() {
            InitializeComponent();
            Listar();
            DesabilitarCampos();
        }

        private void Listar() {
            List<Entity.Obra> obras = new List<Entity.Obra>();
            obras = Cadastro.ListarObras();

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

                    List<Entity.Obra> obras = new List<Entity.Obra>();
                    obras = Cadastro.ListarObrasById(int.Parse(list_obras.SelectedValue.ToString()));

                    double valMO = 0;
                    double valMat = 0;
                    foreach(var item in obras) {
                        valMO = item.ValorContrato;
                        valMat = item.ValorMaterial;
                        lbl_dataFinal.Text = item.DataFinal.ToString("dd/MM/yyyy");
                    }

                    lbl_moContratada.Text = valMO.ToString("N2");
                    lbl_valorContratoMaterial.Text = valMat.ToString("N2");

                    double sumMO = 0;
                    double sumMat = 0;

                    foreach(var item in materiais) {
                        if (item.Descricao == "Medição") {
                            sumMO += item.Valor;
                        } else {
                            sumMat += item.Valor;
                        }
                    }

                    lbl_moPaga.Text = sumMO.ToString("N2");
                    lbl_valorPagoMateriais.Text = sumMat.ToString("N2");

                    double resMO = valMO - sumMO;
                    double resMat = valMat - sumMat;

                    lbl_totalMO.Text = resMO.ToString("N2");
                    lbl_saldoMaterial.Text = resMat.ToString("N2");
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void list_historico_SelectedIndexChanged(object sender, EventArgs e) {
            var aux = list_historico.SelectedValue;
            if(list_historico.SelectedValue != aux) {
                HabilitarCampos();
                DataTable data = new DataTable();
                data = Cadastro.SelecionarMaterial(int.Parse(list_historico.SelectedValue.ToString()));

                foreach(DataRow i in data.Rows) {
                    id = int.Parse(i["id"].ToString());
                    txt_descricao.Text = i["descricao"].ToString();
                    dt_data.Value = DateTime.Parse(i["data"].ToString());
                    txt_valor.Text = i["valor"].ToString();
                    txt_nota.Text = i["nota"].ToString();
                    txt_local.Text = i["local_entrega"].ToString();
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e) {
            try {
                Material material = new Material() {
                    Id = int.Parse(list_historico.SelectedValue.ToString()),
                    Descricao = txt_descricao.Text,
                    Data = DateTime.Parse(dt_data.Text),
                    Valor = double.Parse(txt_valor.Text),
                    Nota = txt_nota.Text,
                    LocalEntrega = txt_local.Text
                };

                Cadastro.EditarPedido(material);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DesabilitarCampos();
        }

        private void btn_remover_Click(object sender, EventArgs e) {
            try {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar este item?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes) Cadastro.RemoverPedido(int.Parse(list_historico.SelectedValue.ToString()));
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DesabilitarCampos();
        }
        private void HabilitarCampos() {
            txt_descricao.Enabled = true;
            txt_local.Enabled = true;
            txt_nota.Enabled = true;
            txt_valor.Enabled = true;
            dt_data.Enabled = true;
            btn_editar.Enabled = true;
            btn_remover.Enabled = true;
        }

        private void DesabilitarCampos() {
            txt_descricao.Enabled = false;
            txt_local.Enabled = false;
            txt_nota.Enabled = false;
            txt_valor.Enabled = false;
            dt_data.Enabled = false;
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
            LimparCampos();
        }

        private void LimparCampos() {
            txt_descricao.Clear();
            txt_local.Clear();
            txt_nota.Clear();
            txt_valor.Clear();
            dt_data.Value = DateTime.Now;
        }
    }
}
