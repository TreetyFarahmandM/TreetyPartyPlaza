using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlaza
{
   
    public partial class frmDisplaySupplier : Form
    {
        bool visible = true;

        SqlDataAdapter daSupplier;
        DataSet dsPartyPlaza = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        public frmDisplaySupplier()
        {
            InitializeComponent();
        }
        private void frmDisplaySupplier_load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .; Initial Catalog = PartyPlaza; Intergrated Security = true";
            //DESKTOP-5PH67NH\SQLEXPRESS01
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);

            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");

            dgvSupplier.DataSource = dsPartyPlaza.Tables["Supplier"];

            dgvSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {
            //frmAddSupplier;

            frmAddSupplier frm = new frmAddSupplier();

        }

        private void btnDisplayEdit_Click(object sender, EventArgs e)
        {
           // frmEditSupplier
        }

        private void btnDisplayDelete_Click(object sender, EventArgs e)
        {
          /*  if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier from the list.", "Select Supplier");
            }
            else
                drSupplier = dsPartyPlaza.Tables["Supplier"].Rows.Find(dgvSupplier.SelectedRows[0].ToString());
            
            //Do I need that??
            //string tempName = drSupplier["Name"].ToString();

            //if(MessageBox.Show("Are you sure you want to delete ") + TempFileCollectionName )*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDisplayExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
