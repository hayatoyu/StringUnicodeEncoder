using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringUnicodeEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ToUnicode_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(rtb_Origin.Text))
            {
                byte[] b = Encoding.Unicode.GetBytes(rtb_Origin.Text);

                try
                {
                    // Little Endian and PadLeft
                    for (int i = 0; i < b.Length; i += 2)
                    {
                        result += "\\u" + String.Format("{00:X}", b[i + 1]).PadLeft(2,'0') + String.Format("{00:X}", b[i]).PadLeft(2,'0');
                    }
                }
                catch(Exception ex)
                {
                    result = ex.Message;
                }
                
            }
            rtb_Result.Text = result;
        }

        private void btn_ToString_Click(object sender, EventArgs e)
        {
            string dst = string.Empty;
            string[] arr = rtb_Origin.Text.Replace("u", string.Empty).Split('\\');
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!string.IsNullOrEmpty(arr[i]))
                    {
                        // Little Endian
                        byte[] b = new byte[2];
                        b[1] = Convert.ToByte(arr[i].Substring(0, 2), 16);
                        b[0] = Convert.ToByte(arr[i].Substring(2, 2), 16);
                        dst += Encoding.Unicode.GetString(b);
                    }
                }
            }
            catch (Exception ex)
            {
                dst = ex.Message;
            }
            rtb_Result.Text = dst;
        }
    }
}
