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
    public partial class ImportDrugs : Form
    {
        public ImportDrugs()
        {
            InitializeComponent();
        }
        public void setupTheDGVs()
        {
            dgvDrug8.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug8.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug8.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug8.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug8.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug8.Columns[4].HeaderCell.Style.ForeColor = Color.White;


            dgvDrug7.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug7.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug7.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug7.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug7.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug7.Columns[4].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug6.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug6.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug6.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug6.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug6.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug6.Columns[4].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug5.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug5.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug5.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug5.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug5.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug5.Columns[4].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug4.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug4.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug4.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug4.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug4.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug4.Columns[4].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug3.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug3.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug3.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug3.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug3.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug3.Columns[4].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug2.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug2.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug2.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug2.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug2.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug2.Columns[4].HeaderCell.Style.ForeColor = Color.White;

            dgvDrug1.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug1.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDrug1.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            dgvDrug1.Columns[4].HeaderCell.Style.ForeColor = Color.White;

     

        }
        DataTable mainStore;
        private void frmImportedDrugs_Load(object sender, EventArgs e)
        {
            setupTheDGVs();
            loadDrugStore();
            mainStore = DB.Data("select * from drugsStore");
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        DataTable dtDrugStore;
        List<int> rowIndex1 = new List<int>();
        List<int> rowIndex2 = new List<int>();
        List<int> rowIndex3 = new List<int>();
        List<int> rowIndex4 = new List<int>();
        List<int> rowIndex5 = new List<int>();
        List<int> rowIndex6 = new List<int>();
        List<int> rowIndex7 = new List<int>();
        List<int> rowIndex8 = new List<int>();
        public List<KeyValuePair<string, string>> itemAndUnit()
        {
            List<KeyValuePair<string, string>> itemAndUnit = new List<KeyValuePair<string, string>>();
            foreach (DataRow row in dgvDrug1.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            foreach (DataRow row in dgvDrug2.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            foreach (DataRow row in dgvDrug3.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            foreach (DataRow row in dgvDrug4.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            foreach (DataRow row in dgvDrug5.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            foreach (DataRow row in dgvDrug6.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            foreach (DataRow row in dgvDrug7.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            foreach (DataRow row in dgvDrug8.Rows)
            {
                itemAndUnit.Add(new KeyValuePair<string, string>(row[3].ToString(), row[6].ToString()));
            }
            return itemAndUnit;
        }
        private void loadDrugStore()
        {
            dtDrugStore = DB.Data("select * from drugNames");
            int rowsCount = dtDrugStore.Rows.Count;
            if (rowsCount == 1)
            {
                DataRow dr = dtDrugStore.Rows[0];
                string drugName = dr[3].ToString();
                decimal quantity = Convert.ToDecimal(dr[5].ToString());
                string Unit = dr[6].ToString();
                string expireDate = dr[2].ToString()==""?"": ((DateTime)dr[2]).ToString("yyyy/MM/dd");
                // if (Unit == "جرام")
                //  {
                dgvDrug1.Rows.Add(new object[] { 1, drugName, Unit ,quantity,expireDate,"","",0,0});
                // }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug1.Rows.Add(new object[] { i+1, drugName, Unit,"", 0, 0 });
                    // }
                }
                for (int i = 10; i < 20; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug2.Rows.Add(new object[] { i + 1, drugName, Unit, "", 0, 0 });
                    // }
                }

                for (int i = 20; i < 30; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug3.Rows.Add(new object[] { i + 1, drugName, Unit, "", 0, 0 });
                }
                for (int i = 30; i < 40; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug4.Rows.Add(new object[] { i + 1, drugName, Unit, "", 0, 0 });
                }
                for (int i = 40; i < 50; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug5.Rows.Add(new object[] { i + 1, drugName, Unit, "", 0, 0 });
                }
                for (int i = 50; i < 60; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug6.Rows.Add(new object[] { i + 1, drugName, Unit, "", 0, 0 });
                }
                for (int i = 60; i < 70; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug7.Rows.Add(new object[] { i + 1, drugName, Unit, "", 0, 0 });
                }
                for (int i = 70; i < rowsCount; i++)
                {
                    DataRow dr = dtDrugStore.Rows[i];
                    string drugName = dr[0].ToString();
                    string Unit = dr[1].ToString();
                    // if (Unit == "جرام")
                    //  {
                    dgvDrug8.Rows.Add(new object[] { i + 1, drugName, Unit, "", 0, 0 });
                }




            }
        }

   
        private decimal[] convertFromGramToTonAndKiloAndGram(decimal quantity)
        {
            decimal tonn = Convert.ToDecimal(Math.Truncate(Convert.ToDecimal(quantity / 1000000)));
            decimal Killo = Convert.ToDecimal(Math.Truncate(Convert.ToDecimal((quantity - (tonn * 1000000)) / 1000)));
            decimal Gram = Convert.ToDecimal((quantity - ((tonn * 1000000) + (Killo * 1000))));
            return new decimal[] { Gram, Killo, tonn };
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

        bool dateError = false;
        public void addImportedDrug(DataGridViewRow dr)
        {
            string quantity = dr.Cells[4].Value.ToString();
            decimal quant = Convert.ToDecimal(quantity);
          
            string drugDateTime = dtImportTime.Value.ToString("dd/MM/yyyy");
            string drugName = dr.Cells[1].Value.ToString();
            string productDate = dr.Cells[5].Value.ToString();
            string expireDate = dr.Cells[3].Value.ToString();
            expireDate = replaceFN(expireDate);
            string unit = dr.Cells[2].Value.ToString();
            string price = dr.Cells[5].Value.ToString();
            string companyName = txtCompanyName.Text;

 

            price = (price == null) ? "0" : price;
            object[] rawData = new object[] { drugDateTime,expireDate ,drugName, quant, unit, Convert.ToDecimal(price) , companyName };
            DB.insertToDB("importedDrugs", new string[] { "importDate","expireDate", "drugName", "quantity", "unit", "price", "companyName" }, rawData);
        }
      
        public void updateDrugStore(DataGridViewRow dr)
        {
            string importQuantity = dr.Cells[4].Value.ToString();
            string drugDateTime = dtImportTime.Value.ToString("dd/MM/yyyy");
            string drugName = dr.Cells[1].Value.ToString();
            string unit = dr.Cells[2].Value.ToString();
            string startDate = dr.Cells[5].Value.ToString();
            string expireDate = dr.Cells[3].Value.ToString();
            expireDate = replaceFN(expireDate);
            int id = storeID(drugName, expireDate, unit);
          

            //update store
            if (id!=-1)
            {
                int quantity =Convert.ToInt32( DB.Data("select quantity from drugsStore where ID=" + id).Rows[0][0].ToString());
                decimal quantSum = quantity + decimal.Parse(importQuantity);
                DB.affectBuild("update drugsStore set lastUpdate='" + drugDateTime + "', quantity=" + quantSum + " where ID  = " + id + ";");
            
            }
           //add new row
            else
            {
                object[] rawData = new object[] {   expireDate, drugDateTime, drugName, importQuantity, unit};
                DB.insertToDB("drugsStore", new string[] { "expireDate", "lastUpdate", "drugName", "quantity", "unit" }, rawData);
            }


        }
        public string replaceFN(string date)
        {
            if (date.Contains('-'))
                date.Replace('-', '/');
            return date;
        }
        public string dateFilter(string date)
        {
            string[] dateParts = date.Split('/');
            if (dateParts[1].Length == 1) dateParts[1] = 0 + dateParts[1];
            if (dateParts[2].Length == 1) dateParts[2] = 0 + dateParts[2];
          else  if (dateParts[0].Length == 1) dateParts[0] = 0 + dateParts[0];
            if (Convert.ToInt32( dateParts[0])>2000)
                date = dateParts[2]+"/"+ dateParts[1] + "/"+dateParts[0] ;
            else
                date= dateParts[0] + "/" + dateParts[1] + "/" + dateParts[2];
            return date;
        }
        public int storeID(string drugName, string expireDate,string unit)
        {
        
            string expire=dateFilter(expireDate);
            foreach (DataRow dr in mainStore.Rows)
            {
                if(dr[3].ToString() == drugName && ((DateTime)dr[1]).ToString("dd/MM/yyyy")==expire && dr[5].ToString() == unit) 
                    return Convert.ToInt32( dr[0].ToString());
            }
            return -1;
        }
        public bool checkDate(string date)
        {
            string[] dateParts = date.Split('/');
            if (dateParts.Length != 3) return false;
            if((Convert.ToInt32( dateParts[0])>2000 &&Convert.ToInt32(dateParts[1]) < 13 && Convert.ToInt32(dateParts[1]) >0&&  Convert.ToInt32(dateParts[2]) <32 && Convert.ToInt32(dateParts[2]) > 0)||
               (Convert.ToInt32(dateParts[2]) > 2000 && Convert.ToInt32(dateParts[1]) < 13 && Convert.ToInt32(dateParts[1]) > 0 && Convert.ToInt32(dateParts[0]) < 32 && Convert.ToInt32(dateParts[0]) > 0))
            {
                return true;
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (txtCompanyName.Text=="")
                {
                    MessageBox.Show("يجب أن تسجل أسم الشركة الموردة");
                    return;
                }
                setRowsThatEffected();
              
                if(dateError)
                {
                    MessageBox.Show("يوجد مشكلة فى التاريخ");
                    rowIndex1.Clear();
                    rowIndex2.Clear();
                    rowIndex3.Clear();
                    rowIndex4.Clear();
                    rowIndex5.Clear();
                    rowIndex6.Clear();
                    rowIndex7.Clear();
                    rowIndex8.Clear();
                    dateError = false;
                    return;
                }
                for (int i = 0; i < rowIndex1.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug1.Rows[rowIndex1[i]];
                    addImportedDrug(dr);
            
                    updateDrugStore(dr);
                }
                for (int i = 0; i < rowIndex2.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug2.Rows[rowIndex2[i]];
                    addImportedDrug(dr);
                    updateDrugStore(dr);
                }
                for (int i = 0; i < rowIndex3.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug3.Rows[rowIndex3[i]];
                    addImportedDrug(dr);
    
                    updateDrugStore(dr);
                }
                for (int i = 0; i < rowIndex4.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug4.Rows[rowIndex4[i]];
                    addImportedDrug(dr);
    
                    updateDrugStore(dr);
                }
                for (int i = 0; i < rowIndex5.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug5.Rows[rowIndex5[i]];
                    addImportedDrug(dr);
            
                    updateDrugStore(dr);
                }
                for (int i = 0; i < rowIndex6.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug6.Rows[rowIndex6[i]];
                    addImportedDrug(dr);
       
                    updateDrugStore(dr);
                }
                for (int i = 0; i < rowIndex7.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug7.Rows[rowIndex7[i]];
                    addImportedDrug(dr);

                    updateDrugStore(dr);
                }
                for (int i = 0; i < rowIndex8.Count; i++)
                {
                    DataGridViewRow dr = dgvDrug8.Rows[rowIndex8[i]];
                    addImportedDrug(dr);

                    updateDrugStore(dr);
                }
                if ((rowIndex1.Count + rowIndex2.Count + rowIndex3.Count + rowIndex4.Count + rowIndex5.Count + rowIndex6.Count + rowIndex7.Count + rowIndex8.Count) == 0)
                {
                    MessageBox.Show("لم يتم ادخال بيانات");
                    return;
                }

                MessageBox.Show("تم الحفظ");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد مشكلة كالاًتى: " + ex.Message);
            }


        }

        private void setRowsThatEffected()
        {
            string expireDate = "";
            for (int i = 0; i < dgvDrug1.Rows.Count; i++)
            {
                if(Convert.ToInt32( dgvDrug1.Rows[i].Cells[4].Value.ToString())>0)
                {
                    rowIndex1.Add(i);
                }
               
            }
            for (int i = 0; i < dgvDrug2.Rows.Count; i++)
            {
                
                if (Convert.ToInt32(dgvDrug2.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    rowIndex2.Add(i);
                }
            }
            for (int i = 0; i < dgvDrug3.Rows.Count; i++)
            {
               
                if (Convert.ToInt32(dgvDrug3.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    rowIndex3.Add(i);
                }
            }
            for (int i = 0; i < dgvDrug4.Rows.Count; i++)
            {
                
                if (Convert.ToInt32(dgvDrug4.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    rowIndex4.Add(i);
                }
            }
            for (int i = 0; i < dgvDrug5.Rows.Count; i++)
            {
               
                if (Convert.ToInt32(dgvDrug5.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    rowIndex5.Add(i);
                }
            }
            for (int i = 0; i < dgvDrug6.Rows.Count; i++)
            {
              
                if (Convert.ToInt32(dgvDrug6.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    rowIndex6.Add(i);
                }
            }
            for (int i = 0; i < dgvDrug7.Rows.Count; i++)
            {
               
                if (Convert.ToInt32(dgvDrug7.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    rowIndex7.Add(i);
                }
            }
            for (int i = 0; i < dgvDrug8.Rows.Count; i++)
            {
               
                if (Convert.ToInt32(dgvDrug8.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    rowIndex8.Add(i);
                }
            }
            for (int i = 0; i < rowIndex1.Count; i++)
            {
                expireDate = dgvDrug1.Rows[rowIndex1[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }
            
            }
            for (int i = 0; i < rowIndex2.Count; i++)
            {
                expireDate = dgvDrug2.Rows[rowIndex2[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }

            }
            for (int i = 0; i < rowIndex3.Count; i++)
            {
                expireDate = dgvDrug3.Rows[rowIndex3[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }

            }
            for (int i = 0; i < rowIndex4.Count; i++)
            {
                expireDate = dgvDrug4.Rows[rowIndex4[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }

            }
            for (int i = 0; i < rowIndex5.Count; i++)
            {
                expireDate = dgvDrug5.Rows[rowIndex5[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }

            }
            for (int i = 0; i < rowIndex6.Count; i++)
            {
                expireDate = dgvDrug6.Rows[rowIndex6[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }

            }
            for (int i = 0; i < rowIndex7.Count; i++)
            {
                expireDate = dgvDrug7.Rows[rowIndex7[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }

            }
            for (int i = 0; i < rowIndex8.Count; i++)
            {
                expireDate = dgvDrug8.Rows[rowIndex8[i]].Cells[3].Value.ToString();
                if (expireDate == "")
                {
                    dateError = true;
                    return;
                }
                expireDate = replaceFN(expireDate);
                if (!checkDate(expireDate))
                {

                    dateError = true;
                    return;
                }

            }

        }

        private void dgvDrugImport_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (e.ColumnIndex == 3) return;
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
            }
            

        }

        private void dgvDrugImport8_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 7)
            {
                return;
            }
            int impotedQuant = Convert.ToInt32(dgvDrug8.Rows[e.RowIndex].Cells[7].Value);
            if (impotedQuant > 0)
            {
                int storeQuant = Convert.ToInt32(dgvDrug8.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug8.Rows[e.RowIndex].Cells[3].Value = storeQuant - impotedQuant;
            }
        }
        private void dgvDrugImport8_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool isDate = false;
        private void dgvDrugImport8_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int colIndex = ((DataGridView)sender).CurrentCell.ColumnIndex;
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (colIndex == 3)
            {
                isDate = true;
            }
            else
                isDate = false;
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isDate)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
                {
                    if (e.KeyChar == '-' || e.KeyChar == '/') return;
                        e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        
        }

        private void dgvDrugImport1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvDrugImport1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDrugImport2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvDrugImport2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDrugImport3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvDrugImport3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDrugImport4_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 7)
            {
                return;
            }
            int impotedQuant = Convert.ToInt32(dgvDrug4.Rows[e.RowIndex].Cells[7].Value);
            if (impotedQuant > 0)
            {
                int storeQuant = Convert.ToInt32(dgvDrug4.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug4.Rows[e.RowIndex].Cells[3].Value = storeQuant - impotedQuant;
            }

        }

        private void dgvDrugImport4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDrugImport5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 7)
            {
                return;
            }
            int impotedQuant = Convert.ToInt32(dgvDrug5.Rows[e.RowIndex].Cells[7].Value);
            if (impotedQuant > 0)
            {
                int storeQuant = Convert.ToInt32(dgvDrug5.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug5.Rows[e.RowIndex].Cells[3].Value = storeQuant - impotedQuant;
            }

        }

        private void dgvDrugImport5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDrugImport6_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 7)
            {
                return;
            }
            int impotedQuant = Convert.ToInt32(dgvDrug6.Rows[e.RowIndex].Cells[7].Value);
            if (impotedQuant > 0)
            {
                int storeQuant = Convert.ToInt32(dgvDrug6.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug6.Rows[e.RowIndex].Cells[3].Value = storeQuant - impotedQuant;
            }

        }

        private void dgvDrugImport6_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDrugImport7_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 7)
            {
                return;
            }
            int impotedQuant = Convert.ToInt32(dgvDrug7.Rows[e.RowIndex].Cells[7].Value);
            if (impotedQuant > 0)
            {
                int storeQuant = Convert.ToInt32(dgvDrug7.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvDrug7.Rows[e.RowIndex].Cells[3].Value = storeQuant - impotedQuant;
            }

        }

        private void dgvDrugImport7_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool firstLoad = true;
        private void ImportDrugs_Resize(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvDrug8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
