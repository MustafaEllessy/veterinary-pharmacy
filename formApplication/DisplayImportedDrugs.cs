using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApplication
{
    public partial class DisplayImportedDrugs : Form
    {
        DataTable dtImportedDrugs;
        public DisplayImportedDrugs()
        {
            InitializeComponent();
        }

        private void frmImportedDrugsDisplay_Load(object sender, EventArgs e)
        {
            dtImportedDrugs = DB.Data("select * from importedDrugs");
            dgvImportedDrugs.DataSource = dtImportedDrugs;
            dgvImportedDrugs.Columns["ID"].Visible = false;
            orderColumns();
            dgvImportedDrugs.ClearSelection();
            dgvImportedDrugs.Sort(dgvImportedDrugs.Columns["colImportDate"], ListSortDirection.Ascending);
        }

        private void orderColumns()
        {
            dgvImportedDrugs.Columns["colImportDate"].DisplayIndex = 0;
            dgvImportedDrugs.Columns["colCompanyName"].DisplayIndex = 1;
            dgvImportedDrugs.Columns["colDrugName"].DisplayIndex = 2;
            dgvImportedDrugs.Columns["colExpireDate"].DisplayIndex = 3;
            dgvImportedDrugs.Columns["colPrice"].DisplayIndex = 4;
            dgvImportedDrugs.Columns["colUnit"].DisplayIndex = 5;
            dgvImportedDrugs.Columns["colQuantity"].DisplayIndex = 6;

        }

        private void dgvVisitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
