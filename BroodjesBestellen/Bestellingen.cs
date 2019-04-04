using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BroodjesBestellen
{
    public partial class FrmBestellingen : Form
    {
        Business bus = new Business();
        public FrmBestellingen()
        {
            InitializeComponent();
        }
    
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        

        private void btnZoek_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmBestellingen_Load(object sender, EventArgs e)
        {
            foreach (string item in bus.getBrood())
            {
                lstBestellingen.Items.Add(item);
            }
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            string strBestelling, resultString;
            int id=0;          
            if (txtID.Text == "")
            {
                if (lstBestellingen.SelectedIndex == -1)
                {
                    MessageBox.Show("Gelieve een bestelling te selecteren in de lijst","error 404");
                }
                else
                {
                    strBestelling = lstBestellingen.SelectedItem.ToString();
                    resultString = Regex.Match(strBestelling, @"\d+").Value;
                    id = Convert.ToInt32(resultString);
                }               
            }
            else
            {
                if(txtID.Text == "")
                {
                    MessageBox.Show("gelieve een id in te vullen in de lijst", "error 404");
                }
                id = Convert.ToInt32(txtID.Text);
            }           
            bus.DeleteBrood(id);
            txtID.Text = "";
            lstBestellingen.Items.Clear();
            foreach (string item in bus.getBrood())
            {
                lstBestellingen.Items.Add(item);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lstBestellingen.Items.Clear();

            foreach (string str in bus.getBrood())
            {
                if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    lstBestellingen.Items.Add(str);
                }
            }
        }
    }
}
