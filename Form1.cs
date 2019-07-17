using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            Groupbox1Generating(11);
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            float[] notes = { 100f, 50f, 20f, 10f, 5f, 2f, 1f, 0.5f, 0.2f, 0.1f, 1f };
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

            float Total2 = 0;
            foreach (Control TxtBox2 in this.groupBox2.Controls)
            {
                if (TxtBox2 is TextBox)
                {
                    if (TxtBox2.Text == "") { TxtBox2.Text = "0"; }
                    float Value2 = float.Parse(TxtBox2.Text);
                    Total2 += Value2;
                }
                TotalLab2.Text = Total2.ToString();
            }

            GroupBox3filling();
        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 9 && e.KeyChar != 13 && e.KeyChar != '.' && e.KeyChar != '-')
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

        public void Groupbox1Generating(int n)
        {
            TextBox[] textBoxes = new TextBox[n];
            Label[] labels = new Label[n];
            String[] strnotes = new string[] { "100", "50", "20", "10", "5", "2", "1", "50c", "20c", "10c", "Coin" };
            for (int i = 0; i < n; i++)
            {
                labels[i] = new Label();
                textBoxes[i] = new TextBox();
                labels[i].Parent = groupBox1;
                textBoxes[i].Parent = groupBox1;
                labels[i].Location = new System.Drawing.Point(9, 20 + i * 35);
                textBoxes[i].Location = new System.Drawing.Point(40, 20 + i * 35);
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

        public void ComboBoxFilling()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ERPDB"].ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.cost_class", connection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                ComboBox[] comboxCostType = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9 };

                while (sqlReader.Read())
                {
                    //this.comboBox1.Items.Add(sqlReader["cost_name"].ToString());
                    for (int i = 0; i < comboxCostType.Length; i++)
                    {
                        comboxCostType[i].Items.Add(sqlReader["cost_name"].ToString());
                    }
                }
                sqlReader.Close();
                this.comboBox1.Items.Add("Balance of yesterday");
                this.comboBox2.Items.Add("Today Purchese ");
                for (int i = 0; i < comboxCostType.Length; i++)
                {
                    comboxCostType[i].DisplayMember = "cost_name";
                    comboxCostType[i].SelectedValue = "cost_name";
                    comboxCostType[i].SelectedIndex = i;
                }
            }
        }

        public void GroupBox3filling()
        {
            
            this.groupBox3.Controls.Clear();
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimeLable);
            string sqlTotalQty = "SELECT sum(total_qty) FROM[db_justposrecyc].[dbo].[purchase] where convert(varchar(10),created_date,120)= '2019-05-11'";
            string sqlTotalPer = "SELECT count(*) FROM[db_justposrecyc].[dbo].[purchase] where convert(varchar(10),created_date,120)='2019-05-11'";
            int n = 2;
            TextBox[] txGroup2 = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            ComboBox[] combGroup2 = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9 };
            Label[] labelGroup3 = new Label[n];

            foreach (Control TxtBox in this.groupBox2.Controls)
            {
                if (TxtBox is TextBox && TxtBox.Text != "0")
                {
                    n += 1;
                }
            }
            
            for (int i = 0; i < n-1; i++)
            {
                labelGroup3[i] = new Label();
                if (i == n - 1)
                {
                    labelGroup3[i].Location = new System.Drawing.Point(13, 80 + i * 25);
                    labelGroup3[i].Size = new Size(333, 25);
                    labelGroup3[i].Text = "-------------------------------------------------------------------------------------------------------------------------";
                    this.groupBox3.Controls.Add(labelGroup3[i]);
                }
                else
                {
                    labelGroup3[i].Location = new System.Drawing.Point(90, 80 + i * 25);
                    labelGroup3[i].Size = new Size(250, 25);
                    if (i == 1)
                    {
                        labelGroup3[i].Text = txGroup2[i].Text + " (" +Controller.DataGeting(sqlTotalQty) +"KG, " + Controller.DataGeting(sqlTotalPer) + "PP" + ")";
                    }
                    else
                    {
                        labelGroup3[i].Text = txGroup2[i].Text + " (" + combGroup2[i].SelectedItem + ")";
                    }
                    this.groupBox3.Controls.Add(labelGroup3[i]);
                }
            }
            int m = labelGroup3.Length;
           // dateTimeLable.p = labelGroup3[m - 1].Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_justposrecycDataSet.cost_class' table. You can move, or remove it, as needed.
            ComboBoxFilling();
            this.dateTimeLable.Text = DateTime.Today.ToString("D");
            // DataBase data collecting 
            string connectionString = ConfigurationManager.ConnectionStrings["ERPDB"].ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand sqlCmd = new SqlCommand("SELECT sum(total) as Total FROM [db_justposrecyc].[dbo].[purchase] where convert(varchar(10),created_date,120)='2019-05-11';", connection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                    this.textBox2.Text = "-" + sqlReader["Total"].ToString();
                sqlReader.Close();
            }
        }
    }
}
