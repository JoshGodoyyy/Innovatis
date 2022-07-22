using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Innovatis.Clientes.Entity;

namespace Innovatis.Obra {
    public partial class Nova : Form {
        public Nova() {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients() {
            List<Cliente> clientes = new List<Cliente>();
            clientes = Innovatis.Clientes.Cadastro.LoadData();
            cb_cliente.DataSource = clientes;
            cb_cliente.DisplayMember = "nome";
            cb_cliente.ValueMember = "id";
        }

        private void btn_finalizar_Click(object sender, EventArgs e) {
            Entity.Obra obra = new Entity.Obra() {
                Logradouro = txt_logradouro.Text,
                Bairro = txt_bairro.Text,
                Cidade = txt_cidade.Text,
                CEP = txt_cep.Text,
                IdCliente = int.Parse(cb_cliente.SelectedValue.ToString()),
                ValorContrato = double.Parse(txt_valorContrato.Text),
                DataInicio = DateTime.Parse(dt_Inicio.Text),
                DataFinal = DateTime.Parse(dt_final.Text)
            };

            if(chk_numero.Checked) obra.Numero = 0;
            else obra.Numero = int.Parse(txt_numero.Text);

            if(chk_naoIncluso.Checked) obra.ValorMaterial = 0;
            else double.Parse(txt_valorMaterial.Text);

            Cadastro.InsertData(obra);
            LimparCampos();
        }

        private void LimparCampos() {
            txt_logradouro.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_cep.Clear();
            txt_valorContrato.Clear();
            txt_valorMaterial.Clear();
            dt_Inicio.Value = DateTime.Now;
            dt_final.Value = DateTime.Now;
        }
        private void chk_numero_CheckedChanged(object sender, EventArgs e) {
            if(chk_numero.Checked) txt_numero.Enabled = false;
            else txt_numero.Enabled = true;
        }

        private void chk_naoIncluso_CheckedChanged(object sender, EventArgs e) {
            if(chk_naoIncluso.Checked) txt_valorMaterial.Enabled = false;
            else txt_valorMaterial.Enabled = true;
        }

        private void btn_clienteNaoCadastrado_Click(object sender, EventArgs e) {

        }

        private void btn_procurarContrato_Click(object sender, EventArgs e) {

        }
    }
}
