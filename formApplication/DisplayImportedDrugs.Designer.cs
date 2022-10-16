namespace formApplication
{
    partial class DisplayImportedDrugs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvImportedDrugs = new System.Windows.Forms.DataGridView();
            this.colImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImportedDrugs
            // 
            this.dgvImportedDrugs.AllowUserToAddRows = false;
            this.dgvImportedDrugs.AllowUserToDeleteRows = false;
            this.dgvImportedDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportedDrugs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportedDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportedDrugs.ColumnHeadersHeight = 70;
            this.dgvImportedDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvImportedDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImportDate,
            this.colCompanyName,
            this.colDrugName,
            this.colExpireDate,
            this.colPrice,
            this.colUnit,
            this.colQuantity});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportedDrugs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvImportedDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportedDrugs.EnableHeadersVisualStyles = false;
            this.dgvImportedDrugs.Location = new System.Drawing.Point(0, 0);
            this.dgvImportedDrugs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvImportedDrugs.MultiSelect = false;
            this.dgvImportedDrugs.Name = "dgvImportedDrugs";
            this.dgvImportedDrugs.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportedDrugs.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvImportedDrugs.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportedDrugs.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvImportedDrugs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvImportedDrugs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportedDrugs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvImportedDrugs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dgvImportedDrugs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvImportedDrugs.RowTemplate.Height = 50;
            this.dgvImportedDrugs.Size = new System.Drawing.Size(1285, 674);
            this.dgvImportedDrugs.TabIndex = 57;
            // 
            // colImportDate
            // 
            this.colImportDate.DataPropertyName = "importDate";
            dataGridViewCellStyle2.Format = "D";
            this.colImportDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colImportDate.HeaderText = "تاريخ التوريد";
            this.colImportDate.MinimumWidth = 6;
            this.colImportDate.Name = "colImportDate";
            this.colImportDate.ReadOnly = true;
            this.colImportDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colImportDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "companyName";
            this.colCompanyName.HeaderText = "الشركة الموردة";
            this.colCompanyName.MinimumWidth = 6;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colDrugName
            // 
            this.colDrugName.DataPropertyName = "drugName";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colDrugName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDrugName.FillWeight = 110F;
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
            dataGridViewCellStyle4.Format = "D";
            this.colExpireDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colExpireDate.HeaderText = "تاريخ الإنتهاء";
            this.colExpireDate.MinimumWidth = 6;
            this.colExpireDate.Name = "colExpireDate";
            this.colExpireDate.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPrice.FillWeight = 70F;
            this.colPrice.HeaderText = "سعر الصنف";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "unit";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle6;
            this.colUnit.FillWeight = 70F;
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
            this.colQuantity.FillWeight = 70F;
            this.colQuantity.HeaderText = "الكمية";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DisplayImportedDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.dgvImportedDrugs);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DisplayImportedDrugs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض واردت الأدوية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImportedDrugsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedDrugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportedDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    }
}