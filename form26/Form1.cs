using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form26
{
    public partial class Form1 : Form
    {
        //buradaki değişkenler globaldir.
        double bakiye = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = "Bakiye :" +bakiye.ToString();
            lblBakiye.ForeColor = Color.DarkGreen;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            lblBakiye.Text = "Bakiye :" + bakiye.ToString();

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (bakiye >= 8)
            {
                bakiye -= 8;
                lblBakiye.Text = "Bakiye :" + bakiye.ToString();
            }
            else
            {

                lblBakiye.Text = "Paran Yok Pis Fakir...";
                lblBakiye.ForeColor = Color.Red;
            }
        }

    }
}
