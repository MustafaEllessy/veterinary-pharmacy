using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApplication
{
    public static class ResizeForm
    {
        static public decimal initialFormWidth = 0;
        static public decimal initialFormHeight = 0;
        static public void setControlResult(SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails, SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult)
        {
            foreach (var item in controlsDetails)
            {
                SortedDictionary<string, decimal> values = new SortedDictionary<string, decimal>();
                foreach (var item2 in item.Value)
                {
                    if (item2.Key == "width")
                    {
                        decimal widthPercentage = item2.Value / initialFormWidth;
                        values.Add(item2.Key, widthPercentage);
                    }
                    else if (item2.Key == "height")
                    {
                        decimal heightPercentage = item2.Value / initialFormHeight;
                        values.Add(item2.Key, heightPercentage);
                    }
                    else if (item2.Key == "x")
                    {
                        decimal xPercentage = item2.Value / initialFormWidth;
                        values.Add(item2.Key, xPercentage);
                    }
                    else if (item2.Key == "y")
                    {
                        decimal yPercentage = item2.Value / initialFormHeight;
                        values.Add(item2.Key, yPercentage);
                    }
                }
                string controlName = item.Key;

                controlsResult.Add(controlName, values);
            }
        }
        static public void setContolDetails(Control control, SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails)
        {
            if (!control.HasChildren)
            {
                return;
            }
            foreach (Control c in control.Controls)
            {
                SortedDictionary<string, decimal> item = new SortedDictionary<string, decimal>();
                item.Add("width", c.Width);
                item.Add("height", c.Height);
                item.Add("x", c.Location.X);
                item.Add("y", c.Location.Y);
                controlsDetails.Add(c.Name, item);
            }
        }
        static public void changeControls(Form frm, SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult)
        {
            foreach (var item in controlsResult)
            {
                Control c = frm.Controls.Find(item.Key, true).FirstOrDefault();
                List<int> targetValues = new List<int>();
                int newWidth = 0, newHeight = 0, newX = 0, newY = 0;
                foreach (var item2 in item.Value)
                {
                    if (item2.Key == "width")
                    {
                        newWidth = Convert.ToInt32(item2.Value * frm.Width);
                    }
                    else if (item2.Key == "height")
                    {
                        newHeight = Convert.ToInt32(item2.Value * frm.Height);
                    }
                    else if (item2.Key == "x")
                    {
                        newX = Convert.ToInt32(item2.Value * frm.Width);
                    }
                    else if (item2.Key == "y")
                    {
                        newY = Convert.ToInt32(item2.Value * frm.Height);
                    }
                }
                c.Width = newWidth;
                c.Height = newHeight;
                c.Location = new System.Drawing.Point(newX, newY);
            }
        }
    }
}
