using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form2 : Form
    {
       // Formatting fmtfloat = new Formatting();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            label1.Text = x.ToString("#0.00");
            //label1.Text = Regex.Replace(textBox1.Text, @"[^-?\d.\d]", "");
           // "^[+-] ?\d *[.] ?\d *$"
          
        }
    }
}
