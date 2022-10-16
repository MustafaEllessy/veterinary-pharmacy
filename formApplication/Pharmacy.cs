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
    public partial class Pharmacy : Form
    {
        DataTable dtDrugStore;

        public Pharmacy()
        {
            InitializeComponent();
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmDrugStore_Load(object sender, EventArgs e)
        {
            loadDrugStore();
            dgvDrug1.ClearSelection();
            dgvDrug1.ClearSelection();
            dgvDrug3.ClearSelection();
            dgvDrug4.ClearSelection();
            dgvDrug5.ClearSelection();
            dgvDrug6.ClearSelection();
            dgvDrug7.ClearSelection();
            dgvDrug8.ClearSelection();
            lblNo.Text = "1";
        }
   

      
        private void loadDrugStore()
        {
            dtDrugStore = DB.Data("select * from drugsStore");
            int rowsCount = dtDrugStore.Rows.Count;
            if(rowsCount==1)
            {
                DataRow dr = dtDrugStore.Rows[0];
                string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                string drugName = dr[3].ToString();
                decimal quantity = Convert.ToDecimal(dr[4].ToString());
                string Unit = dr[5].ToString();
                // if (Unit == "جرام")
                //  {
                dgvDrug1.Rows.Add(new object[] {  1, drugName, expireDate, Unit, quantity, lastUpdate });
            }
          else  
            {
                for (int i = 0; i < 10; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug1.Rows.Add(new object[] { i+1, drugName, expireDate, Unit, quantity, lastUpdate });
                      //}
                }
                for (int i = 10; i < 20; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug2.Rows.Add(new object[] { i + 1, drugName, expireDate, Unit, quantity, lastUpdate });
                    //}
                }


                for (int i = 20; i < 30; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug3.Rows.Add(new object[] { i + 1, drugName, expireDate, Unit, quantity, lastUpdate });
                    //}
                }
                for (int i = 30; i < 40; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug4.Rows.Add(new object[] { i + 1, drugName, expireDate, Unit, quantity, lastUpdate });
                    //}
                }


                for (int i = 40; i < 50; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug5.Rows.Add(new object[] { i + 1, drugName, expireDate, Unit, quantity, lastUpdate });
                    //}
                }
                for (int i = 50; i < 60; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug6.Rows.Add(new object[] { i + 1, drugName, expireDate, Unit, quantity, lastUpdate });
                    //}
                }


                for (int i = 60; i < 70; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug7.Rows.Add(new object[] { i + 1, drugName, expireDate, Unit, quantity, lastUpdate });
                    //}
                }
                for (int i = 70; i < rowsCount; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string lastUpdate = dr[2].ToString() == "" ? "" : ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug8.Rows.Add(new object[] { i + 1, drugName, expireDate, Unit, quantity, lastUpdate });
                    //}
                }

            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgvDrug1.Visible)
            {
                lblNo.Text = "2";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = true;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }

          else  if (dgvDrug2.Visible)
            {
                lblNo.Text = "3";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = true;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug3.Visible)
            {
                lblNo.Text = "4";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = true;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug4.Visible)
            {
                lblNo.Text = "5";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = true;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug5.Visible)
            {
                lblNo.Text = "6";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = true;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug6.Visible)
            {
                lblNo.Text = "7";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = true;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug7.Visible)
            {
                lblNo.Text = "8";
                dgvDrug1.Visible = false;
                dgvDrug1.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = true;
            }


        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
         
             if (dgvDrug2.Visible)
            {
                lblNo.Text = "1";
                dgvDrug1.Visible = true;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug3.Visible)
            {
                lblNo.Text = "3";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = true;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug4.Visible)
            {
                lblNo.Text = "3";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = true;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug5.Visible)
            {
                lblNo.Text = "4";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = true;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug6.Visible)
            {
                lblNo.Text = "5";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = true;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug7.Visible)
            {
                lblNo.Text = "6";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = true;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = false;
            }
            else if (dgvDrug8.Visible)
            {
                lblNo.Text = "7";
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = true;
                dgvDrug8.Visible = false;
            }

        }

        private void dgvStore1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStore2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvStore2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDrug8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool firstLoad = true;
        private void Pharmacy_Resize(object sender, EventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
