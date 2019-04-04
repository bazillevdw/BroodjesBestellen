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
    public partial class FrmBroodjes : Form
    {
        Business buss = new Business();
        public FrmBroodjes()
        {
            InitializeComponent();
        }

        private void FrmBroodjes_Load(object sender, EventArgs e)
        {
            txtBroodje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            txtBroodje.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBroodje.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (string item in buss.getBroodjes())
            {
                txtBroodje.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buss.AddBrood(txtNaam.Text, txtBroodje.Text, Convert.ToInt32(TxtHoeveelheid.Text), Convert.ToDouble(TxtPrijs.Text), RtbOpmerking.Text);
            txtNaam.Text = "";
            txtBroodje.Text = "";
            TxtHoeveelheid.Text = "";
            TxtPrijs.Text = "";
            RtbOpmerking.Text = "";
            txtBroodje.Items.Clear();
            foreach (string item in buss.getBroodjes())
            {
                txtBroodje.Items.Add(item);
            }
            MessageBox.Show("De bestelling is gelukt!","Succes");            
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GbBestelling_Enter(object sender, EventArgs e)
        {

        }

        private void txtBroodje_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
