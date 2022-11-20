using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlaza
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSupplier_Click_1(object sender, EventArgs e)
        {
            //Navigating the page to the Display Supplier Form
            this.Hide();
            FrmSupplier frmSupplier = new FrmSupplier();
            frmSupplier.ShowDialog();
            this.Close();
        }
    }
}
