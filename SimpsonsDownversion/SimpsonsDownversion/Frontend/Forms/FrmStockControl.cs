using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsDownversion.Frontend.Forms
{
    public partial class FrmStockControl : Form
    {
        #region Public Constructor
        public FrmStockControl()
        {
            InitializeComponent();
            FillDGV();
        }
        #endregion
        #region Private Variables
        private readonly Backend.Classes.ClsDatabase db = new Backend.Classes.ClsDatabase();
        List<Backend.Classes.ClsStock> listStock = new List<Backend.Classes.ClsStock>();
        readonly List<Backend.Classes.ClsStock> listToBuy = new List<Backend.Classes.ClsStock>();
        readonly List<int> amountToBuy = new List<int>();
        decimal totalPrice = 0;
        private bool searchByFastMoving = false;
        Backend.Classes.ClsStock selectedStock = new Backend.Classes.ClsStock();
        #endregion
        #region Private Methods
        //Fill the DGV with values from sDBA.GetDataTableStock()
        private void FillDGV()
        {
            Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
            dgvStock.DataSource = sDBA.GetDataTableStockOrderByStockAsc();
            listStock = sDBA.GetStockObjectsOrderByStockAsc();
        }
        //Make row red if under restock level, yellow if less than or equal to 125% restock level and green if 125% restock level.
        private void ColourDGV()
        {
            for (int i = 0; i < dgvStock.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToInt32(dgvStock.Rows[i].Cells[1].Value) < Convert.ToInt32(dgvStock.Rows[i].Cells[2].Value))
                    {
                        dgvStock.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(dgvStock.Rows[i].Cells[1].Value) < (Convert.ToInt32(dgvStock.Rows[i].Cells[2].Value) * 1.25))
                    {
                        dgvStock.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgvStock.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (Convert.ToDouble(dgvStock.Rows[i].Cells[6].Value)*-1.5 > Convert.ToDouble(dgvStock.Rows[i].Cells[1].Value))
                    {
                        dgvStock.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    }
                    else if (Convert.ToDouble(dgvStock.Rows[i].Cells[6].Value) * -1.5 == Convert.ToDouble(dgvStock.Rows[i].Cells[1].Value))
                    {
                        dgvStock.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgvStock.Rows[i].Cells[6].Style.BackColor = Color.LightGreen;
                    }
                }
                catch {}
            }
        }
        //exits this form, opens menu
        private void Exit(object sender, EventArgs e)
        {
            FrmTitlePage f = new FrmTitlePage();
            Backend.Classes.ClsSystem.OpenNewForm(this, f);
        }
        //ensure value entered into tbxamount is a positive integer
        private void CheckAmount(object sender, EventArgs e)
        {
            if (Backend.Classes.ClsSystem.ValidateAmountFromText(tbxAmount.Text))
            {
                tbxAmount.ForeColor = Color.Green;
                lblPrice.Text = "Price of Item: £" + selectedStock.StockPrice * Convert.ToInt32(tbxAmount.Text);
            }
            else
            {
                tbxAmount.ForeColor = Color.Red;
            }
        }
        private void FindRow(object sender, DataGridViewCellEventArgs e)
        {
            tbxAmount.Clear();
            try
            {
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                DataGridViewRow row = dgvStock.Rows[dgvStock.SelectedCells[0].RowIndex];
                if(listStock != null)
                {
                    selectedStock = listStock[row.Index];
                    btnOrder.Visible = true;
                    lblNamePrice.Text = Convert.ToString(row.Cells[0].Value) + " (" + Convert.ToDecimal(row.Cells[3].Value) + ")";
                }
                else
                {
                    listStock = sDBA.GetStockObjectsOrderByStockAsc();
                }
            }
            catch { }
        }
        private void Order(object sender, EventArgs e)
        {
            if (tbxAmount.ForeColor == Color.Green && dgvStock.SelectedCells.Count != 0)
            {
                int i = 0;
                bool replaced = false;
                foreach(Backend.Classes.ClsStock s in listToBuy)
                {
                    if(s.StockId == selectedStock.StockId)
                    {
                        amountToBuy[i] += Convert.ToInt32(tbxAmount.Text);
                        replaced = true;
                    }
                    i++;
                }
                if (!replaced)
                {
                    listToBuy.Add(selectedStock);
                    amountToBuy.Add(Convert.ToInt32(tbxAmount.Text));
                }
                lbxList.Items.Clear();
                totalPrice = 0;
                for (int q = 0; q < listToBuy.Count; q++)
                {
                    lbxList.Items.Add(listToBuy[q].StockName + " | Amount:" + amountToBuy[q]);
                    totalPrice += amountToBuy[q] * listToBuy[q].StockPrice;
                }
                RefreshPrice();
            }
        }
        private void Complete(object sender, EventArgs e)
        {
            RunPurchase();
        }
        private void RunPurchase()
        {
            try
            {
                Backend.Database.PurchaseDBAccess pDBA = new Backend.Database.PurchaseDBAccess(db);
                pDBA.InsertPurchase(true);
                Backend.Database.PurchaseBridgeStockDBAccess pBSDBA = new Backend.Database.PurchaseBridgeStockDBAccess(db);
                int pid = pDBA.GetBackPid();
                int i = 0;
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                foreach (Backend.Classes.ClsStock s in listToBuy)
                {
                    Backend.Classes.Database.ClsPurchaseBridgeStock pBS = new Backend.Classes.Database.ClsPurchaseBridgeStock(s.StockId, pid, amountToBuy[i]);
                    pBSDBA.InsertPurchaseBridgeStock(pBS);
                    sDBA.UpdateAmount(amountToBuy[i],s.StockId);
                    i++;
                }
                Wipe();
                MessageBox.Show("Order Successful!", "Thank You!");
            }
            catch { }
        }
        private void Wipe()
        {
            lbxList.Items.Clear();
            listToBuy.Clear();
            amountToBuy.Clear();
            RefreshPrice();
            FillDGV();
        }
        private void ApplyFilter(object sender, EventArgs e)
        {
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
            }
            dgvStock.DataSource = sDBA.ApplyFilterDGV(sender as Button, searchByFastMoving);
            listStock = sDBA.ApplyFilterList(sender as Button, searchByFastMoving);
            RefreshPrice();
        }
        private void AutoOrderClicked(object sender, EventArgs e)
        {
            AutoOrder();
        }
        private void AutoOrder()
        {
            lbxList.Items.Clear();
            listToBuy.Clear();
            amountToBuy.Clear();
            RefreshPrice();
            int i = 0;
            try
            {
                if (listStock != null)
                {
                    foreach (Backend.Classes.ClsStock s in listStock)
                    {
                        if (dgvStock.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                        {
                            listToBuy.Add(s);
                            amountToBuy.Add(s.RestockValue1 * 2 - s.AmountHeld);
                        }
                        else if (dgvStock.Rows[i].DefaultCellStyle.BackColor == Color.Yellow)
                        {
                            listToBuy.Add(s);
                            amountToBuy.Add(s.RestockValue1);
                        }
                        i++;
                    }
                    if (amountToBuy.Count != 0)
                    {
                        RunPurchase();
                    }
                }
            }
            catch { }
            ColourDGV();
        }
        private void RefreshPrice()
        {
            lblTotalPrice.Text = "Total Price: £" + Convert.ToString(totalPrice);
        }
        private void DeleteFromList(object sender, EventArgs e)
        {
            amountToBuy.RemoveAt(lbxList.SelectedIndex);
            listToBuy.RemoveAt(lbxList.SelectedIndex);
            lbxList.Items.Clear();
            totalPrice = 0;
            for (int q = 0; q < listToBuy.Count; q++)
            {
                lbxList.Items.Add(listToBuy[q].StockName + " | Amount:" + amountToBuy[q]);
                totalPrice += amountToBuy[q] * listToBuy[q].StockPrice;
            }
            RefreshPrice();
        }
        private void Search(object sender, EventArgs e)
        {
            SearchByModelManufacturer();
        }
        private void SearchByModelManufacturer()
        {
            try
            {
                Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
                dgvStock.DataSource = null;
                DataTable dt = sDBA.SearchByModelManufacturerDataTable(tbxSearch.Text);
                if (dt.Rows.Count == 0 && tbxSearch.Text != "")
                {
                    dgvStock.DataSource = null;
                }
                else
                {
                    dgvStock.DataSource = sDBA.SearchByModelManufacturerDataTable(tbxSearch.Text);
                }
                listStock = sDBA.SearchByModelManufacturer(tbxSearch.Text);
                ColourDGV();
            }
            catch { }
        }
        private void ColourDGV(object sender, EventArgs e)
        {
            ColourDGV();
        }
        private void FastSlowMoving(object sender, EventArgs e)
        {
            PnlVisible();
        }
        private void PnlVisible()
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
            bool fast = true;
            if ((sender as Button).Name == "btnSlowMoving")
            {
                fast = false;
            }
            Backend.Database.StockDBAccess sDBA = new Backend.Database.StockDBAccess(db);
            dgvStock.DataSource = sDBA.SearchByFastMovingDGV(fast, mcal1.SelectionStart, mcal2.SelectionStart);
            listStock = sDBA.SearchByFastMovingList(fast, mcal1.SelectionStart, mcal2.SelectionStart);
            PnlVisible();
        }
        private void ColourDGV(object sender, PaintEventArgs e)
        {
            ColourDGV();
        }
        #endregion
    }
}
