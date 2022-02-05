using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletaDeColores
{
    public partial class PaletaColores: UserControl
    {
        string useColor;
        ColorDialog colorDialog = new ColorDialog();

        public string SelectColor()
        {
            return useColor;
        }
        public PaletaColores()
        {
            InitializeComponent();
        }

        private void btnPaletaColores_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.useColor = "" + colorDialog.Color.R + ',' + colorDialog.Color.G + ',' + colorDialog.Color.B;
                SelectColor();
            }
        }
    }
}
