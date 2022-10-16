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
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.Dock = DockStyle.Fill;
            this.reportViewer2.RefreshReport();
        }
    }
}
