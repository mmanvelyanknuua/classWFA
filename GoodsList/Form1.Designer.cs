namespace GoodsList
{
    partial class GoodsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsListForm));
            this.goodsList = new System.Windows.Forms.DataGridView();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodPackagingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodDescribing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodMeasureUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPagesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addBookBtn = new System.Windows.Forms.ToolStripButton();
            this.addFoodBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteProductBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.goodsList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsList
            // 
            this.goodsList.AllowUserToAddRows = false;
            this.goodsList.AllowUserToDeleteRows = false;
            this.goodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodName,
            this.GoodPrice,
            this.GoodCountry,
            this.GoodPackagingDate,
            this.GoodDescribing,
            this.FoodExpirationDate,
            this.FoodCount,
            this.FoodMeasureUnit,
            this.BookAuthors,
            this.BookPublishing,
            this.BookPagesCount});
            this.goodsList.Location = new System.Drawing.Point(12, 28);
            this.goodsList.Name = "goodsList";
            this.goodsList.ReadOnly = true;
            this.goodsList.RowTemplate.Height = 25;
            this.goodsList.Size = new System.Drawing.Size(1143, 410);
            this.goodsList.TabIndex = 0;
            // 
            // GoodName
            // 
            this.GoodName.HeaderText = "Name";
            this.GoodName.Name = "GoodName";
            this.GoodName.ReadOnly = true;
            // 
            // GoodPrice
            // 
            this.GoodPrice.HeaderText = "Price";
            this.GoodPrice.Name = "GoodPrice";
            this.GoodPrice.ReadOnly = true;
            // 
            // GoodCountry
            // 
            this.GoodCountry.HeaderText = "Country";
            this.GoodCountry.Name = "GoodCountry";
            this.GoodCountry.ReadOnly = true;
            // 
            // GoodPackagingDate
            // 
            this.GoodPackagingDate.HeaderText = "Packaging date";
            this.GoodPackagingDate.Name = "GoodPackagingDate";
            this.GoodPackagingDate.ReadOnly = true;
            // 
            // GoodDescribing
            // 
            this.GoodDescribing.HeaderText = "Desribing";
            this.GoodDescribing.Name = "GoodDescribing";
            this.GoodDescribing.ReadOnly = true;
            // 
            // FoodExpirationDate
            // 
            this.FoodExpirationDate.HeaderText = "Expiration date";
            this.FoodExpirationDate.Name = "FoodExpirationDate";
            this.FoodExpirationDate.ReadOnly = true;
            // 
            // FoodCount
            // 
            this.FoodCount.HeaderText = "Count";
            this.FoodCount.Name = "FoodCount";
            this.FoodCount.ReadOnly = true;
            // 
            // FoodMeasureUnit
            // 
            this.FoodMeasureUnit.HeaderText = "Measure unit";
            this.FoodMeasureUnit.Name = "FoodMeasureUnit";
            this.FoodMeasureUnit.ReadOnly = true;
            // 
            // BookAuthors
            // 
            this.BookAuthors.HeaderText = "Book authors";
            this.BookAuthors.Name = "BookAuthors";
            this.BookAuthors.ReadOnly = true;
            // 
            // BookPublishing
            // 
            this.BookPublishing.HeaderText = "Publishing";
            this.BookPublishing.Name = "BookPublishing";
            this.BookPublishing.ReadOnly = true;
            // 
            // BookPagesCount
            // 
            this.BookPagesCount.HeaderText = "Pages count";
            this.BookPagesCount.Name = "BookPagesCount";
            this.BookPagesCount.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookBtn,
            this.addFoodBtn,
            this.deleteProductBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1194, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addBookBtn
            // 
            this.addBookBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addBookBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBookBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(63, 22);
            this.addBookBtn.Text = "Add book";
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addFoodBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.Size = new System.Drawing.Size(61, 22);
            this.addFoodBtn.Text = "Add food";
            this.addFoodBtn.Click += new System.EventHandler(this.addFoodBtn_Click);
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteProductBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteProductBtn.Image")));
            this.deleteProductBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(44, 22);
            this.deleteProductBtn.Text = "Delete";
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // GoodsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.goodsList);
            this.Name = "GoodsListForm";
            this.Text = "Goods list";
            ((System.ComponentModel.ISupportInitialize)(this.goodsList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView goodsList;
        private ToolStrip toolStrip1;
        public ToolStripButton addBookBtn;
        private ToolStripButton addFoodBtn;
        private ToolStripButton deleteProductBtn;
        private DataGridViewTextBoxColumn GoodName;
        private DataGridViewTextBoxColumn GoodPrice;
        private DataGridViewTextBoxColumn GoodCountry;
        private DataGridViewTextBoxColumn GoodPackagingDate;
        private DataGridViewTextBoxColumn GoodDescribing;
        private DataGridViewTextBoxColumn FoodExpirationDate;
        private DataGridViewTextBoxColumn FoodCount;
        private DataGridViewTextBoxColumn FoodMeasureUnit;
        private DataGridViewTextBoxColumn BookAuthors;
        private DataGridViewTextBoxColumn BookPublishing;
        private DataGridViewTextBoxColumn BookPagesCount;
    }
}