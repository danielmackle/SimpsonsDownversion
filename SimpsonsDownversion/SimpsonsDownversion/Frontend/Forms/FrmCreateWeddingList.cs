using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace SimpsonsDownversion.Frontend.Forms
{
    public partial class FrmCreateWeddingList : Form
    {
        ///<summary>
        /// Instantiates a wedding list with the minimal amount of information needed.
        /// Edits and Deletes wedding lists when needed.
        /// Fills db with Stock and WeddingListBridgeStock registers as applicable
        /// All fields must be filled and valid.
        ///</summary>
        #region Public Constructor
        public FrmCreateWeddingList()
        {
            InitializeComponent();
            FillLbx();
        }
        #endregion
        #region Private Variables
        private readonly Backend.Classes.ClsDatabase db = new Backend.Classes.ClsDatabase();
        List<Backend.Classes.ClsStock> stockListLeft = new List<Backend.Classes.ClsStock>();
        List<Backend.Classes.ClsStock> stockListRight = new List<Backend.Classes.ClsStock>();
        readonly List<int> listAmount = new List<int>();
        List<Backend.Classes.ClsWeddingList> listEdit = new List < Backend.Classes.ClsWeddingList >();
        int amountToMove = 0;
        bool toRight = true;
        int mode = 0;
        #endregion
        #region Private Class Methods
        //fills lbxStock with all names of all stock items in the db
        //fills stockListLeft with these objects
        private void FillLbx()
        {
            Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
            stockListLeft = sDBA.GetStockObjectsOrderByStockAsc(); //get all registers in a big list as ClsStock and keep in memory for later
            foreach (Backend.Classes.ClsStock s in stockListLeft)
            {
                //visuals of register
                lbxStock.Items.Add(s.StockName + "|" + sDBA.GetManufacturerName(s.ManufacturerId) + "|£" + s.StockPrice + "|" + s.AmountHeld + " Currently Held");
            }
        }
        //Colours a given tbx sender red or green for is the value int??? hmm??? very strange.
        private void CheckTelNoFieldValid(object sender, EventArgs e)
        {
            cbFinished.Checked = false;
            btnConfirm.Visible = false;
            try
            {
                if (Backend.Classes.ClsSystem.ValidateStringToBeTelNo((sender as TextBox).Text))
                {
                    (sender as TextBox).ForeColor = Color.Green;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch { (sender as TextBox).ForeColor = Color.Red; }
        }
        //Colours a given tbx sender green/red for is the value stringy/no strings
        private void CheckStringFieldValid(object sender, EventArgs e)
        {
            cbFinished.Checked = false;
            btnConfirm.Visible = false;
            try
            {
                switch ((sender as TextBox).Name)
                {
                    case "tbxTitle":
                        {
                            if ((sender as TextBox).Text.Length >= 9 && !Backend.Classes.ClsSystem.ValidateStringLetters((sender as TextBox).Text))
                            {
                                throw new Exception();
                            }
                            break;
                        }
                    case "tbxForename":
                        {
                            if ((sender as TextBox).Text.Length >= 31 && !Backend.Classes.ClsSystem.ValidateStringLettersSpaces((sender as TextBox).Text))
                            {
                                throw new Exception();
                            }
                            break;
                        }
                    case "tbxSurname":
                        {
                            if ((sender as TextBox).Text.Length >= 31 && !Backend.Classes.ClsSystem.ValidateStringLettersSpaces((sender as TextBox).Text))
                            {
                                throw new Exception();
                            }
                            break;
                        }
                    case "tbxPostcode":
                        {
                            if (!Backend.Classes.ClsSystem.ValidatePostcodeRegex((sender as TextBox).Text))
                            {
                                throw new Exception();
                            }
                            break;
                        }
                }
                (sender as TextBox).ForeColor = Color.Green;
            }
            catch { (sender as TextBox).ForeColor = Color.Red; }
        }
        //Searches lbxstock with name/postcode to show lesser amount of stock at once. only ones with pattern.
        private void SearchStock(object sender, EventArgs e)
        {
            string toSearch = tbxSearchHeld.Text;
            Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
            List<Backend.Classes.ClsStock> s = sDBA.SearchByModelManufacturer(toSearch);
            stockListLeft = s;
            lbxStock.Items.Clear();
            foreach (Backend.Classes.ClsStock sl in stockListLeft)
            {
                lbxStock.Items.Add(sl.StockName + "|" + sDBA.GetManufacturerName(sl.ManufacturerId) + "|£" + sl.StockPrice + "|" + sl.AmountHeld + " Currently Held");
            }
        }
        //Colours a given tbx sender green/red for is the value datey/no dates
        private void ValidateDateTime(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            cbFinished.Checked = false;
            if ((sender as DateTimePicker).Value >= DateTime.UtcNow.AddDays(1) && Backend.Classes.ClsSystem.ValidateDateTime((sender as DateTimePicker).Value))
            {
                (sender as DateTimePicker).CalendarTitleBackColor = Color.Green;
                (sender as DateTimePicker).CalendarTitleForeColor = Color.Green;
                (sender as DateTimePicker).CalendarTrailingForeColor = Color.Green;
                (sender as DateTimePicker).CalendarForeColor = Color.Green;
                lblDateRed.Visible = false;
            }
            else
            {
                (sender as DateTimePicker).CalendarTitleBackColor = Color.Red;
                (sender as DateTimePicker).CalendarTitleForeColor = Color.Red;
                (sender as DateTimePicker).CalendarTrailingForeColor = Color.Red;
                (sender as DateTimePicker).CalendarForeColor = Color.Red;
                lblDateRed.Visible = true;
            }
        }
        //Checks if every field is valid before making the complete button visible
        private void Finished(object sender, EventArgs e)
        {
            if (tbxTitle.ForeColor == Color.Green && tbxForename.ForeColor == Color.Green && tbxSurname.ForeColor == Color.Green && tbxTelNo.ForeColor == Color.Green && tbxTitle.ForeColor == Color.Green && tbxPostcode.ForeColor == Color.Green && dtpEnd.CalendarForeColor == Color.Green)
            {
                btnConfirm.Visible = true;
            }
            else { btnConfirm.Visible = false; (sender as CheckBox).Checked = false; }
        }
        //When the '+' or '-' buttons are pressed, update lists holding the values to be changed and display to the user
        private void AmountToMoveChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnPlus") { amountToMove++; }
                else { amountToMove--; }
                if (toRight)
                {
                    if (stockListLeft[lbxStock.SelectedIndex].AmountHeld < amountToMove)
                    {
                        amountToMove = stockListLeft[lbxStock.SelectedIndex].AmountHeld;
                    }
                }
                else
                {
                    if (stockListRight[lbxSelected.SelectedIndex].AmountHeld < amountToMove)
                    {
                        amountToMove = stockListRight[lbxSelected.SelectedIndex].AmountHeld;
                    }
                }
                if (amountToMove < 0) { amountToMove = 0; }
                lblAmount.Text = "Amount to Move: " + amountToMove.ToString();
            }
            catch { lblAmount.Text = "Amount to Move: " + amountToMove.ToString(); }
        }
        //When stock is moved across lbx, this method runs.
        //Does the movement, updates lists.
        private void MoveStock(object sender, EventArgs e)
        {
            try
            {
                Backend.Database.WeddingListBridgeStockDBAccess wlBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                if (toRight)
                {
                    bool replaced = false;
                    for (int i = 0; i < stockListRight.Count; i++)
                    {
                        try
                        {
                            if (stockListRight[i].StockId == stockListLeft[lbxStock.SelectedIndex].StockId)
                            {
                                replaced = true;
                                if (amountToMove != 0)
                                {
                                    listAmount[i] += amountToMove;
                                    Backend.Classes.ClsStock stk = stockListRight[i];
                                    if (listAmount[i] > stk.AmountHeld) { listAmount[i] = stk.AmountHeld; }
                                    lbxSelected.Items[i] = stk.StockName + " | " + sDBA.GetManufacturerName(stk.ManufacturerId) + "| £" + stk.StockPrice + " | " + listAmount[i] + " to be Added";
                                }
                            }
                        }
                        catch { }
                    }
                    if (!replaced)
                    {
                        if (amountToMove != 0)
                        {
                            listAmount.Add(amountToMove);
                            Backend.Classes.ClsStock stk = stockListLeft[lbxStock.SelectedIndex];
                            lbxSelected.Items.Add(stk.StockName + " | " + sDBA.GetManufacturerName(stk.ManufacturerId) + "| £" + stk.StockPrice + " | " + amountToMove + " to be Added");
                            stockListRight.Add(stk);
                        }
                    }
                }
                else
                {
                    Backend.Classes.ClsStock stk = stockListRight[lbxSelected.SelectedIndex];
                    if (listAmount[lbxSelected.SelectedIndex] <= amountToMove)
                    {
                        stockListRight.Remove(stk);
                        stockListLeft.Add(stk);
                        listAmount.RemoveAt(lbxSelected.SelectedIndex);
                        lbxSelected.Items.RemoveAt(lbxSelected.SelectedIndex);
                    }
                    else
                    {
                        listAmount[lbxSelected.SelectedIndex] -= amountToMove;
                        lbxSelected.Items.Clear();
                        int i= 0;
                        foreach(Backend.Classes.ClsStock s in stockListRight)
                        {
                            lbxSelected.Items.Add(s.StockName + " | " + sDBA.GetManufacturerName(s.ManufacturerId) + "| £" + s.StockPrice + " | " + listAmount[i] + " to be Added");
                            i++;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Please select an item to move."); }
        }
        //Find if moving stock to or from the right.
        private void ChangeBtnMove(object sender, EventArgs e)
        {
            if ((sender as ListBox).Name == "lbxStock") { toRight = true; }
            else { toRight = false; }
        }
        //Main part of form. Updates the database with the modifiers and values given.
        private void Confirm(object sender, EventArgs e)
        {
            try
            {
                string _title = tbxTitle.Text;
                string _surname = tbxSurname.Text;
                string _forename = tbxForename.Text;
                string _postcode = tbxPostcode.Text;
                string _telNo = tbxTelNo.Text;
                DateTime dateEnd = dtpEnd.Value;
                Backend.Database.WeddingListBridgeStockDBAccess wBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
                if (mode != 0)
                {
                    wDBA.DeleteWeddingListFromId(wDBA.GetWeddingListIdFromPostcode(listEdit[lbxEdit.SelectedIndex].ClientPostCode));
                    wBSDBA.DeleteWeddingListStockFromWeddingListId(wDBA.GetWeddingListIdFromPostcode(listEdit[lbxEdit.SelectedIndex].ClientPostCode));
                }
                if (mode != 2)
                {
                    List<Backend.Classes.ClsWeddingList> l = wDBA.GetAllWeddingListsAsList();
                    Backend.Classes.ClsWeddingList wl = new Backend.Classes.ClsWeddingList(_title, _surname, _forename, _telNo, _postcode, dateEnd);
                    foreach (Backend.Classes.ClsWeddingList c in l)
                    {
                        if (c.ClientPostCode == wl.ClientPostCode && c.ClientForename == wl.ClientForename && c.ClientSurname == wl.ClientSurname)
                        {
                            throw new AppDomainUnloadedException();
                        }
                    }
                    wDBA.InsertIntoWeddingListWithWeddingList(wl);
                    int count = 0;
                    foreach (Backend.Classes.ClsStock s in stockListRight)
                    {
                        wBSDBA.InsertIntoWeddingListBridgeStock(wDBA.GetWeddingListIdFromPostcode(wl.ClientPostCode), s.StockId, listAmount[count]);
                        count++;
                    }
                    LbxEditFill();
                    if (mode == 0) { lblSuccess.Text = "The Wedding List Has Successfully Been Created!"; }
                    if (mode == 1) { lblSuccess.Text = "The Wedding List Has Successfully Been Edited!"; }
                    if (mode == 2) { lblSuccess.Text = "The Wedding List Has Successfully Been Deleted!"; }
                    lblSuccess.Visible = true;
                    if (mode != 2)
                    {
                        DialogResult dialogResult = MessageBox.Show("Would you like to print the contents of the Wedding List? ", "Print Report?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Backend.Classes.ClsSystem.wlToPrint = wl;
                            Backend.Reports.FormReport frmReport = new Backend.Reports.FormReport();
                            frmReport.ShowDialog();
                        }
                    }
                }
                Wipe();
            }
            catch (AppDomainUnloadedException) { MessageBox.Show("Please do not enter Duplicate Wedding Lists.", "Exception Handled."); }
            catch (FormatException) { MessageBox.Show("Please do not enter null values.", "Exception Handled."); }
            catch { MessageBox.Show("Please enter valid details.", "Exception Handled."); }
        }
        //Clears values after confirmation.
        private void Wipe()
        {
            tbxTitle.Clear();
            tbxForename.Clear();
            tbxSurname.Clear();
            tbxPostcode.Clear();
            tbxTelNo.Clear();
            dtpEnd.Value = DateTime.Now;
            lbxSelected.ClearSelected();
            lbxSelected.Items.Clear();
            btnConfirm.Visible = false;
            stockListRight.Clear();
            btnConfirm.Visible = false;
            amountToMove = 0;
            cbxDelete.Checked = false;
            cbEdit.Checked = false;
            listAmount.Clear();
        }
        //Button to return to main menu.
        private void ToMenu(object sender, EventArgs e)
        {
            Backend.Classes.ClsSystem.OpenNewForm(this, new FrmTitlePage());
        }
        //Make the edit controls visible
        private void EditVisible(object sender, EventArgs e)
        {
            cbFinished.Checked = false;
            btnConfirm.Visible = false;
            if ((sender as CheckBox).Checked)
            {
                lbxEdit.Visible = true;
                lblEdit.Visible = true;
                tbxEditSearch.Visible = true;
                lblEditSearch.Visible = true;
                cbxDelete.Visible = true;
                btnConfirm.Text = "Confirm Edit";
                mode = 1;
            }
            else
            {
                lbxEdit.Visible = false;
                lbxEdit.Visible = false;
                lblEdit.Visible = false;
                tbxEditSearch.Visible = false;
                lblEditSearch.Visible = false;
                cbxDelete.Visible = false;
                btnConfirm.Text = "Confirm Creation";
                mode = 0;
            }
            LbxEditFill();
        }
        //Fill lbxEdit with wedding lists.
        private void LbxEditFill()
        {
            Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
            try
            {
                listEdit = wDBA.GetAllWeddingListsAsList();
                FillLbxEdit();
            }
            catch { }
        }
        //Saves lines. Refresh the table lbxEdit.
        private void FillLbxEdit()
        {
            lbxEdit.Items.Clear();
            for (int i = 0; i < listEdit.Count; i++) { lbxEdit.Items.Add(listEdit[i].ClientTitle + " " + listEdit[i].ClientForename + " " + listEdit[i].ClientSurname + " (" + listEdit[i].ClientPostCode + ")"); }
        }
        //Search lbxEdit vis name or postcode.
        private void LbxSearch(object sender, EventArgs e)
        {
            Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
            listEdit = wDBA.SearchByNamePostcode((sender as TextBox).Text);
            lbxEdit.Items.Clear();
            FillLbxEdit();
        }
        //When a wedding list is selected to edit, this runs. Fills all fields with the old values.
        private void FillEverything(object sender, EventArgs e)
        {
            try
            {
                Backend.Database.WeddingListBridgeStockDBAccess wBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                Backend.Classes.ClsWeddingList wl = listEdit[lbxEdit.SelectedIndex];
                cbFinished.Checked = false;
                btnConfirm.Visible = false;
                tbxTitle.Text = wl.ClientTitle;
                tbxForename.Text = wl.ClientForename;
                tbxSurname.Text = wl.ClientSurname;
                tbxPostcode.Text = wl.ClientPostCode;
                tbxTelNo.Text = Convert.ToString(wl.ClientTelNo);
                dtpEnd.Value = wl.DateToFinish;
                lbxSelected.Items.Clear();
                stockListRight.Clear();
                listAmount.Clear();

                stockListRight = wBSDBA.GetListStockFromWeddingListId(wDBA.GetWeddingListIdFromPostcode(wl.ClientPostCode));
                foreach (Backend.Classes.ClsStock stock in stockListRight)
                {
                    listAmount.Add(wBSDBA.GetWeddingListBridgeStockAmountFromStockIdWeddingListId(stock.StockId, wDBA.GetWeddingListIdFromPostcode(wl.ClientPostCode)));
                }
                lbxSelected.Items.Clear();
                int i = 0;
                foreach (Backend.Classes.ClsStock s in stockListRight)
                {
                    lbxSelected.Items.Add(s.StockName + " | " + sDBA.GetManufacturerName(s.ManufacturerId) + "| £" + s.StockPrice + " | " + listAmount[i] + " to be Added");
                    i++;
                }
            }
            catch { }
        }
        //When delete is selected, make many controls visible or invisible. Change mode to delete (2).
        private void Delete(object sender, EventArgs e)
        {
            if (cbxDelete.Checked)
            {
                btnAppliances.Visible = false;
                btnBedding.Visible = false;
                btnChina.Visible = false;
                btnClearFilters.Visible = false;
                btnCutlery.Visible = false;
                btnFastMoving.Visible = false;
                tbxTitle.Visible = false;
                tbxPostcode.Visible = false;
                tbxTelNo.Visible = false;
                lbxStock.Visible = false;
                lbxSelected.Visible = false;
                dtpEnd.Visible = false;
                btnPlus.Visible = false;
                btnMinus.Visible = false;
                btnConfirm.Visible = true;
                btnMove.Visible = false;
                cbFinished.Visible = false;
                lblItemsInStock.Visible = false;
                lblItemsSelected.Visible = false;
                lblAmount.Visible = false;
                lblTitle.Visible = false;
                lblForename.Visible = false;
                lblSurname.Visible = false;
                LblTelNo.Visible = false;
                lblPostcode.Visible = false;
                lblDate.Visible = false;
                dtpEnd.Visible = false;
                lblDateRed.Visible = false;
                tbxForename.Visible = false;
                tbxSurname.Visible = false;
                tbxSearchHeld.Visible = false;
                cbEdit.Visible = false;
                btnConfirm.Text = "Confirm Deletion";
                mode = 2;
            }
            else
            {
                cbEdit.Visible = true;
                btnAppliances.Visible = true;
                btnBedding.Visible = true;
                btnChina.Visible = true;
                btnClearFilters.Visible = true;
                btnCutlery.Visible = true;
                btnFastMoving.Visible = true;
                tbxTitle.Visible = true;
                tbxPostcode.Visible = true;
                tbxTelNo.Visible = true;
                lbxStock.Visible = true;
                lbxSelected.Visible = true;
                dtpEnd.Visible = true;
                btnConfirm.Visible = false;
                btnPlus.Visible = true;
                btnMinus.Visible = true;
                btnMove.Visible = true;
                cbFinished.Visible = true;
                lblItemsInStock.Visible = true;
                lblItemsSelected.Visible = true;
                lblAmount.Visible = true;
                lblTitle.Visible = true;
                lblForename.Visible = true;
                lblSurname.Visible = true;
                LblTelNo.Visible = true;
                lblPostcode.Visible = true;
                lblDate.Visible = true;
                dtpEnd.Visible = true;
                lblDateRed.Visible = true;
                tbxForename.Visible = true;
                tbxSurname.Visible = true;
                tbxSearchHeld.Visible = true;
                btnConfirm.Text = "Confirm Edit";
                mode = 1;
            }
        }

        //Searches lbxedit with name/postcode to show lesser amount of stock at once. only ones with pattern.
        private void SearchEdit(object sender, EventArgs e)
        {
            try
            {
                string toSearch = tbxEditSearch.Text;
                Backend.Database.WeddingListDBAccess wlDBA = new Backend.Database.WeddingListDBAccess(db);
                List<Backend.Classes.ClsWeddingList> sl = wlDBA.SearchByNamePostcode(toSearch);
                listEdit = sl;
                lbxEdit.Items.Clear();
                FillLbxEdit();
                lbxEdit.SelectedIndex = -1;
            }
            catch { }
        }
        #endregion

        private void WipeAmount(object sender, EventArgs e)
        {
            amountToMove = 0;
            lblAmount.Text = "Amount to Move: " + amountToMove.ToString();
        }
        private bool searchByFastMoving = false;
        private void ApplyFilter(object sender, EventArgs e)
        {
            if(stockListLeft != null)
            {
                stockListLeft.Clear();
                lbxStock.Items.Clear();
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                if ((sender as Button).Name == "btnFastMoving")
                {
                    if (searchByFastMoving)
                    {
                        searchByFastMoving = false;
                    }
                    else
                    {
                        searchByFastMoving = true;
                    }
                    stockListLeft.Clear();
                    stockListRight.Clear();
                    lbxSelected.Items.Clear();
                    lbxStock.Items.Clear();
                    listAmount.Clear();
                    stockListLeft = sDBA.SearchByFastMovingList(true, DateTime.Parse("01/01/2020"), DateTime.Now);
                    foreach (Backend.Classes.ClsStock sl in stockListLeft)
                    {
                        lbxStock.Items.Add(sl.StockName + " | " + sDBA.GetManufacturerName(sl.ManufacturerId) + " | £" + sl.StockPrice + " | " + sl.AmountHeld + " Currently Held");
                        listAmount.Add(sl.AmountHeld);
                    }
                }
                else if ((sender as Button).Name != "btnClearFilters")
                {
                    try
                    {
                        stockListLeft = sDBA.ApplyFilterList(sender as Button, searchByFastMoving);
                        if (stockListLeft != null)
                        {
                            foreach (Backend.Classes.ClsStock sl in stockListLeft)
                            {
                                lbxStock.Items.Add(sl.StockName + " | " + sDBA.GetManufacturerName(sl.ManufacturerId) + " | £" + sl.StockPrice + " | " + sl.AmountHeld + " Currently Held");
                            }
                        }
                    }
                    catch { }
                }
                else
                {
                    stockListLeft = sDBA.GetStockObjectsOrderByStockAsc();
                    foreach (Backend.Classes.ClsStock sl in stockListLeft)
                    {
                        lbxStock.Items.Add(sl.StockName + " | " + sDBA.GetManufacturerName(sl.ManufacturerId) + " | £" + sl.StockPrice + " | " + sl.AmountHeld + " Currently Held");
                    }
                }
            }
            searchByFastMoving = false;
        }
    }
}