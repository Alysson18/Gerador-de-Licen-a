using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Licença
{
    public partial class GerarLicenca : Form
    {
        public GerarLicenca()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            SKGL.Generate key = new SKGL.Generate();
            key.secretPhase = tbsenha.Text;

            TimeSpan data = Convert.ToDateTime(tbDataFinal.Text) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
            int dias = data.Days;

            tbCodigo.Text = key.doKey(dias);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
