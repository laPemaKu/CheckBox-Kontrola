using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbRucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            txtOdabir.Clear();
            txtOdabir.AppendText("Odabrali ste"+ Environment.NewLine);
            if (ckbDorucak.Checked)
            {
                txtOdabir.AppendText("Dorucak" + Environment.NewLine);
            }
            if (ckbRucak.Checked)
            {
                txtOdabir.AppendText("Rucak" + Environment.NewLine);
            }
            if (ckbVecera.Checked)
            {
                txtOdabir.AppendText("Veceru" + Environment.NewLine);
            }
        }

        private void ckbSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (txtOdabir.Visible == false)
            {
                txtOdabir.Visible = true;
            }
            else
            {
                txtOdabir.Visible = false;
            }
        }
    }
}
