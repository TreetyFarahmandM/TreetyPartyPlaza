using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PartyPlaza
{
    public partial class FrmSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsPartyPlaza = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        
        public FrmSupplier()
        {
            InitializeComponent();
        }
        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {
            //Navigating the Supplier page to the Add Supplier Form
            this.Hide();
            frmAddSupplier FormAddSupplier = new frmAddSupplier();
            FormAddSupplier.ShowDialog();
            this.Close();
        }

        private void btnExitSupplier_Click(object sender, EventArgs e)
        {
            //Navigating the page to the Main Form
            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.ShowDialog();
            this.Close();
        }
        private void btnDisplayEdit_Click(object sender, EventArgs e)
        {
            //Navigating the Supplier page to the Edit Supplier Form
            if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier", "Edit Supplier");
            }
            else if (dgvSupplier.SelectedRows.Count == 1)
            {
                this.Hide();
                FrmEditSupplier editSupplierForm = new FrmEditSupplier();
                editSupplierForm.ShowDialog();
                this.Close();
            }
        }
        private void butDisplayDelete_Click(object sender, EventArgs e)
        { 
            if (dgvSupplier.Rows.Count == 0)
                MessageBox.Show("Please select a customer from the list.", "Select Customer");

            else
            {
                drSupplier = dsPartyPlaza.Tables["Supplier"].Rows.Find(dgvSupplier.SelectedRows[0].Cells[0].Value);
                String tempName = drSupplier["Business Name"].ToString();

                if (MessageBox.Show("Are you sure you want to delete" + tempName + " details?", "Add Supplier",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drSupplier.Delete();
                    daSupplier.Update(dsPartyPlaza, "Supplier");
                }
            }
        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            
            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");
            dgvSupplier.DataSource = dsPartyPlaza.Tables["Supplier"];

            //Resize the DataGridView colums to fit the newly loaded content.
            dgvSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
