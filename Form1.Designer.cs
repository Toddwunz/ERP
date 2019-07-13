using System.Windows.Forms;

namespace ERP
{
    partial class Form1
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
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalLab = new System.Windows.Forms.Label();
            this.Ltotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BalanceBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalLab2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.costFillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ERPprintDocument = new System.Drawing.Printing.PrintDocument();
            this.ERPprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(149, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new System.DateTime(2019, 7, 13, 23, 38, 10, 487);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalLab);
            this.groupBox1.Controls.Add(this.Ltotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash Calculation";
            // 
            // TotalLab
            // 
            this.TotalLab.AutoSize = true;
            this.TotalLab.Location = new System.Drawing.Point(60, 398);
            this.TotalLab.Name = "TotalLab";
            this.TotalLab.Size = new System.Drawing.Size(0, 13);
            this.TotalLab.TabIndex = 1;
            // 
            // Ltotal
            // 
            this.Ltotal.AutoSize = true;
            this.Ltotal.Location = new System.Drawing.Point(7, 398);
            this.Ltotal.Name = "Ltotal";
            this.Ltotal.Size = new System.Drawing.Size(34, 13);
            this.Ltotal.TabIndex = 0;
            this.Ltotal.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // BalanceBtn
            // 
            this.BalanceBtn.Location = new System.Drawing.Point(399, 473);
            this.BalanceBtn.Name = "BalanceBtn";
            this.BalanceBtn.Size = new System.Drawing.Size(75, 23);
            this.BalanceBtn.TabIndex = 2;
            this.BalanceBtn.Text = "Balence";
            this.BalanceBtn.UseVisualStyleBackColor = true;
            this.BalanceBtn.Click += new System.EventHandler(this.BalanceBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalLab2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox9);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.comboBox7);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(210, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 423);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Calculation";
            // 
            // TotalLab2
            // 
            this.TotalLab2.AutoSize = true;
            this.TotalLab2.Location = new System.Drawing.Point(46, 398);
            this.TotalLab2.Name = "TotalLab2";
            this.TotalLab2.Size = new System.Drawing.Size(0, 13);
            this.TotalLab2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total:";
            // 
            // comboBox9
            // 
            this.comboBox9.Location = new System.Drawing.Point(189, 372);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(155, 21);
            this.comboBox9.TabIndex = 27;
            // 
            // comboBox8
            // 
            this.comboBox8.Location = new System.Drawing.Point(189, 330);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(155, 21);
            this.comboBox8.TabIndex = 26;
            // 
            // comboBox7
            // 
            this.comboBox7.Location = new System.Drawing.Point(189, 288);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(155, 21);
            this.comboBox7.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(48, 373);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(106, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(48, 331);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(106, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(48, 289);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(106, 20);
            this.textBox7.TabIndex = 16;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // comboBox6
            // 
            this.comboBox6.Location = new System.Drawing.Point(189, 245);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(155, 21);
            this.comboBox6.TabIndex = 24;
            // 
            // comboBox5
            // 
            this.comboBox5.Location = new System.Drawing.Point(189, 203);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(155, 21);
            this.comboBox5.TabIndex = 23;
            // 
            // comboBox4
            // 
            this.comboBox4.Location = new System.Drawing.Point(189, 161);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(155, 21);
            this.comboBox4.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.Location = new System.Drawing.Point(189, 122);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(155, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(48, 246);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(106, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(48, 204);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(48, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(189, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cost Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            " Balance of yesterday"});
            this.comboBox1.Location = new System.Drawing.Point(189, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // costFillToolStripButton
            // 
            this.costFillToolStripButton.Name = "costFillToolStripButton";
            this.costFillToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "应剩:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "-----------------------------------------------------------------";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(dateTimePicker1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(603, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 413);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Print view";
            // 
            // ERPprintPreviewDialog
            // 
            this.ERPprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ERPprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ERPprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ERPprintPreviewDialog.Enabled = true;
            this.ERPprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ERPprintPreviewDialog.Icon")));
            this.ERPprintPreviewDialog.Name = "ERPprintPreviewDialog";
            this.ERPprintPreviewDialog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BalanceBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TotalLab;
        private System.Windows.Forms.Label Ltotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BalanceBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ToolStripButton costFillToolStripButton;
        private Label label3;
        private Label TotalLab2;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private System.Drawing.Printing.PrintDocument ERPprintDocument;
        private PrintPreviewDialog ERPprintPreviewDialog;
    }
}

