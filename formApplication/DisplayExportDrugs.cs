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
    public partial class DisplayExportDrugs : Form
    {
        DataTable dtExportDrugs;
        public DisplayExportDrugs()
        {
            InitializeComponent();
        }

        private void dgvVisitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void frmExportedDrugsDisplay_Load(object sender, EventArgs e)
        {
            dtExportDrugs = DB.Data("select * from exportedDrugs");
            dgvExportedDrugs.DataSource = dtExportDrugs;
            dgvExportedDrugs.Columns["ID"].Visible = false;
            orderColumns();
            dgvExportedDrugs.ClearSelection();
           dgvExportedDrugs.Sort(dgvExportedDrugs.Columns["colExportDate"], ListSortDirection.Ascending);
        }
        private void orderColumns()
        {
            dgvExportedDrugs.Columns["colExportDate"].DisplayIndex = 0;
            dgvExportedDrugs.Columns["colStationType"].DisplayIndex = 1;
            dgvExportedDrugs.Columns["colStationName"].DisplayIndex = 2;
            dgvExportedDrugs.Columns["colDrugName"].DisplayIndex = 3;
            dgvExportedDrugs.Columns["colExpireDate"].DisplayIndex = 4;
            dgvExportedDrugs.Columns["colUnit"].DisplayIndex = 5;
            dgvExportedDrugs.Columns["colQuantity"].DisplayIndex = 6;
            dgvExportedDrugs.Columns["colDoctorName"].DisplayIndex = 7;

        }

    }
}
