using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace SimpsonsDownversion.Frontend.Forms
{
    public partial class FrmOrderFromWeddingList : Form
    {
        #region Public Constructions
        public FrmOrderFromWeddingList()
        {
            InitializeComponent();
            FillLbxWeddingList();
            pickUp = false;
            useWedList = false;
            cbxPickUp.Checked = false;
            cbxPickUp.Visible = false;
            lblWedList.Visible = false;
            lbxWeddingList.Visible = false;
            tbxSearchWedList.Visible = false;
            lblName.Visible = false;
            lblPostCode.Visible = false;
            lblDate.Visible = false;
            lblTelNo.Visible = false;
            cbxReady.Visible = false;
            btnConfirm.Visible = true;
            lblStockHeld.Text = "All Available Items in Stock:";
            Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
            List<Backend.Classes.ClsStock> ls = sDBA.GetStockObjectsOrderByStockAsc();
            int i = 0;
            foreach (Backend.Classes.ClsStock s in ls)
            {
                stockListHeld.Add(s); 
                lbxStock.Items.Add(s.StockName + " | " + sDBA.GetManufacturerName(s.ManufacturerId) + " | £" + s.StockPrice + " | " + stockListHeld[i].AmountHeld + " Held In Stock");
                i++;
            }
        }
        #endregion
        #region Private Variables
        private readonly Backend.Classes.ClsDatabase db = new Backend.Classes.ClsDatabase();
        private List<Backend.Classes.ClsWeddingList> listWeddingList = new List<Backend.Classes.ClsWeddingList>();
        private List<Backend.Classes.ClsStock> stockListHeld = new List<Backend.Classes.ClsStock>();
        private List<Backend.Classes.ClsStock> stockListToBuy = new List<Backend.Classes.ClsStock>();
        readonly private List<int> listAmountToBuy = new List<int>();
        private readonly List<int> listAmountWanted = new List<int>();
        private int amountToMove = 0;
        private bool toRight;
        private bool pickUp = false;
        private bool useWedList = true;
        private decimal totalPrice = 0;
        #endregion
        #region Private Methods
        //Runs upon initiation. Fills lbxWeddingList with all wedding lists held in the db. If none, empty lbx.
        private void FillLbxWeddingList()
        {
            lbxWeddingList.Items.Clear();
            Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
            listWeddingList = wDBA.GetAllWeddingListsAsList();
            try
            {
                foreach (Backend.Classes.ClsWeddingList w in listWeddingList)
                {
                    lbxWeddingList.Items.Add(w.ClientTitle + " " + w.ClientForename + " " + w.ClientSurname + " (" + w.ClientPostCode + ")");
                }
            }
            catch { lbxWeddingList.Items.Clear(); }
        }
        //Fills the data at the top right with values from the wedding list selected.
        private void FillEverything(object sender, EventArgs e)
        {
            cbxReady.Visible = false;
            cbxReady.Checked = false;
            cbxPickUp.Checked = false;
            EventArgs d = new EventArgs();
            try
            {
                totalPrice = 0;
                RefreshPrice();
                amountToMove = 0;
                lblAmount.Text = "Amount to Move: 0";
                Backend.Database.WeddingListBridgeStockDBAccess wBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                Backend.Database.WeddingListDBAccess wBSDB = new Backend.Database.WeddingListDBAccess(db);
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                Backend.Classes.ClsWeddingList selectedWedList = listWeddingList[lbxWeddingList.SelectedIndex];
                lblName.Text = "Name of Client: " + selectedWedList.ClientTitle + " " + selectedWedList.ClientForename + " " + selectedWedList.ClientSurname;
                lblTelNo.Text = "Telephone Number of Client: " + selectedWedList.ClientTelNo;
                lblPostCode.Text = "PostCode Of Client: " + selectedWedList.ClientPostCode;
                lblDate.Text = "Date of Wedding: " + selectedWedList.DateToFinish.ToString();
                ClearAll();
                AllVisible();
                int wid = wBSDB.GetWeddingListIdFromPostcode(selectedWedList.ClientPostCode);
                stockListHeld = wBSDBA.GetListStockFromWeddingListId(wid);
                int i = 0;
                lbxStock.Items.Clear();
                lbxSelected.Items.Clear();
                stockListToBuy.Clear();
                listAmountToBuy.Clear();
                listAmountWanted.Clear();
                List<Backend.Classes.ClsStock> ToRemove = new List<Backend.Classes.ClsStock>();
                int amt = 0;
                foreach (Backend.Classes.ClsStock cs in stockListHeld)
                {
                    amt = wBSDBA.GetWeddingListBridgeStockAmountFromStockIdWeddingListId(cs.StockId, wid);
                    if (amt > 0)
                    {
                        listAmountWanted.Add(amt);
                        lbxStock.Items.Add(cs.StockName + " | " + sDBA.GetManufacturerName(cs.ManufacturerId) + " | £" + cs.StockPrice + " | " + amt + " Needed for the Wedding | " + stockListHeld[i].AmountHeld + " Held in Stock");
                    }
                    else
                    {
                        ToRemove.Add(cs);
                    }
                    i++;
                }
                foreach (Backend.Classes.ClsStock cs in ToRemove)
                {
                    stockListHeld.Remove(cs);
                }
            }
            catch { }
            PickUpChanged(this, d);
        }
        //Saves lines. Makes visible once lbxweddinglist chosen
        private void AllVisible()
        {
            tbxForename.Visible = true;
            lblForeName.Visible = true;
            tbxTelNo.Visible = true;
            lblPTelNo.Visible = true;
            lblAdd1.Visible = true;
            tbxAdd1.Visible = true;
            lblAdd2.Visible = true;
            tbxAdd2.Visible = true;
            lblAdd3.Visible = true;
            tbxAdd3.Visible = true;
        }
        //After order made, clears values.
        private void ClearAll()
        {
            tbxSurname.Visible = false;
            lblSurname.Visible = false;
            tbxForename.Clear();
            tbxSurname.Clear();
            tbxPostCode.Clear();
            tbxTelNo.Clear();
            tbxAdd1.Clear();
            tbxAdd2.Clear();
            tbxAdd3.Clear();
            tbxMessage.Clear();
            cbxMessage.Checked = false;
            tbxPostCode.Visible = false;
            lblPPostCode.Visible = false;
            cbxPickUp.Checked = false;
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
                    if (useWedList)
                    {
                        if (stockListHeld[lbxStock.SelectedIndex].AmountHeld < amountToMove || listAmountWanted[lbxStock.SelectedIndex] < amountToMove || amountToMove < 0)
                        {
                            amountToMove = 0;
                        }
                    }
                    else
                    {
                        if (stockListHeld[lbxStock.SelectedIndex].AmountHeld < amountToMove || amountToMove < 0)
                        {
                            amountToMove = stockListHeld[lbxStock.SelectedIndex].AmountHeld;
                        }
                    }
                }
                else
                {
                    if (useWedList)
                    {
                        if (stockListToBuy[lbxSelected.SelectedIndex].AmountHeld < amountToMove || listAmountWanted[lbxSelected.SelectedIndex] < amountToMove && amountToMove < 0)
                        {
                            if (stockListToBuy[lbxSelected.SelectedIndex].AmountHeld < listAmountWanted[lbxSelected.SelectedIndex])
                            {
                                amountToMove = stockListToBuy[lbxSelected.SelectedIndex].AmountHeld;
                            }
                            else
                            {
                                amountToMove = listAmountWanted[lbxSelected.SelectedIndex];
                            }
                        }
                    }
                    else
                    {
                        if (stockListToBuy[lbxSelected.SelectedIndex].AmountHeld < amountToMove || amountToMove < 0)
                        {
                            amountToMove = stockListToBuy[lbxSelected.SelectedIndex].AmountHeld;
                        }
                    }
                }
                if (amountToMove < 0) { amountToMove = 0; }
                lblAmount.Text = "Amount to Move: " + amountToMove.ToString();
            }
            catch { lblAmount.Text = "Amount to Move: 0"; }
        }
        //When stock is moved across lbx, this method runs.
        //Does the movement, updates lists and total price.
        private void MoveStock(object sender, EventArgs e)
        {
            try
            {
                Backend.Database.WeddingListBridgeStockDBAccess wlBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                if (toRight)
                {
                    bool replaced = false;
                    for (int i = 0; i < stockListToBuy.Count; i++)
                    {
                        try
                        {
                            if (stockListToBuy[i].StockId == stockListHeld[lbxStock.SelectedIndex].StockId)
                            {
                                replaced = true;
                                if (amountToMove != 0)
                                {
                                    Backend.Classes.ClsStock stk = stockListToBuy[i];
                                    if (useWedList)
                                    {
                                        if (listAmountToBuy[i] >= stk.AmountHeld) { listAmountToBuy[i] = stk.AmountHeld; }
                                        else if (listAmountToBuy[i] >= listAmountWanted[i]) { listAmountToBuy[i] = listAmountWanted[i]; }
                                        else
                                        {
                                            totalPrice += stk.StockPrice * amountToMove;
                                            listAmountToBuy[i] += amountToMove;
                                        }
                                        lbxSelected.Items[i] = stk.StockName + " | " + sDBA.GetManufacturerName(stk.ManufacturerId) + "| £" + stk.StockPrice + " | " + listAmountToBuy[i] + " to be Purchased";
                                    }
                                    else
                                    {
                                        totalPrice += stk.StockPrice * amountToMove;
                                        listAmountToBuy[i] += amountToMove;
                                        lbxSelected.Items[i] = stk.StockName + " | " + sDBA.GetManufacturerName(stk.ManufacturerId) + "| £" + stk.StockPrice + " | " + listAmountToBuy[i] + " to be Purchased";
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                    if (!replaced)
                    {
                        if (amountToMove != 0)
                        {
                            Backend.Classes.ClsStock stk = stockListHeld[lbxStock.SelectedIndex];
                            lbxSelected.Items.Add(stk.StockName + " | " + sDBA.GetManufacturerName(stk.ManufacturerId) + "| £" + stk.StockPrice + " | " + amountToMove + " to be Purchased");
                            totalPrice += stk.StockPrice * amountToMove;
                            stockListToBuy.Add(stk);
                            listAmountToBuy.Add(amountToMove);
                        }
                    }
                }
                else
                {
                    Backend.Classes.ClsStock stk = stockListToBuy[lbxSelected.SelectedIndex];
                    if (listAmountToBuy[lbxSelected.SelectedIndex] <= amountToMove)
                    {
                        totalPrice -= stk.StockPrice * amountToMove;
                        stockListToBuy.Remove(stk);
                        stockListHeld.Add(stk);
                        listAmountToBuy.RemoveAt(lbxSelected.SelectedIndex);
                        lbxSelected.Items.RemoveAt(lbxSelected.SelectedIndex);
                    }
                    else
                    {
                        totalPrice -= stk.StockPrice * amountToMove;
                        listAmountToBuy[lbxSelected.SelectedIndex] -= amountToMove;
                        lbxSelected.Items.Clear();
                        int i = 0;
                        foreach (Backend.Classes.ClsStock s in stockListToBuy)
                        {
                            lbxSelected.Items.Add(s.StockName + " | " + sDBA.GetManufacturerName(s.ManufacturerId) + "| £" + s.StockPrice + " | " + listAmountToBuy[i] + " to be Purchased");
                            i++;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Please select an item to move."); }
            RefreshPrice();
        }
        //Find if moving stock to or from the right.
        private void ChangeBtnMove(object sender, EventArgs e)
        {
            if ((sender as ListBox).Name == "lbxStock") { toRight = true; }
            else { toRight = false; }
        }
        //When a string field is changed, make red/green for valid/not.
        private void StringChanged(object sender, EventArgs e)
        {
            cbxReady.Checked = false;
            try
            {
                if (Backend.Classes.ClsSystem.ValidateStringLetters((sender as TextBox).Text))
                {
                    switch ((sender as TextBox).Name)
                    {
                        case "tbxForename":
                            {
                                if ((sender as TextBox).Text.Length >= 20)
                                {
                                    throw new Exception();
                                }
                                break;
                            }
                        case "tbxSurname":
                            {
                                if ((sender as TextBox).Text.Length >= 31)
                                {
                                    throw new Exception();
                                }
                                break;
                            }
                    }
                (sender as TextBox).ForeColor = Color.Green;
                }
            }
            catch { (sender as TextBox).ForeColor = Color.Red; }
        }
        //Make controls to do with message visible/invisible.
        private void MakeMessageVisible(object sender, EventArgs e)
        {
            if (cbxMessage.Checked == true)
            {
                tbxMessage.Visible = true;
                cbxSign.Visible = true;
            }
            else
            {
                tbxMessage.Visible = false;
                cbxSign.Visible = false;
                lblMessageError.Visible = false;
            }
            tbxMessage.Clear();
        }
        //Main part of code. Creates purchase and edits stock amounts via sql./////////
        private void Confirm(object sender, EventArgs e)
        {
            Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
            try
            {
                //int delete =0;
                Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
                Backend.Database.WeddingListBridgeStockDBAccess wBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                Backend.Database.PurchaseDBAccess pDBA = new Backend.Database.PurchaseDBAccess(db);
                Backend.Database.PurchaseBridgeStockDBAccess wlBSDBA = new Backend.Database.PurchaseBridgeStockDBAccess(db);
                //insert purchase
                pDBA.InsertPurchase(false);
                //insert purchasebstock
                int pid = pDBA.GetBackPid();
                int q = 0;
                int o = 0;
                foreach (Backend.Classes.ClsStock s in stockListToBuy)//repeat for each stock obj
                {
                    Backend.Classes.Database.ClsPurchaseBridgeStock pBS = new Backend.Classes.Database.ClsPurchaseBridgeStock(s.StockId, pid, listAmountToBuy[q]);
                    wlBSDBA.InsertPurchaseBridgeStock(pBS);
                    sDBA.UpdateAmount(-listAmountToBuy[q], s.StockId);
                    if (useWedList)
                    {
                        wlBSDBA.AlterAmount(-listAmountToBuy[q], s.StockId);
                        listAmountWanted[q] -= listAmountToBuy[q];
                        if(listAmountWanted[q] <= 0)
                        {
                            o++;
                        }
                    }
                    q++;
                }
                if (useWedList)//take wedlist and fill all fields
                {
                    //accesses
                    Backend.Database.WeddingListBridgePurchaseDBAccess wlPDBA = new Backend.Database.WeddingListBridgePurchaseDBAccess(db);
                    //get ids
                    pid = pDBA.GetBackPid();
                    Backend.Classes.ClsWeddingList selectedWedList = listWeddingList[lbxWeddingList.SelectedIndex];
                    int wid = wDBA.GetWeddingListIdFromPostcode(selectedWedList.ClientPostCode);
                    //insert wlbpurhase
                    Backend.Classes.Database.ClsWeddingListBridgePurchase wLBP;
                    //choose which fields to enter
                    if (pickUp)//if lots of fields
                    {
                        //fields
                        string Pforename = tbxForename.Text;
                        string Psurname = tbxPostCode.Text;
                        string Ppostcode = tbxPostCode.Text;
                        string Padd1 = tbxAdd1.Text;
                        string Padd2 = tbxAdd2.Text;
                        string Padd3 = tbxAdd3.Text;
                        long PtelNo = Convert.ToInt64(tbxTelNo.Text);
                        if (cbxMessage.Checked)//if message too
                        {
                            string Pmessage = tbxMessage.Text;
                            bool Psigned = cbxSign.Checked;
                            wLBP = new Backend.Classes.Database.ClsWeddingListBridgePurchase(wid, pid, Pforename, Psurname, Padd1, Padd2, Padd3, Ppostcode, PtelNo, Psigned, Pmessage);
                            wlPDBA.InsertWeddingListBridgePurchase(wLBP, 0);
                        }
                        else
                        {
                            wLBP = new Backend.Classes.Database.ClsWeddingListBridgePurchase(wid, pid, Pforename, Psurname, Padd1, Padd2, Padd3, Ppostcode, PtelNo);
                            wlPDBA.InsertWeddingListBridgePurchase(wLBP, 1);
                        }
                    }
                    else//if none
                    {
                        wLBP = new Backend.Classes.Database.ClsWeddingListBridgePurchase(wid, pid);
                        wlPDBA.InsertWeddingListBridgePurchase(wLBP, 2);
                    }
                    //if (delete == q)
                  //  {
                  //      wDBA.DeleteWeddingListFromId(wid);
                   // }
                }
                ClearAll();
                List<Backend.Classes.ClsStock> ls = sDBA.GetStockObjectsOrderByStockAsc();
                stockListHeld.Clear();
                stockListToBuy.Clear();
                listAmountToBuy.Clear();
                lbxSelected.Items.Clear();
                lbxStock.Items.Clear();
                int i = 0;
                totalPrice = 0;
                RefreshPrice();
                pickUp = false;
                useWedList = false;
                cbxNoWeddingList.Checked = false;
                cbxReady.Checked = false;
                FillLbxWeddingList();
                foreach (Backend.Classes.ClsStock s in ls)
                {
                    stockListHeld.Add(s);
                    lbxStock.Items.Add(s.StockName + " | " + sDBA.GetManufacturerName(s.ManufacturerId) + " | £" + s.StockPrice + " | " + stockListHeld[i].AmountHeld + " Held in Stock");
                    i++;
                }
                int amtAfter = 0;
                Backend.Database.StockHistoryDBAccess shDBA = new Backend.Database.StockHistoryDBAccess(db);

                foreach (Backend.Classes.ClsStock s in stockListToBuy)
                {
                    amtAfter = sDBA.GetAmountHeldFromId(s.StockId);
                    if (amtAfter < s.RestockValue1)
                    {
                        shDBA.StockLevelOvercome(s.StockId);
                    }
                }
                MessageBox.Show("Your purchase has been successful.", "Thank You!");
            }
            catch
            {
                ClearAll();
                List<Backend.Classes.ClsStock> ls = sDBA.GetStockObjectsOrderByStockAsc();
                stockListHeld.Clear();
                stockListToBuy.Clear();
                lbxSelected.Items.Clear();
                lbxStock.Items.Clear();
                FillLbxWeddingList();
                int i = 0;
                totalPrice = 0;
                RefreshPrice();
                foreach (Backend.Classes.ClsStock s in ls)
                {
                    stockListHeld.Add(s);
                    lbxStock.Items.Add(s.StockName + " | " + sDBA.GetManufacturerName(s.ManufacturerId) + " | £" + s.StockPrice + " | " + stockListHeld[i].AmountHeld + " Held in Stock");
                    i++;
                }
                MessageBox.Show("Your purchase has been unsuccessful.", "Sorry!");
            }
        }
        //Leaves form, opens new.
        private void BtnExitClick(object sender, EventArgs e)
        {
            Backend.Classes.ClsSystem.OpenNewForm(this,new FrmTitlePage());
        }
        //Checks that the telno entered is a digit of certian length
        private void TelNoChanged(object sender, EventArgs e)
        {
            cbxReady.Checked = false;
            try
            {
                if ((sender as TextBox).Text.Length != 11)
                {
                    throw new Exception();
                }
                if (!Backend.Classes.ClsSystem.ValidateTelNo((sender as TextBox).Text))
                {
                    throw new Exception();
                }
                (sender as TextBox).ForeColor = Color.Green;
            }
            catch
            {
                (sender as TextBox).ForeColor = Color.Red;
            }
        }
        //If postcode valid, green. Invalid, red.
        private void PostcodeChanged(object sender, EventArgs e)
        {
            cbxReady.Checked = false;
            if (Backend.Classes.ClsSystem.ValidatePostcodeRegex(tbxPostCode.Text))
            {
                tbxPostCode.ForeColor = Color.Green;
            }
            else
            {
                tbxPostCode.ForeColor = Color.Red;
            }
        }
        //Ensures message entered is of valid length and form.
        private void MessageChanged(object sender, EventArgs e)
        {
            cbxReady.Checked = false;
            try
            {
                if ((sender as TextBox).Text.Length > 50)
                {
                    throw new Exception();
                }
                lblMessageError.Visible = false;
            }
            catch
            {
                lblMessageError.Visible = true;
            }
        }
        //Make btnConfirm visible if all necesary values filled.
        private void Ready(object sender, EventArgs e)
        {
            try
            {
                if (cbxReady.Checked)
                {
                    if (useWedList)
                    {
                        if (pickUp)
                        {
                            if (tbxAdd1.ForeColor == Color.Green && tbxAdd2.ForeColor == Color.Green && tbxAdd3.ForeColor == Color.Green && tbxForename.ForeColor == Color.Green && tbxPostCode.ForeColor == Color.Green && tbxTelNo.ForeColor == Color.Green)
                            {
                                if (cbxMessage.Checked)
                                {
                                    if (lblMessageError.Visible)
                                    {
                                        throw new Exception();
                                    }
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                    if (listAmountWanted.Count == 0)
                    {
                        throw new Exception();
                    }
                    btnConfirm.Visible = true;
                }
                else
                {
                    btnConfirm.Visible = false;
                }
            }
            catch { }
        }
        //Make visible/invisible fields needed for wedding list ordering
        private void NoWeddingList(object sender, EventArgs e)
        {
            pickUp = false;
            cbxReady.Checked = false;
            cbxReady.Visible = false;
            btnConfirm.Visible = true;
            lbxSelected.Items.Clear();
            listAmountWanted.Clear();
            stockListToBuy.Clear();
            totalPrice = 0;
            RefreshPrice();
            amountToMove = 0;
            lblAmount.Text = "Amount to Move: 0";
            stockListHeld.Clear();
            lbxStock.Items.Clear();
            if (!cbxNoWeddingList.Checked)
            {
                //pos 1
                lblStockHeld.Location = new Point(416, 9);
                tbxSearchHeld.Visible = true;
                btnAppliances.Visible = true;
                btnBedding.Visible = true;
                btnChina.Visible = true;
                pictureBox1.Visible = true;
                btnCutlery.Visible = true;
                btnClearFilters.Visible = true;
                btnFastMoving.Visible = true;
                useWedList = false;
                cbxPickUp.Checked = false;
                cbxPickUp.Visible = false;
                lblWedList.Visible = false;
                lbxWeddingList.Visible = false;
                tbxSearchWedList.Visible = false;
                lblName.Visible = false;
                lblPostCode.Visible = false;
                lblDate.Visible = false;
                lblTelNo.Visible = false;
                lblStockHeld.Text = "All Available Items in Stock:";
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                List<Backend.Classes.ClsStock> ls = sDBA.GetStockObjectsOrderByStockAsc();
                int i = 0;
                foreach (Backend.Classes.ClsStock s in ls)
                {
                    stockListHeld.Add(s);
                    lbxStock.Items.Add(s.StockName + " | " + sDBA.GetManufacturerName(s.ManufacturerId) + " | £" + s.StockPrice + " | " + stockListHeld[i].AmountHeld + " Held in Stock");
                    i++;
                }
            }
            else
            {
                tbxSearchHeld.Visible = false;
                //pos 2
                lblStockHeld.Location = new Point(416, 106);
                btnAppliances.Visible = false;
                pictureBox1.Visible = false;
                btnBedding.Visible = false;
                btnChina.Visible = false;
                btnCutlery.Visible = false;
                btnClearFilters.Visible = false;
                btnFastMoving.Visible = false;
                lblName.Visible = true;
                lblPostCode.Visible = true;
                lblDate.Visible = true;
                lblTelNo.Visible = true;
                useWedList = true;
                cbxPickUp.Checked = false;
                cbxPickUp.Visible = true;
                lblWedList.Visible = true;
                lbxWeddingList.Visible = true;
                tbxSearchWedList.Visible = true;
                lblStockHeld.Text = "Stock Held in Wedding List:";
            }
        }
        //Searches lbxstockheld with name/postcode to show lesser amount of stock at once. only ones with pattern.
        private void SearchHeld(object sender, EventArgs e)
        {
            try
            {
                string toSearch = tbxSearchHeld.Text;
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                Backend.Database.WeddingListBridgeStockDBAccess wBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                List<Backend.Classes.ClsStock> s = sDBA.SearchByModelManufacturer(toSearch);
                stockListHeld = s;
                lbxStock.Items.Clear();
                int i = 0;
                if (useWedList)
                {
                    Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
                    Backend.Classes.ClsWeddingList selectedWedList = listWeddingList[lbxWeddingList.SelectedIndex];
                    int wid = wDBA.GetWeddingListIdFromPostcode(selectedWedList.ClientPostCode);
                    foreach (Backend.Classes.ClsStock cs in stockListHeld)
                    {
                        stockListHeld.Add(cs);
                        listAmountWanted.Add(wBSDBA.GetWeddingListBridgeStockAmountFromStockIdWeddingListId(cs.StockId, wid));
                        lbxStock.Items.Add(cs.StockName + " | " + sDBA.GetManufacturerName(cs.ManufacturerId) + " | £" + cs.StockPrice + " | " +cs.AmountHeld+ " Needed for the Wedding | "+ stockListHeld[i].AmountHeld + " Held in Stock");
                        i++;
                    }
                }
                else
                {
                    foreach (Backend.Classes.ClsStock cs in stockListHeld)
                    {
                        lbxStock.Items.Add(cs.StockName + " | " + sDBA.GetManufacturerName(cs.ManufacturerId) + " | £" + cs.StockPrice + " | " + stockListHeld[i].AmountHeld + " Held in Stock");
                        i++;
                    }
                }
            }
            catch{}
        }
        //Searches lbxedit with name/postcode to show lesser amount of stock at once. only ones with pattern.
        private void SearchWeddingList(object sender, EventArgs e)
        {
            totalPrice = 0;
            RefreshPrice();
            string toSearch = tbxSearchWedList.Text;
            Backend.Database.WeddingListDBAccess wlDBA = new Backend.Database.WeddingListDBAccess(db);
            List<Backend.Classes.ClsWeddingList> sl = wlDBA.SearchByNamePostcode(toSearch);
            listWeddingList = sl;
            lbxWeddingList.Items.Clear();
            foreach (Backend.Classes.ClsWeddingList s in sl)
            {
                lbxWeddingList.Items.Add(s.ClientTitle + " " + s.ClientForename + " " + s.ClientSurname + " (" + s.ClientPostCode + ")");
            }
            ClearAll();
            lbxWeddingList.SelectedIndex = -1;
        }
        private void RefreshPrice()
        {
            if (totalPrice < 0)
            {
                totalPrice = 0;
            }
            lblTotalPrice.Text = "Total Price: £" + totalPrice;
        }
        //Changes mode to picking up item/not, in/visibles many controls.
        private void PickUpChanged(object sender, EventArgs e)
        {
            if (cbxPickUp.Checked)
            {
                lblAdd1.Visible = true;
                cbxReady.Visible = true;
                cbxReady.Checked = false;
                lblAdd2.Visible = true;
                lblAdd3.Visible = true;
                lblSurname.Visible = true;
                lblForeName.Visible = true;
                lblPPostCode.Visible = true;
                lblPTelNo.Visible = true;
                tbxAdd1.Visible = true;
                tbxAdd2.Visible = true;
                tbxAdd3.Visible = true;
                tbxForename.Visible = true;
                tbxPostCode.Visible = true;
                tbxSurname.Visible = true;
                tbxTelNo.Visible = true;
                cbxMessage.Visible = true;
                pickUp = true;
            }
            else
            {
                cbxReady.Visible =false;
                cbxReady.Checked = false;
                lblAdd1.Visible = false;
                lblAdd2.Visible = false;
                btnConfirm.Visible = true;
                lblAdd3.Visible = false;
                lblSurname.Visible = false;
                lblForeName.Visible = false;
                lblPPostCode.Visible = false;
                lblPTelNo.Visible = false;
                tbxAdd1.Visible = false;
                tbxAdd2.Visible = false;
                tbxAdd3.Visible = false;
                tbxForename.Visible = false;
                tbxPostCode.Visible = false;
                tbxSurname.Visible = false;
                tbxTelNo.Visible = false;
                cbxMessage.Visible = false;
                pickUp = false;
            }
        }
        private void WipeAmount(object sender, EventArgs e)
        {
            amountToMove = 0;
            lblAmount.Text = "Amount to Move: " + amountToMove;
        }
        private bool searchByFastMoving = false;
        private void ApplyFilter(object sender, EventArgs e)
        {
            try
            {
                stockListHeld.Clear();
                listAmountWanted.Clear();
                lbxStock.Items.Clear();
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                Backend.Database.WeddingListDBAccess wDBA = new Backend.Database.WeddingListDBAccess(db);
                Backend.Database.WeddingListBridgeStockDBAccess wBSDBA = new Backend.Database.WeddingListBridgeStockDBAccess(db);
                if ((sender as Button).Name != "btnClearFilters")
                {
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
                    }
                    try
                    {
                        stockListHeld = sDBA.ApplyFilterList(sender as Button, searchByFastMoving);
                        foreach (Backend.Classes.ClsStock sl in stockListHeld)
                        {
                            lbxStock.Items.Add(sl.StockName + " | " + sDBA.GetManufacturerName(sl.ManufacturerId) + " | £" + sl.StockPrice + " | " + sl.AmountHeld + " Currently Held in Stock");
                            listAmountWanted.Add(sl.AmountHeld);
                        }
                    }
                    catch { }
                }
                else
                {
                    if (!useWedList)
                    {
                        stockListHeld = sDBA.GetStockObjectsOrderByStockAsc();
                        foreach (Backend.Classes.ClsStock sl in stockListHeld)
                        {
                            lbxStock.Items.Add(sl.StockName + " | " + sDBA.GetManufacturerName(sl.ManufacturerId) + " | £" + sl.StockPrice + " | " + sl.AmountHeld + " Currently Held in Stock");
                        }
                    }
                    else
                    {
                        FillEverything(sender,null);
                        /*
                         * int wid = wDBA.GetWeddingListIdFromPostcode(listWeddingList[lbxWeddingList.SelectedIndex].ClientPostCode);

                        int i = 0;
                        foreach (Backend.Classes.ClsStock cs in stockListHeld)
                        {
                            listAmountWanted.Add(wBSDBA.GetWeddingListBridgeStockAmountFromStockIdWeddingListId(cs.StockId, wid));
                            lbxStock.Items.Add(cs.StockName + " | " + sDBA.GetManufacturerName(cs.ManufacturerId) + " | £" + cs.StockPrice + " | " + cs.AmountHeld + " Needed for the Wedding | " + stockListHeld[i].AmountHeld + " Held in Stock");
                            i++;
                        }
                        */
                    }
                }
            }
            catch { }
        }
        #endregion

        private void Popular(object sender, EventArgs e)
        {
            VisiblePnl();
        }
        private void VisiblePnl()
        {
            if (pnlMoving.Visible)
            {
                pnlMoving.Visible = false;
            }
            else
            {
                pnlMoving.Visible = true;
            }
        }
        private void Moving(object sender, EventArgs e)
        {
            stockListHeld.Clear();
            listAmountToBuy.Clear();
            listAmountWanted.Clear();
            stockListToBuy.Clear();
            lbxSelected.Items.Clear();
            lbxStock.Items.Clear();
            Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
            stockListHeld = sDBA.SearchByFastMovingList(false, mcal1.SelectionStart, mcal2.SelectionStart);
            foreach (Backend.Classes.ClsStock sl in stockListHeld)
            {
                lbxStock.Items.Add(sl.StockName + " | " + sDBA.GetManufacturerName(sl.ManufacturerId) + " | £" + sl.StockPrice + " | " + sl.AmountHeld + " Currently Held in Stock");
                listAmountWanted.Add(sl.AmountHeld);
            }
            VisiblePnl();
        }

        private void AddChanged(object sender, EventArgs e)
        {
            cbxReady.Checked = false;
            if ((sender as TextBox).Text.Length <= 31)
            {
                (sender as TextBox).ForeColor = Color.Green;
            }
            else
            {
                (sender as TextBox).ForeColor = Color.Red;
            }
        }
    }
}
