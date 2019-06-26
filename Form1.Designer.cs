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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalLab = new System.Windows.Forms.Label();
            this.Ltotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BalanceBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalLab);
            this.groupBox1.Controls.Add(this.Ltotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash Calculation";
            // 
            // TotalLab
            // 
            this.TotalLab.AutoSize = true;
            this.TotalLab.Location = new System.Drawing.Point(59, 395);
            this.TotalLab.Name = "TotalLab";
            this.TotalLab.Size = new System.Drawing.Size(0, 13);
            this.TotalLab.TabIndex = 1;
            // 
            // Ltotal
            // 
            this.Ltotal.AutoSize = true;
            this.Ltotal.Location = new System.Drawing.Point(6, 395);
            this.Ltotal.Name = "Ltotal";
            this.Ltotal.Size = new System.Drawing.Size(34, 13);
            this.Ltotal.TabIndex = 0;
            this.Ltotal.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // BalanceBtn
            // 
            this.BalanceBtn.Location = new System.Drawing.Point(664, 415);
            this.BalanceBtn.Name = "BalanceBtn";
            this.BalanceBtn.Size = new System.Drawing.Size(75, 23);
            this.BalanceBtn.TabIndex = 2;
            this.BalanceBtn.Text = "Balence";
            this.BalanceBtn.UseVisualStyleBackColor = true;
            this.BalanceBtn.Click += new System.EventHandler(this.BalanceBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BalanceBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TotalLab;
        private System.Windows.Forms.Label Ltotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BalanceBtn;
    }
}

