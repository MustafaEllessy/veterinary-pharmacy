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
    public partial class ExportDrugs : Form
    {
        public ExportDrugs()
        {
            InitializeComponent();
        }

        private void dgvStore1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxFarmType_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            cbxStationName.Items.Clear();
            if (cbxStationType.SelectedIndex==0)
            {
                cbxStationName.Items.Add("محطة 3");
                cbxStationName.Items.Add("محطة 5");
            }
          else if (cbxStationType.SelectedIndex == 1)
            {
                cbxStationName.Items.Add("محطة 2");
            }
            cbxStationName.Text = "";
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        public void setupTheDGVs()
        {
            dgvDrug8.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug8.Columns[5].HeaderCell.Style.ForeColor = Color.White;


            dgvDrug7.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug7.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug6.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug6.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug5.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug5.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug4.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug4.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug3.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug3.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug2.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug2.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug1.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug1.Columns[5].HeaderCell.Style.ForeColor = Color.White;

        }
        private void frmExportedDrugs_Load(object sender, EventArgs e)
        {
            setupTheDGVs();
            loadDrugStore();
            cbxStationType.Items.Add("بياض");
            cbxStationType.Items.Add("تسمين");
            cbxStationType.SelectedIndex = 0;
            cbxStationName.SelectedIndex = 0;
        }

        DataTable dtDrugStore;
        List<int> rowIndex1 = new List<int>();
        List<int> rowIndex2 = new List<int>();
        List<int> rowIndex3 = new List<int>();
        List<int> rowIndex4 = new List<int>();
        List<int> rowIndex5 = new List<int>();
        List<int> rowIndex6 = new List<int>();
        List<int> rowIndex7 = new List<int>();
        List<int> rowIndex8 = new List<int>();
        private void loadDrugStore()
        {
            dtDrugStore = DB.Data("select * from drugsStore");
            int rowsCount = dtDrugStore.Rows.Count;
            if (rowsCount == 1)
            {
                DataRow dr = dtDrugStore.Rows[0];
                string drugName = dr[3].ToString();
                decimal quantity = Convert.ToDecimal(dr[4].ToString());
                string Unit = dr[5].ToString();
                string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                // if (Unit == "جرام")
                //  {
                dgvDrug1.Rows.Add(new object[] { 1, drugName, Unit, quantity, expireDate, 0 });
                // }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug1.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }
                for (int i = 10; i < 20; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    //  {
                    dgvDrug2.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }

                for (int i = 20; i < 30; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug3.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }
                for (int i = 30; i < 40; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug4.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }
                for (int i = 40; i < 50; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug5.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }
                for (int i = 50; i < 60; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug6.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }
                for (int i = 60; i < 70; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug7.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }
                for (int i = 70; i < rowsCount; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[3].ToString();
                    decimal quantity = Convert.ToDecimal(dr[4].ToString());
                    string Unit = dr[5].ToString();
                    string expireDate = dr[1].ToString() == "" ? "" : ((DateTime)dr[1]).ToString("yyyy/MM/dd");
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug8.Rows.Add(new object[] { i + 1, drugName, Unit, quantity, expireDate, 0 });
                    // }
                }




            }
        }
        private void btnPrev1_Click(object sender, EventArgs e)
        {

            if (dgvDrug2.Visible)
            {
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
   
        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (dgvDrug1.Visible)
            {
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
                dgvDrug1.Visible = false;
                dgvDrug2.Visible = false;
                dgvDrug3.Visible = false;
                dgvDrug4.Visible = false;
                dgvDrug5.Visible = false;
                dgvDrug6.Visible = false;
                dgvDrug7.Visible = false;
                dgvDrug8.Visible = true;
            }
         
        }
    


        public void addExportedDrug(DataGridViewRow dr)
        {
            string drugDateTime = dtExportDate.Value.ToString("dd/MM/yyyy");
            string drugName = dr.Cells[1].Value.ToString();
            string quantity = dr.Cells[5].Value.ToString();
            string unit = dr.Cells[2].Value.ToString();
            decimal quant = 0;
            string expireDate =dr.Cells[4].Value.ToString();
            if (quantity == null || (quantity == "") || (quantity == "0"))
                return;
            else
            {
                quant = Convert.ToDecimal(quantity);
            }
            string doctorName = txtDoctorName.Text == null ? "" : txtDoctorName.Text;
        if(expireDate=="")
            {
                object[] rawData = new object[] { drugDateTime, drugName, quant, unit, cbxStationType.SelectedItem.ToString(), cbxStationName.SelectedItem.ToString(), doctorName };
                DB.insertToDB("exportedDrugs", new string[] { "exportDate", "drugName", "quantity", "unit", "stationType", "stationName", "doctorName" }, rawData);
            }
            else
            {
                object[] rawData = new object[] { drugDateTime, drugName, expireDate, quant, unit, cbxStationType.SelectedItem.ToString(), cbxStationName.SelectedItem.ToString(), doctorName };

                DB.insertToDB("exportedDrugs", new string[] { "exportDate", "drugName", "expireDate", "quantity", "unit", "stationType", "stationName", "doctorName" }, rawData);

            }
        }
        public void updateDrugStore(DataGridViewRow dr)
        {
            string lastUpdate = dtExportDate.Value.ToString("dd/MM/yyyy");
            string drugName = dr.Cells[1].Value.ToString();
            string expireDate = dr.Cells[4].Value.ToString();
            string quantity = dr.Cells[3].Value.ToString();
            if (quantity == null || (quantity == "") || (quantity == "0"))
                return;
         
            int id = storeID(expireDate, drugName);
            if (int.Parse(quantity) > 0)
            {
              
                DB.affectBuild("update drugsStore set lastUpdate='" + lastUpdate + "', quantity=" + quantity + " where ID=" + id + ";");
            }
          
        }

        public int storeID(string expireDate, string drugName)
        {
            foreach (DataRow dr in dtDrugStore.Rows)
            {
                if (dr[1].ToString() != "")
                {
                    if (((DateTime)dr[1]).ToString("yyyy/MM/dd") == expireDate && drugName == dr[3].ToString())
                    {
                        return Convert.ToInt32(dr[0]);
                    }
                }

             else if (  expireDate=="" && drugName == dr[3].ToString())
                {
                    return Convert.ToInt32(dr[0]);
                }
            }
            return -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
              if(cbxStationType.SelectedIndex<0 || cbxStationName.SelectedIndex < 0)
                {
                    MessageBox.Show("أملأ الخانات ببيانات صحيحة");
                    return;
                }
                List<int> row1 = rowIndex1.Distinct().ToList();
                List<int> row2 = rowIndex2.Distinct().ToList();
                List<int> row3 = rowIndex3.Distinct().ToList();
                List<int> row4 = rowIndex4.Distinct().ToList();
                List<int> row5 = rowIndex5.Distinct().ToList();
                List<int> row6 = rowIndex6.Distinct().ToList();
                List<int> row7 = rowIndex7.Distinct().ToList();
                List<int> row8 = rowIndex8.Distinct().ToList();
                for (int i = 0; i < row1.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug1.Rows[row1[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < row2.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug2.Rows[row2[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < row3.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug3.Rows[row3[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < row4.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug4.Rows[row4[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < row5.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug5.Rows[row5[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < row6.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug6.Rows[row6[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < row7.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug7.Rows[row7[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < row8.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug8.Rows[row8[i]];
                    addExportedDrug(dr);
                    updateDrugStore(dr);
                }
                if ((row1.Count + row2.Count + row3.Count + row4.Count + row5.Count + row6.Count + row7.Count + row8.Count) == 0)
                {
                    MessageBox.Show("لم يتم ادخال بيانات");
                    return;
                }
                MessageBox.Show("تم الحفظ");
                for (int i = 0; i < row1.Count; i++)
                {
                    dgvDrug1.Rows[row1[i]].Cells[5].Value = 0;
                }
                for (int i = 0; i < row2.Count; i++)
                {
                    dgvDrug2.Rows[row2[i]].Cells[5].Value = 0;
                }
                for (int i = 0; i < row3.Count; i++)
                {
                    dgvDrug3.Rows[row3[i]].Cells[5].Value = 0;
                }
                for (int i = 0; i < row4.Count; i++)
                {
                    dgvDrug4.Rows[row4[i]].Cells[5].Value = 0;
                }
                for (int i = 0; i < row5.Count; i++)
                {
                    dgvDrug5.Rows[row5[i]].Cells[5].Value = 0;
                }
                for (int i = 0; i < row6.Count; i++)
                {
                    dgvDrug6.Rows[row6[i]].Cells[5].Value = 0;
                }
                for (int i = 0; i < row7.Count; i++)
                {
                    dgvDrug7.Rows[row7[i]].Cells[5].Value = 0;
                }
                for (int i = 0; i < row8.Count; i++)
                {
                    dgvDrug8.Rows[row8[i]].Cells[5].Value = 0;
                }
                row1.Clear();
                row2.Clear();
                row3.Clear();
                row4.Clear();
                row5.Clear();
                row6.Clear();
                row7.Clear();
                row8.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد مشكلة كالاًتى: " + ex.Message);
            }


        }

        private void dgvDrugImport_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex == 5)
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                }
            }
        }
        private void dgvDrugImport8_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
       
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDrugImport1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug1.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug1.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug1.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug1.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug1.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (exportedQuant > storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug1.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug1.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex1.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug2.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug2.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug2.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug2.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug2.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (exportedQuant > storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug2.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug2.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex2.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug3.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug3.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug3.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug3.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug3.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (exportedQuant > storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug3.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug3.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex3.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport4_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug4.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug4.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug4.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug4.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug4.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (exportedQuant > storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug4.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug4.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex4.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug5.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug5.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug5.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug5.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug5.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (exportedQuant > storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug5.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug5.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex5.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport6_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug6.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug6.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug6.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport6_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug6.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug6.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (exportedQuant > storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug6.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug6.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex6.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport7_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug7.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug7.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug7.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport7_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug7.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug7.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (exportedQuant > storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug7.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug7.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex7.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvDrugImport8_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug8.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug8.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug8.Rows[e.RowIndex].Cells[3].Value = storeQuant + exportedQuant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrugImport8_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int exportedQuant = Convert.ToInt32(dgvDrug8.Rows[e.RowIndex].Cells[5].Value);
                int storeQuant = Convert.ToInt32(dgvDrug8.Rows[e.RowIndex].Cells[3].Value.ToString());
                if(exportedQuant> storeQuant)
                {
                    MessageBox.Show("لا يوجد رصيد باالمخزن");
                    dgvDrug8.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                dgvDrug8.Rows[e.RowIndex].Cells[3].Value = storeQuant - exportedQuant;
                rowIndex8.Add(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDrug8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool firstLoad = true;
        private void ExportDrugs_Resize(object sender, EventArgs e)
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

        private void dgvDrug8_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
