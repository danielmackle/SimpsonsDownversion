namespace SimpsonsDownversion.Frontend.Forms
{
    partial class FrmOrderFromWeddingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderFromWeddingList));
            this.btnToMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbxSelected = new System.Windows.Forms.ListBox();
            this.lblWedList = new System.Windows.Forms.Label();
            this.lbxWeddingList = new System.Windows.Forms.ListBox();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.lblAdd3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblStockHeld = new System.Windows.Forms.Label();
            this.lblStockBuy = new System.Windows.Forms.Label();
            this.cbxMessage = new System.Windows.Forms.CheckBox();
            this.cbxSign = new System.Windows.Forms.CheckBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.lblForeName = new System.Windows.Forms.Label();
            this.lblPTelNo = new System.Windows.Forms.Label();
            this.lblPPostCode = new System.Windows.Forms.Label();
            this.tbxAdd3 = new System.Windows.Forms.TextBox();
            this.tbxAdd2 = new System.Windows.Forms.TextBox();
            this.tbxAdd1 = new System.Windows.Forms.TextBox();
            this.tbxPostCode = new System.Windows.Forms.TextBox();
            this.tbxTelNo = new System.Windows.Forms.TextBox();
            this.tbxForename = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMessageError = new System.Windows.Forms.Label();
            this.cbxReady = new System.Windows.Forms.CheckBox();
            this.cbxNoWeddingList = new System.Windows.Forms.CheckBox();
            this.cbxPickUp = new System.Windows.Forms.CheckBox();
            this.tbxSearchHeld = new System.Windows.Forms.TextBox();
            this.tbxSearchWedList = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnFastMoving = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnAppliances = new System.Windows.Forms.Button();
            this.btnBedding = new System.Windows.Forms.Button();
            this.btnCutlery = new System.Windows.Forms.Button();
            this.btnChina = new System.Windows.Forms.Button();
            this.lbxStock = new System.Windows.Forms.ListBox();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.mcal1 = new System.Windows.Forms.MonthCalendar();
            this.mcal2 = new System.Windows.Forms.MonthCalendar();
            this.btnSlowMoving = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMoving = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMoving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToMenu
            // 
            this.btnToMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnToMenu.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToMenu.Location = new System.Drawing.Point(-272, 352);
            this.btnToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(124, 27);
            this.btnToMenu.TabIndex = 59;
            this.btnToMenu.Text = "Exit to Menu";
            this.btnToMenu.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(6, 560);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 33);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "Exit to Menu";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // lbxSelected
            // 
            this.lbxSelected.BackColor = System.Drawing.SystemColors.Control;
            this.lbxSelected.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbxSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbxSelected.ItemHeight = 18;
            this.lbxSelected.Location = new System.Drawing.Point(420, 415);
            this.lbxSelected.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSelected.Name = "lbxSelected";
            this.lbxSelected.Size = new System.Drawing.Size(641, 148);
            this.lbxSelected.TabIndex = 63;
            this.lbxSelected.SelectedIndexChanged += new System.EventHandler(this.WipeAmount);
            this.lbxSelected.Enter += new System.EventHandler(this.ChangeBtnMove);
            // 
            // lblWedList
            // 
            this.lblWedList.AutoSize = true;
            this.lblWedList.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblWedList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWedList.Location = new System.Drawing.Point(11, 40);
            this.lblWedList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWedList.Name = "lblWedList";
            this.lblWedList.Size = new System.Drawing.Size(386, 23);
            this.lblWedList.TabIndex = 64;
            this.lblWedList.Text = "Please Select a Wedding List to Order From:";
            // 
            // lbxWeddingList
            // 
            this.lbxWeddingList.BackColor = System.Drawing.SystemColors.Control;
            this.lbxWeddingList.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lbxWeddingList.FormattingEnabled = true;
            this.lbxWeddingList.ItemHeight = 21;
            this.lbxWeddingList.Location = new System.Drawing.Point(11, 106);
            this.lbxWeddingList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxWeddingList.Name = "lbxWeddingList";
            this.lbxWeddingList.Size = new System.Drawing.Size(386, 319);
            this.lbxWeddingList.TabIndex = 85;
            this.lbxWeddingList.SelectedIndexChanged += new System.EventHandler(this.FillEverything);
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblAdd1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdd1.Location = new System.Drawing.Point(1109, 271);
            this.lblAdd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(139, 23);
            this.lblAdd1.TabIndex = 88;
            this.lblAdd1.Text = "Address Line 1:";
            this.lblAdd1.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(11, 521);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(159, 23);
            this.lblDate.TabIndex = 89;
            this.lblDate.Text = "Date of Wedding:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblPostCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPostCode.Location = new System.Drawing.Point(11, 493);
            this.lblPostCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(180, 23);
            this.lblPostCode.TabIndex = 90;
            this.lblPostCode.Text = "Post Code Of Client:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblTelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelNo.Location = new System.Drawing.Point(11, 466);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(148, 23);
            this.lblTelNo.TabIndex = 91;
            this.lblTelNo.Text = "Tel No of Client:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(11, 440);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 23);
            this.lblName.TabIndex = 92;
            this.lblName.Text = "Name of Client:";
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblAdd2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdd2.Location = new System.Drawing.Point(1109, 326);
            this.lblAdd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(142, 23);
            this.lblAdd2.TabIndex = 93;
            this.lblAdd2.Text = "Address Line 2:";
            this.lblAdd2.Visible = false;
            // 
            // lblAdd3
            // 
            this.lblAdd3.AutoSize = true;
            this.lblAdd3.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblAdd3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdd3.Location = new System.Drawing.Point(1110, 381);
            this.lblAdd3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd3.Name = "lblAdd3";
            this.lblAdd3.Size = new System.Drawing.Size(141, 23);
            this.lblAdd3.TabIndex = 95;
            this.lblAdd3.Text = "Address Line 3:";
            this.lblAdd3.Visible = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalPrice.Location = new System.Drawing.Point(850, 333);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(167, 23);
            this.lblTotalPrice.TabIndex = 96;
            this.lblTotalPrice.Text = "Total Price: £0.00";
            // 
            // lblStockHeld
            // 
            this.lblStockHeld.AutoSize = true;
            this.lblStockHeld.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblStockHeld.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStockHeld.Location = new System.Drawing.Point(416, 9);
            this.lblStockHeld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockHeld.Name = "lblStockHeld";
            this.lblStockHeld.Size = new System.Drawing.Size(249, 23);
            this.lblStockHeld.TabIndex = 97;
            this.lblStockHeld.Text = "Stock Held in Wedding List:";
            // 
            // lblStockBuy
            // 
            this.lblStockBuy.AutoSize = true;
            this.lblStockBuy.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblStockBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStockBuy.Location = new System.Drawing.Point(416, 386);
            this.lblStockBuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockBuy.Name = "lblStockBuy";
            this.lblStockBuy.Size = new System.Drawing.Size(166, 23);
            this.lblStockBuy.TabIndex = 98;
            this.lblStockBuy.Text = "Stock Held to buy:";
            // 
            // cbxMessage
            // 
            this.cbxMessage.AutoSize = true;
            this.cbxMessage.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbxMessage.Location = new System.Drawing.Point(1107, 436);
            this.cbxMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxMessage.Name = "cbxMessage";
            this.cbxMessage.Size = new System.Drawing.Size(255, 27);
            this.cbxMessage.TabIndex = 100;
            this.cbxMessage.Text = "Add an Optional Message?";
            this.cbxMessage.UseVisualStyleBackColor = true;
            this.cbxMessage.Visible = false;
            this.cbxMessage.CheckedChanged += new System.EventHandler(this.MakeMessageVisible);
            // 
            // cbxSign
            // 
            this.cbxSign.AutoSize = true;
            this.cbxSign.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbxSign.Location = new System.Drawing.Point(1107, 495);
            this.cbxSign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxSign.Name = "cbxSign";
            this.cbxSign.Size = new System.Drawing.Size(278, 27);
            this.cbxSign.TabIndex = 101;
            this.cbxSign.Text = "Leave the Order Anonymous?";
            this.cbxSign.UseVisualStyleBackColor = true;
            this.cbxSign.Visible = false;
            // 
            // tbxMessage
            // 
            this.tbxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.tbxMessage.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxMessage.Location = new System.Drawing.Point(1107, 464);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(267, 28);
            this.tbxMessage.TabIndex = 104;
            this.tbxMessage.Visible = false;
            this.tbxMessage.TextChanged += new System.EventHandler(this.MessageChanged);
            // 
            // lblForeName
            // 
            this.lblForeName.AutoSize = true;
            this.lblForeName.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblForeName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblForeName.Location = new System.Drawing.Point(1107, 51);
            this.lblForeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForeName.Name = "lblForeName";
            this.lblForeName.Size = new System.Drawing.Size(213, 23);
            this.lblForeName.TabIndex = 112;
            this.lblForeName.Text = "Forename of Purchaser:";
            this.lblForeName.Visible = false;
            // 
            // lblPTelNo
            // 
            this.lblPTelNo.AutoSize = true;
            this.lblPTelNo.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblPTelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPTelNo.Location = new System.Drawing.Point(1107, 162);
            this.lblPTelNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPTelNo.Name = "lblPTelNo";
            this.lblPTelNo.Size = new System.Drawing.Size(291, 23);
            this.lblPTelNo.TabIndex = 113;
            this.lblPTelNo.Text = "Telephone Number of Purchaser:";
            this.lblPTelNo.Visible = false;
            // 
            // lblPPostCode
            // 
            this.lblPPostCode.AutoSize = true;
            this.lblPPostCode.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblPPostCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPPostCode.Location = new System.Drawing.Point(1108, 217);
            this.lblPPostCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPPostCode.Name = "lblPPostCode";
            this.lblPPostCode.Size = new System.Drawing.Size(212, 23);
            this.lblPPostCode.TabIndex = 114;
            this.lblPPostCode.Text = "Post Code of Purchaser:";
            this.lblPPostCode.Visible = false;
            // 
            // tbxAdd3
            // 
            this.tbxAdd3.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAdd3.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxAdd3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAdd3.Location = new System.Drawing.Point(1107, 406);
            this.tbxAdd3.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAdd3.Name = "tbxAdd3";
            this.tbxAdd3.Size = new System.Drawing.Size(288, 28);
            this.tbxAdd3.TabIndex = 115;
            this.tbxAdd3.Visible = false;
            this.tbxAdd3.TextChanged += new System.EventHandler(this.AddChanged);
            // 
            // tbxAdd2
            // 
            this.tbxAdd2.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAdd2.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxAdd2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAdd2.Location = new System.Drawing.Point(1107, 351);
            this.tbxAdd2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAdd2.Name = "tbxAdd2";
            this.tbxAdd2.Size = new System.Drawing.Size(288, 28);
            this.tbxAdd2.TabIndex = 116;
            this.tbxAdd2.Visible = false;
            this.tbxAdd2.TextChanged += new System.EventHandler(this.AddChanged);
            // 
            // tbxAdd1
            // 
            this.tbxAdd1.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAdd1.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxAdd1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAdd1.Location = new System.Drawing.Point(1107, 296);
            this.tbxAdd1.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAdd1.Name = "tbxAdd1";
            this.tbxAdd1.Size = new System.Drawing.Size(291, 28);
            this.tbxAdd1.TabIndex = 117;
            this.tbxAdd1.Visible = false;
            this.tbxAdd1.TextChanged += new System.EventHandler(this.AddChanged);
            // 
            // tbxPostCode
            // 
            this.tbxPostCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPostCode.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxPostCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxPostCode.Location = new System.Drawing.Point(1107, 242);
            this.tbxPostCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPostCode.Name = "tbxPostCode";
            this.tbxPostCode.Size = new System.Drawing.Size(291, 28);
            this.tbxPostCode.TabIndex = 118;
            this.tbxPostCode.Visible = false;
            this.tbxPostCode.TextChanged += new System.EventHandler(this.PostcodeChanged);
            // 
            // tbxTelNo
            // 
            this.tbxTelNo.BackColor = System.Drawing.SystemColors.Control;
            this.tbxTelNo.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxTelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxTelNo.Location = new System.Drawing.Point(1105, 187);
            this.tbxTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTelNo.Name = "tbxTelNo";
            this.tbxTelNo.Size = new System.Drawing.Size(293, 28);
            this.tbxTelNo.TabIndex = 119;
            this.tbxTelNo.Visible = false;
            this.tbxTelNo.TextChanged += new System.EventHandler(this.TelNoChanged);
            // 
            // tbxForename
            // 
            this.tbxForename.BackColor = System.Drawing.SystemColors.Control;
            this.tbxForename.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxForename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxForename.Location = new System.Drawing.Point(1107, 76);
            this.tbxForename.Margin = new System.Windows.Forms.Padding(2);
            this.tbxForename.Name = "tbxForename";
            this.tbxForename.Size = new System.Drawing.Size(291, 28);
            this.tbxForename.TabIndex = 120;
            this.tbxForename.Visible = false;
            this.tbxForename.TextChanged += new System.EventHandler(this.StringChanged);
            // 
            // tbxSurname
            // 
            this.tbxSurname.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSurname.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxSurname.Location = new System.Drawing.Point(1107, 132);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(291, 28);
            this.tbxSurname.TabIndex = 121;
            this.tbxSurname.Visible = false;
            this.tbxSurname.TextChanged += new System.EventHandler(this.StringChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSurname.Location = new System.Drawing.Point(1107, 106);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(205, 23);
            this.lblSurname.TabIndex = 122;
            this.lblSurname.Text = "Surname of Purchaser:";
            this.lblSurname.Visible = false;
            // 
            // lblMessageError
            // 
            this.lblMessageError.AutoSize = true;
            this.lblMessageError.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMessageError.ForeColor = System.Drawing.Color.Red;
            this.lblMessageError.Location = new System.Drawing.Point(1378, 466);
            this.lblMessageError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessageError.Name = "lblMessageError";
            this.lblMessageError.Size = new System.Drawing.Size(17, 23);
            this.lblMessageError.TabIndex = 123;
            this.lblMessageError.Text = "!";
            this.lblMessageError.Visible = false;
            // 
            // cbxReady
            // 
            this.cbxReady.AutoSize = true;
            this.cbxReady.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbxReady.Location = new System.Drawing.Point(1191, 525);
            this.cbxReady.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxReady.Name = "cbxReady";
            this.cbxReady.Size = new System.Drawing.Size(90, 27);
            this.cbxReady.TabIndex = 124;
            this.cbxReady.Text = "Ready?";
            this.cbxReady.UseVisualStyleBackColor = true;
            this.cbxReady.CheckedChanged += new System.EventHandler(this.Ready);
            // 
            // cbxNoWeddingList
            // 
            this.cbxNoWeddingList.AutoSize = true;
            this.cbxNoWeddingList.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbxNoWeddingList.Location = new System.Drawing.Point(72, 5);
            this.cbxNoWeddingList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxNoWeddingList.Name = "cbxNoWeddingList";
            this.cbxNoWeddingList.Size = new System.Drawing.Size(255, 27);
            this.cbxNoWeddingList.TabIndex = 125;
            this.cbxNoWeddingList.Text = "Order With Wedding List?";
            this.cbxNoWeddingList.UseVisualStyleBackColor = true;
            this.cbxNoWeddingList.CheckedChanged += new System.EventHandler(this.NoWeddingList);
            // 
            // cbxPickUp
            // 
            this.cbxPickUp.AutoSize = true;
            this.cbxPickUp.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.cbxPickUp.Location = new System.Drawing.Point(1107, 13);
            this.cbxPickUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxPickUp.Name = "cbxPickUp";
            this.cbxPickUp.Size = new System.Drawing.Size(224, 27);
            this.cbxPickUp.TabIndex = 126;
            this.cbxPickUp.Text = "Order to be Picked up?";
            this.cbxPickUp.UseVisualStyleBackColor = true;
            this.cbxPickUp.CheckedChanged += new System.EventHandler(this.PickUpChanged);
            // 
            // tbxSearchHeld
            // 
            this.tbxSearchHeld.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSearchHeld.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxSearchHeld.Location = new System.Drawing.Point(420, 40);
            this.tbxSearchHeld.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearchHeld.Name = "tbxSearchHeld";
            this.tbxSearchHeld.Size = new System.Drawing.Size(641, 28);
            this.tbxSearchHeld.TabIndex = 127;
            this.tbxSearchHeld.TextChanged += new System.EventHandler(this.SearchHeld);
            // 
            // tbxSearchWedList
            // 
            this.tbxSearchWedList.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSearchWedList.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.tbxSearchWedList.Location = new System.Drawing.Point(11, 73);
            this.tbxSearchWedList.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearchWedList.Name = "tbxSearchWedList";
            this.tbxSearchWedList.Size = new System.Drawing.Size(386, 28);
            this.tbxSearchWedList.TabIndex = 131;
            this.tbxSearchWedList.TextChanged += new System.EventHandler(this.SearchWeddingList);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblAmount.Location = new System.Drawing.Point(850, 298);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(175, 23);
            this.lblAmount.TabIndex = 136;
            this.lblAmount.Text = "Amount to Move: 0";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnMinus.Location = new System.Drawing.Point(756, 298);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(62, 58);
            this.btnMinus.TabIndex = 134;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.AmountToMoveChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnPlus.Location = new System.Drawing.Point(468, 298);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 58);
            this.btnPlus.TabIndex = 133;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.AmountToMoveChanged);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnMove.Location = new System.Drawing.Point(530, 296);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(222, 63);
            this.btnMove.TabIndex = 135;
            this.btnMove.Text = "Add/Remove from List";
            this.btnMove.Click += new System.EventHandler(this.MoveStock);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.Location = new System.Drawing.Point(1105, 553);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(290, 31);
            this.btnConfirm.TabIndex = 58;
            this.btnConfirm.Text = "Confirm Purchase";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // btnFastMoving
            // 
            this.btnFastMoving.Font = new System.Drawing.Font("Georgia", 11F);
            this.btnFastMoving.Location = new System.Drawing.Point(420, 73);
            this.btnFastMoving.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFastMoving.Name = "btnFastMoving";
            this.btnFastMoving.Size = new System.Drawing.Size(102, 58);
            this.btnFastMoving.TabIndex = 172;
            this.btnFastMoving.Text = "Popular";
            this.btnFastMoving.UseVisualStyleBackColor = true;
            this.btnFastMoving.Click += new System.EventHandler(this.Popular);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Georgia", 11F);
            this.btnClearFilters.Location = new System.Drawing.Point(964, 73);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(97, 58);
            this.btnClearFilters.TabIndex = 171;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnAppliances
            // 
            this.btnAppliances.Font = new System.Drawing.Font("Georgia", 11F);
            this.btnAppliances.Location = new System.Drawing.Point(640, 74);
            this.btnAppliances.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAppliances.Name = "btnAppliances";
            this.btnAppliances.Size = new System.Drawing.Size(101, 58);
            this.btnAppliances.TabIndex = 170;
            this.btnAppliances.Text = "Appliances";
            this.btnAppliances.UseVisualStyleBackColor = true;
            this.btnAppliances.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnBedding
            // 
            this.btnBedding.Font = new System.Drawing.Font("Georgia", 11F);
            this.btnBedding.Location = new System.Drawing.Point(530, 73);
            this.btnBedding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBedding.Name = "btnBedding";
            this.btnBedding.Size = new System.Drawing.Size(102, 58);
            this.btnBedding.TabIndex = 169;
            this.btnBedding.Text = "Bedding";
            this.btnBedding.UseVisualStyleBackColor = true;
            this.btnBedding.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnCutlery
            // 
            this.btnCutlery.Font = new System.Drawing.Font("Georgia", 11F);
            this.btnCutlery.Location = new System.Drawing.Point(854, 73);
            this.btnCutlery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCutlery.Name = "btnCutlery";
            this.btnCutlery.Size = new System.Drawing.Size(102, 58);
            this.btnCutlery.TabIndex = 168;
            this.btnCutlery.Text = "Cutlery";
            this.btnCutlery.UseVisualStyleBackColor = true;
            this.btnCutlery.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnChina
            // 
            this.btnChina.Font = new System.Drawing.Font("Georgia", 11F);
            this.btnChina.Location = new System.Drawing.Point(752, 74);
            this.btnChina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChina.Name = "btnChina";
            this.btnChina.Size = new System.Drawing.Size(94, 58);
            this.btnChina.TabIndex = 167;
            this.btnChina.Text = "China";
            this.btnChina.UseVisualStyleBackColor = true;
            this.btnChina.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // lbxStock
            // 
            this.lbxStock.BackColor = System.Drawing.SystemColors.Control;
            this.lbxStock.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbxStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbxStock.FormattingEnabled = true;
            this.lbxStock.ItemHeight = 18;
            this.lbxStock.Location = new System.Drawing.Point(420, 132);
            this.lbxStock.Margin = new System.Windows.Forms.Padding(2);
            this.lbxStock.Name = "lbxStock";
            this.lbxStock.Size = new System.Drawing.Size(641, 130);
            this.lbxStock.TabIndex = 62;
            this.lbxStock.SelectedIndexChanged += new System.EventHandler(this.WipeAmount);
            this.lbxStock.Enter += new System.EventHandler(this.ChangeBtnMove);
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.lblDateRange.Location = new System.Drawing.Point(129, 25);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(237, 23);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "Please Choose Date Range:";
            // 
            // mcal1
            // 
            this.mcal1.Location = new System.Drawing.Point(9, 67);
            this.mcal1.Name = "mcal1";
            this.mcal1.TabIndex = 3;
            // 
            // mcal2
            // 
            this.mcal2.Location = new System.Drawing.Point(265, 67);
            this.mcal2.Name = "mcal2";
            this.mcal2.TabIndex = 4;
            // 
            // btnSlowMoving
            // 
            this.btnSlowMoving.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnSlowMoving.Location = new System.Drawing.Point(133, 241);
            this.btnSlowMoving.Name = "btnSlowMoving";
            this.btnSlowMoving.Size = new System.Drawing.Size(224, 50);
            this.btnSlowMoving.TabIndex = 5;
            this.btnSlowMoving.Text = "Search by Most Popular";
            this.btnSlowMoving.UseVisualStyleBackColor = true;
            this.btnSlowMoving.Click += new System.EventHandler(this.Moving);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Popular);
            // 
            // pnlMoving
            // 
            this.pnlMoving.Controls.Add(this.button1);
            this.pnlMoving.Controls.Add(this.btnSlowMoving);
            this.pnlMoving.Controls.Add(this.mcal2);
            this.pnlMoving.Controls.Add(this.mcal1);
            this.pnlMoving.Controls.Add(this.lblDateRange);
            this.pnlMoving.Location = new System.Drawing.Point(490, 162);
            this.pnlMoving.Name = "pnlMoving";
            this.pnlMoving.Size = new System.Drawing.Size(504, 303);
            this.pnlMoving.TabIndex = 173;
            this.pnlMoving.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpsonsDownversion.Properties.Resources.glass;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOrderFromWeddingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpsonsDownversion.Properties.Resources.pinkabstract;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1414, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMoving);
            this.Controls.Add(this.btnFastMoving);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnAppliances);
            this.Controls.Add(this.btnBedding);
            this.Controls.Add(this.btnCutlery);
            this.Controls.Add(this.btnChina);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.tbxSearchWedList);
            this.Controls.Add(this.tbxSearchHeld);
            this.Controls.Add(this.cbxPickUp);
            this.Controls.Add(this.cbxNoWeddingList);
            this.Controls.Add(this.cbxReady);
            this.Controls.Add(this.lblMessageError);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxForename);
            this.Controls.Add(this.tbxTelNo);
            this.Controls.Add(this.tbxPostCode);
            this.Controls.Add(this.tbxAdd1);
            this.Controls.Add(this.tbxAdd2);
            this.Controls.Add(this.tbxAdd3);
            this.Controls.Add(this.lblPPostCode);
            this.Controls.Add(this.lblPTelNo);
            this.Controls.Add(this.lblForeName);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.cbxSign);
            this.Controls.Add(this.cbxMessage);
            this.Controls.Add(this.lblStockBuy);
            this.Controls.Add(this.lblStockHeld);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblAdd3);
            this.Controls.Add(this.lblAdd2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAdd1);
            this.Controls.Add(this.lbxWeddingList);
            this.Controls.Add(this.lblWedList);
            this.Controls.Add(this.lbxSelected);
            this.Controls.Add(this.lbxStock);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.btnConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOrderFromWeddingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.pnlMoving.ResumeLayout(false);
            this.pnlMoving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbxSelected;
        private System.Windows.Forms.Label lblWedList;
        private System.Windows.Forms.ListBox lbxWeddingList;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Label lblAdd3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblStockHeld;
        private System.Windows.Forms.Label lblStockBuy;
        private System.Windows.Forms.CheckBox cbxMessage;
        private System.Windows.Forms.CheckBox cbxSign;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label lblForeName;
        private System.Windows.Forms.Label lblPTelNo;
        private System.Windows.Forms.Label lblPPostCode;
        private System.Windows.Forms.TextBox tbxAdd3;
        private System.Windows.Forms.TextBox tbxAdd2;
        private System.Windows.Forms.TextBox tbxAdd1;
        private System.Windows.Forms.TextBox tbxPostCode;
        private System.Windows.Forms.TextBox tbxTelNo;
        private System.Windows.Forms.TextBox tbxForename;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMessageError;
        private System.Windows.Forms.CheckBox cbxReady;
        private System.Windows.Forms.CheckBox cbxNoWeddingList;
        private System.Windows.Forms.CheckBox cbxPickUp;
        private System.Windows.Forms.TextBox tbxSearchHeld;
        private System.Windows.Forms.TextBox tbxSearchWedList;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnFastMoving;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnAppliances;
        private System.Windows.Forms.Button btnBedding;
        private System.Windows.Forms.Button btnCutlery;
        private System.Windows.Forms.Button btnChina;
        private System.Windows.Forms.ListBox lbxStock;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.MonthCalendar mcal1;
        private System.Windows.Forms.MonthCalendar mcal2;
        private System.Windows.Forms.Button btnSlowMoving;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMoving;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}