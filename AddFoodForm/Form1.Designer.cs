namespace AddFoodForm
{
    partial class AddFoodForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitBtn = new System.Windows.Forms.Button();
            this.describingRichTb = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfPackagingTb = new System.Windows.Forms.TextBox();
            this.countryTb = new System.Windows.Forms.TextBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfExpiration = new System.Windows.Forms.Label();
            this.measureUnitTb = new System.Windows.Forms.TextBox();
            this.countTb = new System.Windows.Forms.TextBox();
            this.expirationDateTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(403, 398);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(130, 26);
            this.submitBtn.TabIndex = 28;
            this.submitBtn.Text = "Add";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // describingRichTb
            // 
            this.describingRichTb.Location = new System.Drawing.Point(168, 197);
            this.describingRichTb.Name = "describingRichTb";
            this.describingRichTb.Size = new System.Drawing.Size(291, 181);
            this.describingRichTb.TabIndex = 27;
            this.describingRichTb.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Describing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date of packaging";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // dateOfPackagingTb
            // 
            this.dateOfPackagingTb.Location = new System.Drawing.Point(168, 150);
            this.dateOfPackagingTb.Name = "dateOfPackagingTb";
            this.dateOfPackagingTb.Size = new System.Drawing.Size(100, 23);
            this.dateOfPackagingTb.TabIndex = 21;
            // 
            // countryTb
            // 
            this.countryTb.Location = new System.Drawing.Point(168, 105);
            this.countryTb.Name = "countryTb";
            this.countryTb.Size = new System.Drawing.Size(216, 23);
            this.countryTb.TabIndex = 20;
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(168, 61);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(100, 23);
            this.priceTb.TabIndex = 19;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(168, 17);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(216, 23);
            this.nameTb.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Measure unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Count";
            // 
            // dateOfExpiration
            // 
            this.dateOfExpiration.AutoSize = true;
            this.dateOfExpiration.Location = new System.Drawing.Point(467, 20);
            this.dateOfExpiration.Name = "dateOfExpiration";
            this.dateOfExpiration.Size = new System.Drawing.Size(86, 15);
            this.dateOfExpiration.TabIndex = 32;
            this.dateOfExpiration.Text = "Expiration date";
            // 
            // measureUnitTb
            // 
            this.measureUnitTb.Location = new System.Drawing.Point(562, 105);
            this.measureUnitTb.Name = "measureUnitTb";
            this.measureUnitTb.Size = new System.Drawing.Size(100, 23);
            this.measureUnitTb.TabIndex = 31;
            // 
            // countTb
            // 
            this.countTb.Location = new System.Drawing.Point(562, 61);
            this.countTb.Name = "countTb";
            this.countTb.Size = new System.Drawing.Size(100, 23);
            this.countTb.TabIndex = 30;
            // 
            // expirationDateTb
            // 
            this.expirationDateTb.Location = new System.Drawing.Point(562, 17);
            this.expirationDateTb.Name = "expirationDateTb";
            this.expirationDateTb.Size = new System.Drawing.Size(100, 23);
            this.expirationDateTb.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateOfExpiration);
            this.Controls.Add(this.measureUnitTb);
            this.Controls.Add(this.countTb);
            this.Controls.Add(this.expirationDateTb);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.describingRichTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateOfPackagingTb);
            this.Controls.Add(this.countryTb);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.nameTb);
            this.Name = "Form1";
            this.Text = "Add food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button submitBtn;
        public RichTextBox describingRichTb;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
        public TextBox dateOfPackagingTb;
        public TextBox countryTb;
        public TextBox priceTb;
        public TextBox nameTb;
        public Label label6;
        public Label label7;
        public Label dateOfExpiration;
        public TextBox measureUnitTb;
        public TextBox countTb;
        public TextBox expirationDateTb;
    }
}