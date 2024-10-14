namespace SimpsonsDownversion.Frontend.Forms
{
    partial class FrmStockControl
    {
        ///<summary>
        /// Required designer variable.
        ///</summary>
        private System.ComponentModel.IContainer components = null;

        ///<summary>
        /// Clean up any resources being used.
        ///</summary>
        ///<param name="disposing">true ifmanaged resources should be disposed;otherwise,false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        ///<summary>
        /// Required method for Designer support-do not modify
        /// the contents of this method with the code editor.
        ///</summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockControl));
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAutoOrder = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblNamePrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChina = new System.Windows.Forms.Button();
            this.btnCutlery = new System.Windows.Forms.Button();
            this.btnBedding = new System.Windows.Forms.Button();
            this.btnAppliances = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lblList = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnMoving = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMoving = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnSlowMoving = new System.Windows.Forms.Button();
            this.mcal2 = new System.Windows.Forms.MonthCalendar();
            this.mcal1 = new System.Windows.Forms.MonthCalendar();
            this.btnFastMoving = new System.Windows.Forms.Button();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.pnlMoving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStock.Location = new System.Drawing.Point(14, 14);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(5);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 25;
            this.dgvStock.Size = new System.Drawing.Size(1054, 492);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FindRow);
            this.dgvStock.Paint += new System.Windows.Forms.PaintEventHandler(this.ColourDGV);
            // 
            // btnAutoOrder
            // 
            this.btnAutoOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoOrder.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnAutoOrder.Location = new System.Drawing.Point(850, 613);
            this.btnAutoOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutoOrder.Name = "btnAutoOrder";
            this.btnAutoOrder.Size = new System.Drawing.Size(220, 82);
            this.btnAutoOrder.TabIndex = 4;
            this.btnAutoOrder.Text = "Auto Order Items";
            this.btnAutoOrder.UseVisualStyleBackColor = false;
            this.btnAutoOrder.Click += new System.EventHandler(this.AutoOrderClicked);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxAmount.Location = new System.Drawing.Point(592, 641);
            this.tbxAmount.Margin = new System.Windows.Forms.Padding(5);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(110, 28);
            this.tbxAmount.TabIndex = 7;
            this.tbxAmount.TextChanged += new System.EventHandler(this.CheckAmount);
            // 
            // lblNamePrice
            // 
            this.lblNamePrice.AutoSize = true;
            this.lblNamePrice.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblNamePrice.Location = new System.Drawing.Point(451, 613);
            this.lblNamePrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNamePrice.Name = "lblNamePrice";
            this.lblNamePrice.Size = new System.Drawing.Size(251, 23);
            this.lblNamePrice.TabIndex = 8;
            this.lblNamePrice.Text = "Productname(ProductPrice)";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblAmount.Location = new System.Drawing.Point(374, 641);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(208, 23);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount to Be Ordered:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnOrder.Location = new System.Drawing.Point(712, 613);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 82);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Add to Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Visible = false;
            this.btnOrder.Click += new System.EventHandler(this.Order);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnExit.Location = new System.Drawing.Point(5, 657);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // btnChina
            // 
            this.btnChina.BackColor = System.Drawing.Color.Transparent;
            this.btnChina.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnChina.Location = new System.Drawing.Point(586, 551);
            this.btnChina.Margin = new System.Windows.Forms.Padding(5);
            this.btnChina.Name = "btnChina";
            this.btnChina.Size = new System.Drawing.Size(112, 39);
            this.btnChina.TabIndex = 1;
            this.btnChina.Text = "China";
            this.btnChina.UseVisualStyleBackColor = false;
            this.btnChina.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnCutlery
            // 
            this.btnCutlery.BackColor = System.Drawing.Color.Transparent;
            this.btnCutlery.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnCutlery.Location = new System.Drawing.Point(450, 549);
            this.btnCutlery.Margin = new System.Windows.Forms.Padding(5);
            this.btnCutlery.Name = "btnCutlery";
            this.btnCutlery.Size = new System.Drawing.Size(126, 42);
            this.btnCutlery.TabIndex = 2;
            this.btnCutlery.Text = "Cutlery";
            this.btnCutlery.UseVisualStyleBackColor = false;
            this.btnCutlery.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnBedding
            // 
            this.btnBedding.BackColor = System.Drawing.Color.Transparent;
            this.btnBedding.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnBedding.Location = new System.Drawing.Point(328, 549);
            this.btnBedding.Margin = new System.Windows.Forms.Padding(5);
            this.btnBedding.Name = "btnBedding";
            this.btnBedding.Size = new System.Drawing.Size(112, 42);
            this.btnBedding.TabIndex = 3;
            this.btnBedding.Text = "Bedding";
            this.btnBedding.UseVisualStyleBackColor = false;
            this.btnBedding.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnAppliances
            // 
            this.btnAppliances.BackColor = System.Drawing.Color.Transparent;
            this.btnAppliances.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnAppliances.Location = new System.Drawing.Point(708, 551);
            this.btnAppliances.Margin = new System.Windows.Forms.Padding(5);
            this.btnAppliances.Name = "btnAppliances";
            this.btnAppliances.Size = new System.Drawing.Size(132, 39);
            this.btnAppliances.TabIndex = 6;
            this.btnAppliances.Text = "Appliances";
            this.btnAppliances.UseVisualStyleBackColor = false;
            this.btnAppliances.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnClearFilters.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnClearFilters.Location = new System.Drawing.Point(983, 553);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(87, 55);
            this.btnClearFilters.TabIndex = 12;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // lbxList
            // 
            this.lbxList.ItemHeight = 21;
            this.lbxList.Location = new System.Drawing.Point(1078, 40);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(359, 613);
            this.lbxList.TabIndex = 13;
            this.lbxList.DoubleClick += new System.EventHandler(this.DeleteFromList);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(1076, 14);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(238, 23);
            this.lblList.TabIndex = 14;
            this.lblList.Text = "Stock Items to be Ordered:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblPrice.Location = new System.Drawing.Point(374, 667);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(151, 23);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price of Items: £";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblTotalPrice.Location = new System.Drawing.Point(1077, 667);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(104, 18);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "Total Price: £";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnComplete.Location = new System.Drawing.Point(1282, 656);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(5);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(155, 42);
            this.btnComplete.TabIndex = 17;
            this.btnComplete.Text = "Complete Order";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.Complete);
            // 
            // btnMoving
            // 
            this.btnMoving.BackColor = System.Drawing.Color.Transparent;
            this.btnMoving.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnMoving.Location = new System.Drawing.Point(850, 553);
            this.btnMoving.Margin = new System.Windows.Forms.Padding(5);
            this.btnMoving.Name = "btnMoving";
            this.btnMoving.Size = new System.Drawing.Size(123, 37);
            this.btnMoving.TabIndex = 18;
            this.btnMoving.Text = "Sell Speed";
            this.btnMoving.UseVisualStyleBackColor = false;
            this.btnMoving.Click += new System.EventHandler(this.FastSlowMoving);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(328, 517);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(740, 28);
            this.tbxSearch.TabIndex = 19;
            this.tbxSearch.TextChanged += new System.EventHandler(this.Search);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblSearch.Location = new System.Drawing.Point(14, 520);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(304, 23);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search By Model or Manufacturer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.label1.Location = new System.Drawing.Point(374, 613);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.label2.Location = new System.Drawing.Point(138, 560);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search By Category:";
            // 
            // pnlMoving
            // 
            this.pnlMoving.Controls.Add(this.button1);
            this.pnlMoving.Controls.Add(this.lblSortBy);
            this.pnlMoving.Controls.Add(this.btnSlowMoving);
            this.pnlMoving.Controls.Add(this.mcal2);
            this.pnlMoving.Controls.Add(this.mcal1);
            this.pnlMoving.Controls.Add(this.btnFastMoving);
            this.pnlMoving.Controls.Add(this.lblDateRange);
            this.pnlMoving.Location = new System.Drawing.Point(245, 110);
            this.pnlMoving.Name = "pnlMoving";
            this.pnlMoving.Size = new System.Drawing.Size(504, 334);
            this.pnlMoving.TabIndex = 25;
            this.pnlMoving.Visible = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FastSlowMoving);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(210, 238);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(77, 23);
            this.lblSortBy.TabIndex = 6;
            this.lblSortBy.Text = "Sort by:";
            // 
            // btnSlowMoving
            // 
            this.btnSlowMoving.Location = new System.Drawing.Point(12, 271);
            this.btnSlowMoving.Name = "btnSlowMoving";
            this.btnSlowMoving.Size = new System.Drawing.Size(224, 50);
            this.btnSlowMoving.TabIndex = 5;
            this.btnSlowMoving.Text = "Slow Moving Stock";
            this.btnSlowMoving.UseVisualStyleBackColor = true;
            this.btnSlowMoving.Click += new System.EventHandler(this.Moving);
            // 
            // mcal2
            // 
            this.mcal2.Location = new System.Drawing.Point(265, 67);
            this.mcal2.Name = "mcal2";
            this.mcal2.TabIndex = 4;
            // 
            // mcal1
            // 
            this.mcal1.Location = new System.Drawing.Point(9, 67);
            this.mcal1.Name = "mcal1";
            this.mcal1.TabIndex = 3;
            // 
            // btnFastMoving
            // 
            this.btnFastMoving.Location = new System.Drawing.Point(265, 271);
            this.btnFastMoving.Name = "btnFastMoving";
            this.btnFastMoving.Size = new System.Drawing.Size(227, 50);
            this.btnFastMoving.TabIndex = 1;
            this.btnFastMoving.Text = "Fast Moving Stock";
            this.btnFastMoving.UseVisualStyleBackColor = true;
            this.btnFastMoving.Click += new System.EventHandler(this.Moving);
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Location = new System.Drawing.Point(129, 25);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(237, 23);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "Please Choose Date Range:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpsonsDownversion.Properties.Resources.glass;
            this.pictureBox1.Location = new System.Drawing.Point(1035, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpsonsDownversion.Properties.Resources.cartoonyflow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMoving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnMoving);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblNamePrice);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.btnAppliances);
            this.Controls.Add(this.btnAutoOrder);
            this.Controls.Add(this.btnBedding);
            this.Controls.Add(this.btnCutlery);
            this.Controls.Add(this.btnChina);
            this.Controls.Add(this.dgvStock);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmStockControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Control";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.pnlMoving.ResumeLayout(false);
            this.pnlMoving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnAutoOrder;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label lblNamePrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChina;
        private System.Windows.Forms.Button btnCutlery;
        private System.Windows.Forms.Button btnBedding;
        private System.Windows.Forms.Button btnAppliances;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnMoving;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMoving;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Button btnSlowMoving;
        private System.Windows.Forms.MonthCalendar mcal2;
        private System.Windows.Forms.MonthCalendar mcal1;
        private System.Windows.Forms.Button btnFastMoving;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}