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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int n = 9;
            TextBox[] textBoxes = new TextBox[n];
            Label[] labels = new Label[n];
            String[] strnotes = new string[] { "100", "50", "20", "10", "5", "2", "1", "50c", "20c", "10c"};
            for (int i = 0; i < n; i++)
            {
                labels[i] = new Label();
                textBoxes[i] = new TextBox();
                labels[i].Parent = groupBox1;
                textBoxes[i].Parent = groupBox1;
                labels[i].Location = new System.Drawing.Point(9, 20+i*40);
                textBoxes[i].Location = new System.Drawing.Point(40, 20+i*40);
                labels[i].Size = new Size(30, 20);
                textBoxes[i].Size = new Size(100, 20);
                labels[i].Text = strnotes[i];
                textBoxes[i].Text = "";
                textBoxes[i].TabIndex = i;
                textBoxes[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
                this.groupBox1.Controls.Add(textBoxes[i]);
                this.groupBox1.Controls.Add(labels[i]);
            }

        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            float[] notes = { 100f, 50f, 20f, 10f, 5f, 2f, 1f, 0.5f, 0.2f, 0.1f };
            float Total = 0;
            foreach (Control TxtBox in this.groupBox1.Controls)
            {
                if (TxtBox is TextBox)
                {
                    if (TxtBox.Text == "") { TxtBox.Text = "0"; }
                    float Value = float.Parse(TxtBox.Text);
                    int TBindex = TxtBox.TabIndex;
                    Total += Value * notes[TBindex];
                }
                TotalLab.Text = Total.ToString();
            }

        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 9 && e.KeyChar != 13)
            {
                MessageBox.Show("请输入正确的数字");
                this.textBox1.Text = "";
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }

        }

    }
}
