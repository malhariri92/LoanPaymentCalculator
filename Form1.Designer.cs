namespace Exercise_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.purchasePriceBox = new System.Windows.Forms.TextBox();
            this.downBox = new System.Windows.Forms.TextBox();
            this.interestBox = new System.Windows.Forms.TextBox();
            this.termBox = new System.Windows.Forms.TextBox();
            this.financeAmountBox = new System.Windows.Forms.TextBox();
            this.monthlyPaymentBox = new System.Windows.Forms.TextBox();
            this.calBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(87, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Purchase Price:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Down Payment Amount:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate (annual):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loan Term (months):";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount to Finance:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monthly Payment:";
            // 
            // purchasePriceBox
            // 
            this.purchasePriceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.purchasePriceBox.Location = new System.Drawing.Point(194, 110);
            this.purchasePriceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchasePriceBox.Name = "purchasePriceBox";
            this.purchasePriceBox.Size = new System.Drawing.Size(139, 23);
            this.purchasePriceBox.TabIndex = 1;
            this.purchasePriceBox.TextChanged += new System.EventHandler(this.purchasePriceBox_TextChanged);
            // 
            // downBox
            // 
            this.downBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downBox.Location = new System.Drawing.Point(194, 155);
            this.downBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downBox.Name = "downBox";
            this.downBox.Size = new System.Drawing.Size(139, 23);
            this.downBox.TabIndex = 2;
            this.downBox.TextChanged += new System.EventHandler(this.downBox_TextChanged);
            // 
            // interestBox
            // 
            this.interestBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.interestBox.Location = new System.Drawing.Point(194, 200);
            this.interestBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interestBox.Name = "interestBox";
            this.interestBox.Size = new System.Drawing.Size(139, 23);
            this.interestBox.TabIndex = 3;
            this.interestBox.TextChanged += new System.EventHandler(this.interestBox_TextChanged);
            // 
            // termBox
            // 
            this.termBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.termBox.Location = new System.Drawing.Point(194, 245);
            this.termBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(139, 23);
            this.termBox.TabIndex = 4;
            this.termBox.TextChanged += new System.EventHandler(this.termBox_TextChanged);
            // 
            // financeAmountBox
            // 
            this.financeAmountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.financeAmountBox.Location = new System.Drawing.Point(585, 109);
            this.financeAmountBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.financeAmountBox.Name = "financeAmountBox";
            this.financeAmountBox.ReadOnly = true;
            this.financeAmountBox.Size = new System.Drawing.Size(139, 23);
            this.financeAmountBox.TabIndex = 0;
            this.financeAmountBox.TabStop = false;
            // 
            // monthlyPaymentBox
            // 
            this.monthlyPaymentBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthlyPaymentBox.Location = new System.Drawing.Point(585, 154);
            this.monthlyPaymentBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthlyPaymentBox.Name = "monthlyPaymentBox";
            this.monthlyPaymentBox.ReadOnly = true;
            this.monthlyPaymentBox.Size = new System.Drawing.Size(139, 23);
            this.monthlyPaymentBox.TabIndex = 0;
            this.monthlyPaymentBox.TabStop = false;
            // 
            // calBtn
            // 
            this.calBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.calBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calBtn.Location = new System.Drawing.Point(194, 318);
            this.calBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(116, 26);
            this.calBtn.TabIndex = 5;
            this.calBtn.Text = "Calculate";
            this.calBtn.UseVisualStyleBackColor = false;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(585, 318);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(116, 26);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(842, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.monthlyPaymentBox);
            this.Controls.Add(this.financeAmountBox);
            this.Controls.Add(this.termBox);
            this.Controls.Add(this.interestBox);
            this.Controls.Add(this.downBox);
            this.Controls.Add(this.purchasePriceBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(858, 409);
            this.MinimumSize = new System.Drawing.Size(858, 409);
            this.Name = "Form1";
            this.Text = "Monthly Payment Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox purchasePriceBox;
        private System.Windows.Forms.TextBox downBox;
        private System.Windows.Forms.TextBox interestBox;
        private System.Windows.Forms.TextBox termBox;
        private System.Windows.Forms.TextBox financeAmountBox;
        private System.Windows.Forms.TextBox monthlyPaymentBox;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

