using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroodjesBestellen
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void BtnBestellen_Click(object sender, EventArgs e)
        {
            FrmBroodjes form = new FrmBroodjes();
            form.ShowDialog();
           
        }

        private void BtnBestellingKijken_Click(object sender, EventArgs e)
        {
            FrmBestellingen form = new FrmBestellingen();
            form.ShowDialog();
        }
    }
}
