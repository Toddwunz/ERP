using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form2 : Form
    {
        Formatting FmaFloat = new Formatting();
        public Form2()
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
                    if (TBindex == 10) { CoinLabel.Text = "Coin : " + TxtBox.Text; }
                }
            }
            CashLabel.Text = "Cash : " + (Total - FmaFloat.converting(CoinLabel.Text) ).ToString();
            TotalLab.Text = "Total: " + Total.ToString("#0.00");

            float Total2 = 0;
            foreach (Control TxtBox2 in this.groupBox2.Controls)
            {
                if (TxtBox2 is TextBox)
                {
                    if (TxtBox2.Text == "") { TxtBox2.Text = "0"; }
                    //TxtBox2.Text = FmaFloat.converting(TxtBox2.Text).ToString();
                    float Value2 = float.Parse(TxtBox2.Text);
                    Total2 += Value2;
                }
                TotalLab2.Text = "Total: " + Total2.ToString("#0.00");
            }
            GroupBox3filling();
        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 9 && e.KeyChar != 13 && e.KeyChar != '.' && e.KeyChar != '-')
            {
                MessageBox.Show("请输入正确的数字");
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
                labels[i].Location = new System.Drawing.Point(9, 40 + i * 35);
                textBoxes[i].Location = new System.Drawing.Point(40, 40 + i * 35);
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
                ComboBox[] comboxCostType = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10, comboBox11, comboBox12 };

                while (sqlReader.Read())
                {
                    //this.comboBox1.Items.Add(sqlReader["cost_name"].ToString());
                    for (int i = 0; i < comboxCostType.Length; i++)
                    {
                        comboxCostType[i].Items.Add(sqlReader["cost_name"].ToString());
                    }
                }
                sqlReader.Close();
               // this.comboBox1.Items.Add("Balance of yesterday");
               // this.comboBox2.Items.Add("Today Purchese ");
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
            string createdDate = DateTime.Today.ToString("yyyy-MM-dd");
            string sqlTotalQty = "SELECT sum(total_qty) FROM[db_justposrecyc].[dbo].[purchase] where convert(varchar(10),created_date,120)= '" + createdDate + "'";
            string sqlTotalPer = "SELECT count(*) FROM[db_justposrecyc].[dbo].[purchase] where convert(varchar(10),created_date,120)='"+ createdDate + "'";
            TextBox[] txGroup2 = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9,textBox10,textBox11,textBox12 };
            ComboBox[] combGroup2 = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10, comboBox11, comboBox12 };

            int n = 0;
            foreach (Control TxtBox in this.groupBox2.Controls)
            {
                if (TxtBox is TextBox && TxtBox.Text != "0")
                {
                    n += 1;
                }
            }

            List<Label> labelG3lst = new List<Label>();
            
            for (int i = 0; i < n; i++)
            {
                Label labelitem = new Label();
                labelG3lst.Add(labelitem);
                labelG3lst[i].Location = new System.Drawing.Point(90, 45 + i * 20);
                labelG3lst[i].Size = new Size(250, 20);
                if (combGroup2[i].Text == "Today Purchase")
                {
                    labelG3lst[i].Text = txGroup2[i].Text + " (" +Controller.DataGeting(sqlTotalQty,0) +"KG, " + Controller.DataGeting(sqlTotalPer,0) + "PP" + ")";
                }
                else
                {
                    labelG3lst[i].Text = txGroup2[i].Text + " (" + combGroup2[i].Text + ")";
                }
                labelG3lst[i].TextAlign = ContentAlignment.MiddleLeft;
                this.groupBox3.Controls.Add(labelG3lst[i]);
            }
            string _line = "-----------------------------------------------------------------------------------------------------------";
            string _shortline = "-------------------------------------------------";

            float theoryMoney = FmaFloat.converting(TotalLab2.Text);
            float realMoney = FmaFloat.converting(TotalLab.Text);
            float blnResult = realMoney - theoryMoney;
            string ysdiffsql = "select top 1 difference from dailyBalance order by id desc";
            float ysDiff =float.Parse(Controller.DataGeting(ysdiffsql,0));
            float toDiff = blnResult - ysDiff;

            List<string> valuelst = new List<string>() { _line,TotalLab2.Text, "实剩",_line,CashLabel.Text,CoinLabel.Text, _shortline, realMoney.ToString("#0.00"), "-" + theoryMoney.ToString("#0.00"), _shortline, blnResult.ToString("#0.00"),"-(" + ysDiff.ToString("#0.00") + ")",_shortline,toDiff.ToString("#0.00") };

            for (int i = 0; i < valuelst.Count(); i++)
            {
                Label G3LabelTotal = new Label();
                labelG3lst.Add(G3LabelTotal);
                int m = labelG3lst.Count() - 1;
                labelG3lst[m].Location = new System.Drawing.Point(13, 45 + m * 20);
                labelG3lst[m].Size = new Size(333, 20);
                labelG3lst[m].Text = valuelst[i];
                if (labelG3lst[m].Text == "实剩")
                {
                    labelG3lst[m].TextAlign = ContentAlignment.TopLeft;
                }
                else
                {
                  labelG3lst[m].TextAlign = ContentAlignment.MiddleCenter;
                }
                this.groupBox3.Controls.Add(labelG3lst[m]);
            }

                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ComboBoxFilling();
            BlnInitializing();

        }

        private void BtnPrintPreview_Click(object sender, EventArgs e)
        {
            ERPprintPreviewDialog.Document = ERPprintDocument;
            ERPprintPreviewDialog.ShowDialog();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //ERPprintDocument.Print();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog
            {
                Document = doc
            };
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                ComboxNewItemCreating();
                DatabaseUpdate();
                doc.Print();
            }
        }

         private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.groupBox3.Width + this.groupBox1.Width, this.groupBox3.Height);
            this.groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            this.groupBox3.DrawToBitmap(bmp, new Rectangle(this.groupBox1.Width, 0, this.groupBox1.Width + this.groupBox3.Width, this.groupBox3.Height));
            e.Graphics.DrawImage((Image)bmp, e.PageBounds);
        }

        private void ComboxNewItemCreating()
        {
            foreach (Control combox in this.groupBox2.Controls)
            {
                if (combox is ComboBox)
                {
                    string costName = combox.Text;
                    string sqlstr = "select * from dbo.cost_class where cost_name='" + costName + "'";
                    if (Controller.DataGeting(sqlstr, 1) == "Empty")
                    {
                        Controller.DataInsert("INSERT INTO dbo.cost_class (cost_name) VALUES ('" + combox.Text + "')");
                    }
                }
            }
        }

        private void DatabaseUpdate()
        {
            // dailyBalance Table update
            float rMoney = FmaFloat.converting(TotalLab.Text);
            float tMoney = FmaFloat.converting(TotalLab2.Text);
            float diff = rMoney - tMoney;
            string createdDate = DateTime.Today.ToString("yyyy-MM-dd");
            string sqlBalance = "INSERT INTO dbo.dailyBalance(theoryMoney,realMoney,difference,balanceDate) VALUES('" + tMoney +"','" + rMoney + "','" + diff + "','" + createdDate +"')";
            string sqlstr = "select id from dbo.dailyBalance where convert(varchar(10),balanceDate,120)= '" + createdDate + "'";
            if (Controller.DataGeting(sqlstr, 0) == "Empty")
            {
                Controller.DataInsert(sqlBalance);
            }
            //Cost Table update
            TextBox[] txGroup2 = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9,textBox10,textBox11,textBox12 };
            ComboBox[] combGroup2 = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9,comboBox10,comboBox11,comboBox12 };
            for (int i = 0; i < txGroup2.Length; i++)
            {
                if (txGroup2[i].Text != "0")
                {
                    string sqlQurycost = "Select * from dbo.cost where cost_name = '"+ combGroup2[i].Text + "' and date='" + createdDate + "'";
                    if (Controller.DataGeting(sqlQurycost, 0) == "Empty")
                    {
                        string sqlInsertCost = "INSERT INTO dbo.cost(cost_amount,cost_name,date) VALUES('" + float.Parse(txGroup2[i].Text) + "','" + combGroup2[i].Text + "','" + createdDate + "')";
                        Controller.DataInsert(sqlInsertCost);
                    }
                }
            }

        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            BlnInitializing();
        }

        private void BlnInitializing()
        {
            this.dateTimeLable.Text = DateTime.Today.ToString("D");
            string createdDate = DateTime.Today.ToString("yyyy-MM-dd");
            //yesterday balance initialization
            string yesBalancesql = "select top 1 [theoryMoney] from dbo.dailyBalance where convert(varchar(10),balanceDate,120)<'" + createdDate + "'order by id desc";
            this.textBox1.Text = Controller.DataGeting(yesBalancesql, 0);
            // Today total purchase initialization
            string tdtotalsql = "SELECT sum(total) as Total FROM dbo.purchase where convert(varchar(10),created_date,120)= '" + createdDate + "'";
            string result = Controller.DataGeting(tdtotalsql, 0);
            if (result == "")
            {
                this.textBox2.Text = "0";
            }
            else
            {
                this.textBox2.Text = ("-" + Controller.DataGeting(tdtotalsql, 0)).ToString();
            }
            
        }

    }
}
