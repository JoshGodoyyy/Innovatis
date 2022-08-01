using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Innovatis.Obra {
    public partial class Relatorio : Form {
        int id;
        public Relatorio(int id) {
            InitializeComponent();
            this.id = id;
            Listar();
        }

        private void Listar() {
            List<Entity.Obra> obras = new List<Entity.Obra>();
            obras = Obras.Relatorio(id);

            double contratoMO = 0
                , contratoMaterial = 0;
            foreach(var i in obras) {
                lbl_cliente.Text = i.NomeCliente;
                lbl_endereco.Text = i.Logradouro + ", " + i.Numero + " - " + i.Bairro;
                lbl_dataInicio.Text = i.DataInicio.ToString("dd/MM/yyyy");
                lbl_dataFinal.Text = i.DataFinal.ToString("dd/MM/yyyy");
                lbl_dataEntrega.Text = i.DataEntrega.ToString("dd/MM/yyyy");
                contratoMO = double.Parse(i.ValorContrato.ToString());
                contratoMaterial = double.Parse(i.ValorMaterial.ToString());
            }

            lbl_contrato.Text = contratoMO.ToString("N2");
            lbl_valorMaterial.Text = contratoMaterial.ToString("N2");

            List<Entity.Material> materiais = new List<Entity.Material>();
            materiais = Historicos.ListarMateriais(id);
            dt_itens.DataSource = materiais;

            dt_itens.Columns[0].Visible = false;
            dt_itens.Columns[1].Visible = false;
            dt_itens.Columns[2].Visible = true;
            dt_itens.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dt_itens.Columns[3].Visible = true;
            dt_itens.Columns[4].Visible = true;
            dt_itens.Columns[5].Visible = false;
            dt_itens.Columns[6].Visible = false;

            double mO = 0;
            double mat = 0;
            foreach(var i in materiais) {
                if(i.Descricao == "Medição") mO += i.Valor;
                else mat += i.Valor;
            }

            lbl_pagoMO.Text = mO.ToString("N2");
            lbl_pagoMaterial.Text = mat.ToString("N2");

            if(mO > contratoMO) lbl_pagoMO.ForeColor = Color.Red;
            else if(mO == contratoMO) lbl_pagoMO.ForeColor = Color.Black;
            else lbl_pagoMO.ForeColor = Color.Green;

            if(mat > contratoMaterial) lbl_pagoMaterial.ForeColor = Color.Red;
            else if(mat == contratoMaterial) lbl_pagoMaterial.ForeColor = Color.Black;
            else lbl_pagoMaterial.ForeColor = Color.Green;
        }
    }
}
