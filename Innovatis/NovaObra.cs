using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatis {
    public partial class NovaObra : Form {
        public NovaObra() {
            InitializeComponent();
        }

        private void chk_numero_CheckedChanged(object sender, EventArgs e) {
            if(chk_numero.Checked) txt_numero.Enabled = false;
            else txt_numero.Enabled = true;
        }

        private void chk_naoIncluso_CheckedChanged(object sender, EventArgs e) {
            if(chk_naoIncluso.Checked) txt_valorMaoDeObra.Enabled = false;
            else txt_valorMaoDeObra.Enabled = true;
        }
    }
}
