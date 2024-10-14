namespace SimpsonsDownversion.Frontend.Forms
{
    partial class FrmCreateWeddingList
    {
        ///<summary>
        ///  Required designer variable.
        ///</summary>
        private System.ComponentModel.IContainer components = null;

        ///<summary>
        ///  Clean up any resources being used.
        ///</summary>
        ///<param name="disposing">true ifmanaged resources should be disposed;otherwise
        /// false.</param>
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
        ///  Required method for Designer support-do not modify
        ///  the contents of this method with the code editor.
        ///</summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateWeddingList));
            this.lblItemsSelected = new System.Windows.Forms.Label();
            this.lblItemsInStock = new System.Windows.Forms.Label();
            this.lbxSelected = new System.Windows.Forms.ListBox();
            this.lbxStock = new System.Windows.Forms.ListBox();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbFinished = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.tbxTelNo = new System.Windows.Forms.TextBox();
            this.LblTelNo = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lbxEdit = new System.Windows.Forms.ListBox();
            this.cbEdit = new System.Windows.Forms.CheckBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.cbxDelete = new System.Windows.Forms.CheckBox();
            this.tbxSearchHeld = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.tbxForename = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateRed = new System.Windows.Forms.Label();
            this.lblEditSearch = new System.Windows.Forms.Label();
            this.tbxEditSearch = new System.Windows.Forms.TextBox();
            this.btnFastMoving = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnAppliances = new System.Windows.Forms.Button();
            this.btnBedding = new System.Windows.Forms.Button();
            this.btnCutlery = new System.Windows.Forms.Button();
            this.btnChina = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemsSelected
            // 
            this.lblItemsSelected.AutoSize = true;
            this.lblItemsSelected.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblItemsSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemsSelected.Location = new System.Drawing.Point(7, 332);
            this.lblItemsSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemsSelected.Name = "lblItemsSelected";
            this.lblItemsSelected.Size = new System.Drawing.Size(139, 23);
            this.lblItemsSelected.TabIndex = 64;
            this.lblItemsSelected.Text = "Items Selected:";
            // 
            // lblItemsInStock
            // 
            this.lblItemsInStock.AutoSize = true;
            this.lblItemsInStock.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblItemsInStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemsInStock.Location = new System.Drawing.Point(11, 3);
            this.lblItemsInStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemsInStock.Name = "lblItemsInStock";
            this.lblItemsInStock.Size = new System.Drawing.Size(201, 23);
            this.lblItemsInStock.TabIndex = 63;
            this.lblItemsInStock.Text = "Search Items in Stock:";
            // 
            // lbxSelected
            // 
            this.lbxSelected.BackColor = System.Drawing.SystemColors.Control;
            this.lbxSelected.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lbxSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbxSelected.FormattingEnabled = true;
            this.lbxSelected.ItemHeight = 21;
            this.lbxSelected.Location = new System.Drawing.Point(8, 357);
            this.lbxSelected.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSelected.Name = "lbxSelected";
            this.lbxSelected.Size = new System.Drawing.Size(594, 193);
            this.lbxSelected.TabIndex = 13;
            this.lbxSelected.SelectedIndexChanged += new System.EventHandler(this.WipeAmount);
            this.lbxSelected.Enter += new System.EventHandler(this.ChangeBtnMove);
            // 
            // lbxStock
            // 
            this.lbxStock.BackColor = System.Drawing.SystemColors.Control;
            this.lbxStock.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lbxStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbxStock.FormattingEnabled = true;
            this.lbxStock.ItemHeight = 21;
            this.lbxStock.Location = new System.Drawing.Point(8, 116);
            this.lbxStock.Margin = new System.Windows.Forms.Padding(2);
            this.lbxStock.Name = "lbxStock";
            this.lbxStock.Size = new System.Drawing.Size(594, 130);
            this.lbxStock.TabIndex = 9;
            this.lbxStock.SelectedIndexChanged += new System.EventHandler(this.WipeAmount);
            this.lbxStock.Enter += new System.EventHandler(this.ChangeBtnMove);
            // 
            // btnToMenu
            // 
            this.btnToMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnToMenu.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToMenu.Location = new System.Drawing.Point(10, 555);
            this.btnToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(153, 37);
            this.btnToMenu.TabIndex = 16;
            this.btnToMenu.Text = "Exit to Menu";
            this.btnToMenu.UseVisualStyleBackColor = false;
            this.btnToMenu.Click += new System.EventHandler(this.ToMenu);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.Location = new System.Drawing.Point(709, 553);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(216, 35);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Confirm Creation";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // cbFinished
            // 
            this.cbFinished.AutoSize = true;
            this.cbFinished.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbFinished.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbFinished.Location = new System.Drawing.Point(771, 526);
            this.cbFinished.Margin = new System.Windows.Forms.Padding(2);
            this.cbFinished.Name = "cbFinished";
            this.cbFinished.Size = new System.Drawing.Size(111, 27);
            this.cbFinished.TabIndex = 15;
            this.cbFinished.Text = "Finished?";
            this.cbFinished.UseVisualStyleBackColor = true;
            this.cbFinished.CheckedChanged += new System.EventHandler(this.Finished);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpEnd.CalendarMonthBackground = System.Drawing.Color.DarkSlateBlue;
            this.dtpEnd.CalendarTitleBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpEnd.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpEnd.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.dtpEnd.Location = new System.Drawing.Point(816, 488);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(185, 28);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.ValidateDateTime);
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbxTitle.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxTitle.Location = new System.Drawing.Point(816, 321);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(66, 28);
            this.tbxTitle.TabIndex = 0;
            this.tbxTitle.TextChanged += new System.EventHandler(this.CheckStringFieldValid);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(631, 488);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(159, 23);
            this.lblDate.TabIndex = 48;
            this.lblDate.Text = "Date of Wedding:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(631, 324);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 23);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Title of Client:";
            // 
            // tbxPostcode
            // 
            this.tbxPostcode.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPostcode.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxPostcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxPostcode.Location = new System.Drawing.Point(816, 420);
            this.tbxPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPostcode.Name = "tbxPostcode";
            this.tbxPostcode.Size = new System.Drawing.Size(206, 28);
            this.tbxPostcode.TabIndex = 3;
            this.tbxPostcode.TextChanged += new System.EventHandler(this.CheckStringFieldValid);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblPostcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPostcode.Location = new System.Drawing.Point(631, 424);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(147, 23);
            this.lblPostcode.TabIndex = 69;
            this.lblPostcode.Text = "Client Postcode:";
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnMove.Location = new System.Drawing.Point(258, 263);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(150, 63);
            this.btnMove.TabIndex = 12;
            this.btnMove.Text = "Add/Remove from List";
            this.btnMove.Click += new System.EventHandler(this.MoveStock);
            // 
            // tbxTelNo
            // 
            this.tbxTelNo.BackColor = System.Drawing.SystemColors.Control;
            this.tbxTelNo.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxTelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxTelNo.Location = new System.Drawing.Point(869, 456);
            this.tbxTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTelNo.Name = "tbxTelNo";
            this.tbxTelNo.Size = new System.Drawing.Size(153, 28);
            this.tbxTelNo.TabIndex = 4;
            this.tbxTelNo.TextChanged += new System.EventHandler(this.CheckTelNoFieldValid);
            // 
            // LblTelNo
            // 
            this.LblTelNo.AutoSize = true;
            this.LblTelNo.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.LblTelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTelNo.Location = new System.Drawing.Point(631, 459);
            this.LblTelNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTelNo.Name = "LblTelNo";
            this.LblTelNo.Size = new System.Drawing.Size(234, 23);
            this.LblTelNo.TabIndex = 77;
            this.LblTelNo.Text = "Client Telephone Number:";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnPlus.Location = new System.Drawing.Point(192, 265);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 58);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.AmountToMoveChanged);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnMinus.Location = new System.Drawing.Point(414, 265);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(62, 58);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.AmountToMoveChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblAmount.Location = new System.Drawing.Point(244, 328);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(175, 23);
            this.lblAmount.TabIndex = 82;
            this.lblAmount.Text = "Amount to Move: 0";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblSuccess.ForeColor = System.Drawing.Color.Black;
            this.lblSuccess.Location = new System.Drawing.Point(232, 560);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(423, 23);
            this.lblSuccess.TabIndex = 83;
            this.lblSuccess.Text = "The Wedding List has been Successfully Created!";
            this.lblSuccess.Visible = false;
            // 
            // lbxEdit
            // 
            this.lbxEdit.BackColor = System.Drawing.SystemColors.Control;
            this.lbxEdit.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lbxEdit.FormattingEnabled = true;
            this.lbxEdit.ItemHeight = 21;
            this.lbxEdit.Location = new System.Drawing.Point(631, 70);
            this.lbxEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxEdit.Name = "lbxEdit";
            this.lbxEdit.Size = new System.Drawing.Size(391, 151);
            this.lbxEdit.TabIndex = 7;
            this.lbxEdit.Visible = false;
            this.lbxEdit.SelectedIndexChanged += new System.EventHandler(this.FillEverything);
            // 
            // cbEdit
            // 
            this.cbEdit.AutoSize = true;
            this.cbEdit.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbEdit.Location = new System.Drawing.Point(631, 10);
            this.cbEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbEdit.Name = "cbEdit";
            this.cbEdit.Size = new System.Drawing.Size(294, 27);
            this.cbEdit.TabIndex = 6;
            this.cbEdit.Text = "Edit an Existing Wedding List?";
            this.cbEdit.UseVisualStyleBackColor = true;
            this.cbEdit.CheckedChanged += new System.EventHandler(this.EditVisible);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdit.Location = new System.Drawing.Point(631, 44);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(273, 23);
            this.lblEdit.TabIndex = 86;
            this.lblEdit.Text = "Choose a Wedding List to Edit:";
            this.lblEdit.Visible = false;
            // 
            // cbxDelete
            // 
            this.cbxDelete.AutoSize = true;
            this.cbxDelete.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbxDelete.Location = new System.Drawing.Point(706, 282);
            this.cbxDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Size = new System.Drawing.Size(247, 27);
            this.cbxDelete.TabIndex = 8;
            this.cbxDelete.Text = "Delete this Wedding List?";
            this.cbxDelete.UseVisualStyleBackColor = true;
            this.cbxDelete.Visible = false;
            this.cbxDelete.CheckedChanged += new System.EventHandler(this.Delete);
            // 
            // tbxSearchHeld
            // 
            this.tbxSearchHeld.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSearchHeld.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxSearchHeld.Location = new System.Drawing.Point(12, 28);
            this.tbxSearchHeld.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearchHeld.Name = "tbxSearchHeld";
            this.tbxSearchHeld.Size = new System.Drawing.Size(590, 28);
            this.tbxSearchHeld.TabIndex = 14;
            this.tbxSearchHeld.TextChanged += new System.EventHandler(this.SearchStock);
            // 
            // tbxSurname
            // 
            this.tbxSurname.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSurname.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxSurname.Location = new System.Drawing.Point(816, 387);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(206, 28);
            this.tbxSurname.TabIndex = 2;
            this.tbxSurname.TextChanged += new System.EventHandler(this.CheckStringFieldValid);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblForename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblForename.Location = new System.Drawing.Point(631, 360);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(177, 23);
            this.lblForename.TabIndex = 90;
            this.lblForename.Text = "Forename of Client:";
            // 
            // tbxForename
            // 
            this.tbxForename.BackColor = System.Drawing.SystemColors.Control;
            this.tbxForename.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxForename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxForename.Location = new System.Drawing.Point(816, 353);
            this.tbxForename.Margin = new System.Windows.Forms.Padding(2);
            this.tbxForename.Name = "tbxForename";
            this.tbxForename.Size = new System.Drawing.Size(206, 28);
            this.tbxForename.TabIndex = 1;
            this.tbxForename.TextChanged += new System.EventHandler(this.CheckStringFieldValid);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSurname.Location = new System.Drawing.Point(631, 391);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(169, 23);
            this.lblSurname.TabIndex = 92;
            this.lblSurname.Text = "Surname of Client:";
            // 
            // lblDateRed
            // 
            this.lblDateRed.AutoSize = true;
            this.lblDateRed.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDateRed.ForeColor = System.Drawing.Color.Red;
            this.lblDateRed.Location = new System.Drawing.Point(1005, 488);
            this.lblDateRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateRed.Name = "lblDateRed";
            this.lblDateRed.Size = new System.Drawing.Size(17, 23);
            this.lblDateRed.TabIndex = 93;
            this.lblDateRed.Text = "!";
            this.lblDateRed.Visible = false;
            // 
            // lblEditSearch
            // 
            this.lblEditSearch.AutoSize = true;
            this.lblEditSearch.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblEditSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEditSearch.Location = new System.Drawing.Point(631, 224);
            this.lblEditSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditSearch.Name = "lblEditSearch";
            this.lblEditSearch.Size = new System.Drawing.Size(74, 23);
            this.lblEditSearch.TabIndex = 97;
            this.lblEditSearch.Text = "Search:";
            this.lblEditSearch.Visible = false;
            // 
            // tbxEditSearch
            // 
            this.tbxEditSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tbxEditSearch.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxEditSearch.Location = new System.Drawing.Point(631, 249);
            this.tbxEditSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEditSearch.Name = "tbxEditSearch";
            this.tbxEditSearch.Size = new System.Drawing.Size(395, 28);
            this.tbxEditSearch.TabIndex = 96;
            this.tbxEditSearch.Visible = false;
            this.tbxEditSearch.TextChanged += new System.EventHandler(this.SearchEdit);
            // 
            // btnFastMoving
            // 
            this.btnFastMoving.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnFastMoving.Location = new System.Drawing.Point(429, 61);
            this.btnFastMoving.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFastMoving.Name = "btnFastMoving";
            this.btnFastMoving.Size = new System.Drawing.Size(97, 54);
            this.btnFastMoving.TabIndex = 166;
            this.btnFastMoving.Text = "Popular";
            this.btnFastMoving.UseVisualStyleBackColor = true;
            this.btnFastMoving.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnClearFilters.Location = new System.Drawing.Point(520, 61);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(82, 55);
            this.btnClearFilters.TabIndex = 165;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnAppliances
            // 
            this.btnAppliances.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnAppliances.Location = new System.Drawing.Point(305, 62);
            this.btnAppliances.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAppliances.Name = "btnAppliances";
            this.btnAppliances.Size = new System.Drawing.Size(127, 54);
            this.btnAppliances.TabIndex = 164;
            this.btnAppliances.Text = "Appliances";
            this.btnAppliances.UseVisualStyleBackColor = true;
            this.btnAppliances.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnBedding
            // 
            this.btnBedding.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnBedding.Location = new System.Drawing.Point(10, 61);
            this.btnBedding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBedding.Name = "btnBedding";
            this.btnBedding.Size = new System.Drawing.Size(96, 54);
            this.btnBedding.TabIndex = 163;
            this.btnBedding.Text = "Bedding";
            this.btnBedding.UseVisualStyleBackColor = true;
            this.btnBedding.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnCutlery
            // 
            this.btnCutlery.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnCutlery.Location = new System.Drawing.Point(102, 61);
            this.btnCutlery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCutlery.Name = "btnCutlery";
            this.btnCutlery.Size = new System.Drawing.Size(109, 54);
            this.btnCutlery.TabIndex = 162;
            this.btnCutlery.Text = "Cutlery";
            this.btnCutlery.UseVisualStyleBackColor = true;
            this.btnCutlery.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnChina
            // 
            this.btnChina.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnChina.Location = new System.Drawing.Point(204, 62);
            this.btnChina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChina.Name = "btnChina";
            this.btnChina.Size = new System.Drawing.Size(109, 53);
            this.btnChina.TabIndex = 161;
            this.btnChina.Text = "China";
            this.btnChina.UseVisualStyleBackColor = true;
            this.btnChina.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpsonsDownversion.Properties.Resources.glass;
            this.pictureBox1.Location = new System.Drawing.Point(569, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCreateWeddingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpsonsDownversion.Properties.Resources.pinkrose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFastMoving);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnAppliances);
            this.Controls.Add(this.btnBedding);
            this.Controls.Add(this.btnCutlery);
            this.Controls.Add(this.btnChina);
            this.Controls.Add(this.lblEditSearch);
            this.Controls.Add(this.tbxEditSearch);
            this.Controls.Add(this.lblDateRed);
            this.Controls.Add(this.tbxForename);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.tbxSearchHeld);
            this.Controls.Add(this.cbxDelete);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.cbEdit);
            this.Controls.Add(this.lbxEdit);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tbxTelNo);
            this.Controls.Add(this.LblTelNo);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.tbxPostcode);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblItemsSelected);
            this.Controls.Add(this.lblItemsInStock);
            this.Controls.Add(this.lbxSelected);
            this.Controls.Add(this.lbxStock);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbFinished);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreateWeddingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wedding List Mangement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemsSelected;
        private System.Windows.Forms.Label lblItemsInStock;
        private System.Windows.Forms.ListBox lbxSelected;
        private System.Windows.Forms.ListBox lbxStock;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox cbFinished;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox tbxTelNo;
        private System.Windows.Forms.Label LblTelNo;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.ListBox lbxEdit;
        private System.Windows.Forms.CheckBox cbEdit;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.CheckBox cbxDelete;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox tbxForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateRed;

        private System.Windows.Forms.Label lblEditSearch;
        private System.Windows.Forms.TextBox tbxEditSearch;
        private System.Windows.Forms.TextBox tbxSearchHeld;
        private System.Windows.Forms.Button btnFastMoving;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnAppliances;
        private System.Windows.Forms.Button btnBedding;
        private System.Windows.Forms.Button btnCutlery;
        private System.Windows.Forms.Button btnChina;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

