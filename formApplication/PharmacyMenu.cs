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
    public partial class PharmacyMenu : Form
    {
        public PharmacyMenu()
        {
            InitializeComponent();
        }
        
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        int frmMode=0;
        private void frmPharmacy_Load(object sender, EventArgs e)
        {   
            panel1.BackgroundImage = formApplication.Properties.Resources.ادخال;
            frmMode = 0;
        }

       
        private void pnlDrugImports_Click(object sender, EventArgs e)
        {
            if(frmMode == 0)
            {
                formApplication.ImportDrugs frm = new formApplication.ImportDrugs();
                frm.ShowDialog();
            }
            else if(frmMode == 1)
            {
                formApplication.DisplayImportedDrugs frm = new formApplication.DisplayImportedDrugs();
                frm.ShowDialog();
            }
        }

        private void pnlDrugStore_Click(object sender, EventArgs e)
        {
            formApplication.Pharmacy frm = new formApplication.Pharmacy();
            frm.ShowDialog();
        }

        private void pnlExportDrugs_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                formApplication.ExportDrugs frm = new formApplication.ExportDrugs();
                frm.ShowDialog();
            }
            else if (frmMode == 1)
            {
                formApplication.DisplayExportDrugs frm = new formApplication.DisplayExportDrugs();
                frm.ShowDialog();
            }
        }
        bool firstLoad = true;
        private void PharmacyMenu_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this, controlsResult);
        }

        private void pnlEnter_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = formApplication.Properties.Resources.ادخال;
            frmMode = 0;
        }

        private void pnlView_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = formApplication.Properties.Resources.عرض;
            frmMode = 1;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            formApplication.Reports frm = new formApplication.Reports();
            frm.ShowDialog();
        }
    }
}
