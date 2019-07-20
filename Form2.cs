using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

       

       

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            MessageBox.Show("drop down event");
        }
    }
}
