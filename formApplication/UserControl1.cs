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
    public partial class closeTool : UserControl
    {
        public closeTool()
        {
            InitializeComponent();
        }

        private void closeTool_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          this.ParentForm.Close();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {

            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.Red;
        }

        private void closeTool_Resize(object sender, EventArgs e)
        {
            btnClose.Size = new System.Drawing.Size(Size.Width, Size.Height);
        }
    }
}
