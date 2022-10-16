namespace formApplication
{
    partial class DisplayExportDrugs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExportedDrugs = new System.Windows.Forms.DataGridView();
            this.colExportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportedDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExportedDrugs
            // 
            this.dgvExportedDrugs.AllowUserToAddRows = false;
            this.dgvExportedDrugs.AllowUserToDeleteRows = false;
            this.dgvExportedDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExportedDrugs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExportedDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExportedDrugs.ColumnHeadersHeight = 50;
            this.dgvExportedDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExportedDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExportDate,
            this.colStationType,
            this.colStationName,
            this.colDrugName,
            this.colExpireDate,
            this.colUnit,
            this.colQuantity,
            this.colDoctorName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExportedDrugs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExportedDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExportedDrugs.EnableHeadersVisualStyles = false;
            this.dgvExportedDrugs.Location = new System.Drawing.Point(0, 0);
            this.dgvExportedDrugs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExportedDrugs.MultiSelect = false;
            this.dgvExportedDrugs.Name = "dgvExportedDrugs";
            this.dgvExportedDrugs.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExportedDrugs.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExportedDrugs.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExportedDrugs.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExportedDrugs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvExportedDrugs.RowTemplate.Height = 60;
            this.dgvExportedDrugs.Size = new System.Drawing.Size(1285, 674);
            this.dgvExportedDrugs.TabIndex = 6;
            this.dgvExportedDrugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitors_CellContentClick);
            // 
            // colExportDate
            // 
            this.colExportDate.DataPropertyName = "exportDate";
            dataGridViewCellStyle2.Format = "D";
            this.colExportDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colExportDate.HeaderText = "تاريخ التصدير";
            this.colExportDate.MinimumWidth = 6;
            this.colExportDate.Name = "colExportDate";
            this.colExportDate.ReadOnly = true;
            this.colExportDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colStationType
            // 
            this.colStationType.DataPropertyName = "stationType";
            this.colStationType.FillWeight = 90F;
            this.colStationType.HeaderText = "نوع المحطة";
            this.colStationType.MinimumWidth = 6;
            this.colStationType.Name = "colStationType";
            this.colStationType.ReadOnly = true;
            this.colStationType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStationType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStationName
            // 
            this.colStationName.DataPropertyName = "stationName";
            this.colStationName.FillWeight = 90F;
            this.colStationName.HeaderText = "اسم المحطة";
            this.colStationName.MinimumWidth = 6;
            this.colStationName.Name = "colStationName";
            this.colStationName.ReadOnly = true;
            this.colStationName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStationName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDrugName
            // 
            this.colDrugName.DataPropertyName = "drugName";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colDrugName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDrugName.FillWeight = 90F;
            this.colDrugName.HeaderText = "اسم الصنف";
            this.colDrugName.MinimumWidth = 6;
            this.colDrugName.Name = "colDrugName";
            this.colDrugName.ReadOnly = true;
            this.colDrugName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDrugName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colExpireDate
            // 
            this.colExpireDate.DataPropertyName = "expireDate";
            this.colExpireDate.HeaderText = "تاريخ الإنتهاء";
            this.colExpireDate.MinimumWidth = 6;
            this.colExpireDate.Name = "colExpireDate";
            this.colExpireDate.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "unit";
            this.colUnit.FillWeight = 90F;
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.MinimumWidth = 6;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.FillWeight = 90F;
            this.colQuantity.HeaderText = "الكمية";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDoctorName
            // 
            this.colDoctorName.DataPropertyName = "doctorName";
            this.colDoctorName.FillWeight = 90F;
            this.colDoctorName.HeaderText = "اسم الدكتور";
            this.colDoctorName.MinimumWidth = 6;
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.ReadOnly = true;
            // 
            // DisplayExportDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.dgvExportedDrugs);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DisplayExportDrugs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض صادرات الأدوية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExportedDrugsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportedDrugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExportedDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
    }
}