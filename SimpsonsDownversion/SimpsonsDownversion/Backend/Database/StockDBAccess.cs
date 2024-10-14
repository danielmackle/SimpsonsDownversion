using System;
using System.Collections.Generic;
namespace SimpsonsDownversion.Backend.Database
{
    public class StockDBAccess : IDisposable
    {
        ///<summary>
        ///  A class containing methods and properties useful to the
        ///  management an interaction with the Stock table in the database
        ///</summary>
        #region Public Constructor
        public StockDBAccess(Classes.ClsDatabase _db) { db = _db; }
        #endregion
        #region Private Variables
        private readonly Classes.ClsDatabase db;
        #endregion
        #region Public Methods
        public int GetAmountHeldFromId(int sId)
        {
            string SqlCmd = "RETURN Stock.StockAmountHeld FROM Stock WHERE Stock.StockId = "+sId;
            Classes.ClsSystem.RunSQLSelect(SqlCmd,db);
            return Classes.ClsSystem.GetInt32FromRdr(db);
        }
        public System.Data.DataTable ApplyFilterDGV(System.Windows.Forms.Button b, bool searchByFastMoving)
        {
            switch (b.Name)
            {
                case "btnBedding":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("Bedding", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("Bedding", false);
                        }
                    }
                case "btnCutlery":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("Cutlery", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("Cutlery", false);
                        }
                    }
                case "btnAppliances":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("Appliances", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("Appliances", false);
                        }
                    }
                case "btnChina":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("China", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("China", false);
                        }
                    }
                case "btnClearFilters":
                    {
                        return GetDataTableStockOrderByStockAsc();
                    }
            }
            return null;
        }
        public List<Classes.ClsStock> ApplyFilterList(System.Windows.Forms.Button b, bool searchByFastMoving)
        {
            switch (b.Name)
            {
                case "btnBedding":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("Bedding", true);
                        }
                        else
                        {
                            return SearchByCategoryList("Bedding", false);
                        }
                    }
                case "btnCutlery":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("Cutlery", true);
                        }
                        else
                        {
                            return SearchByCategoryList("Cutlery", false);
                        }
                    }
                case "btnAppliances":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("Appliances", true);
                        }
                        else
                        {
                            return SearchByCategoryList("Appliances", false);
                        }
                    }
                case "btnChina":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("China", true);
                        }
                        else
                        {
                            return SearchByCategoryList("China", false);
                        }
                    }
            }
            return null;
        }
        //returns a list of all Backend.Classes.ClsStock objects from the database
        public List<Classes.ClsStock> GetStockObjectsOrderByStockAsc()
        {
            string SQLCmd = "SELECT * FROM Stock ORDER BY Stock.StockAmountHeld ASC;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return GetStockListFromRdr();
        }
        public System.Data.DataTable SearchByCategoryDGV(string category, bool moving)
        {
            string SQLCmd;
            if (moving)
            {
                SQLCmd = "SELECT StockName as Name, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category,(0 - SUM(WeddingListBridgeStock.StockAmount)) as Potential_Shortage FROM STOCK LEFT JOIN WeddingListBridgeStock ON WeddingListBridgeStock.StockId = Stock.StockId INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockCategory = '" + category + "' AND (SUM(PurchaseBridgeStock.Amount)*Stock.StockMovingValue) <= 10 AND DATEDIFF(DAY,GETDATE(),Purchase.DateOfPurchase) <=31 GROUP BY StockName, StockAmountHeld, StockRestockValue, StockPrice, StockAmountHeld, ManufacturerName, StockCategory;";
            }
            else
            {
                SQLCmd = "SELECT StockName as Name, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category,(0 - SUM(WeddingListBridgeStock.StockAmount)) as Potential_Shortage FROM STOCK LEFT JOIN WeddingListBridgeStock ON WeddingListBridgeStock.StockId = Stock.StockId INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockCategory = '" + category + "' GROUP BY StockName, StockAmountHeld, StockRestockValue, StockPrice, StockAmountHeld, ManufacturerName, StockCategory;";
            }
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        public List<Classes.ClsStock> SearchByCategoryList(string category, bool moving)
        {
            string SQLCmd;
            if (moving)
            {
                SQLCmd = "SELECT Stock.StockId, StockDescription, StockName as Name, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, StockCategory as Category,Stock.ManufacturerId, (0 - SUM(WeddingListBridgeStock.StockAmount)) as Potential_Shortage FROM STOCK LEFT JOIN WeddingListBridgeStock ON WeddingListBridgeStock.StockId = Stock.StockId INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockCategory = '" + category + "' AND (SUM(PurchaseBridgeStock.Amount)*Stock.StockMovingValue) <= 10 AND DATEDIFF(DAY,GETDATE(),Purchase.DateOfPurchase) <=31 GROUP BY StockName, StockAmountHeld, StockRestockValue, StockPrice, StockAmountHeld, Stock.ManufacturerId, StockCategory, StockDescription, Stock.StockId;";
            }
            else
            {
                SQLCmd = "SELECT Stock.StockId, StockDescription, StockName as Name, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, StockCategory as Category,Stock.ManufacturerId, (0 - SUM(WeddingListBridgeStock.StockAmount)) as Potential_Shortage FROM STOCK LEFT JOIN WeddingListBridgeStock ON WeddingListBridgeStock.StockId = Stock.StockId INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockCategory = '" + category + "' GROUP BY StockName, StockAmountHeld, StockRestockValue, StockPrice, StockAmountHeld, Stock.ManufacturerId, StockCategory, StockDescription, Stock.StockId;";
            }
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetListStockFromRdr(db);
        }
        public System.Data.DataTable SearchByFastMovingDGV(bool fast,DateTime dateEarly, DateTime dateLate)
        {
            string SQLCmd;
            if (fast)
            {
                SQLCmd = "SELECT StockName as Name,StockAmountHeld as Amount_Held,StockRestockValue as Restock_Value,StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category FROM STOCK LEFT JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId LEFT JOIN WeddingListBridgeStock on WeddingListBridgeStock.StockId = Stock.StockId LEFT JOIN PurchaseBridgeStock on PurchaseBridgeStock.StockId = Stock.StockId LEFT JOIN StockHistory ON Stock.StockId = StockHistory.StockId INNER JOIN Purchase on Purchase.PurchaseId = PurchaseBridgeStock.PurchaseId WHERE Purchase.DateOfPurchase BETWEEN '" + dateEarly.Month+"/"+dateEarly.Day+"/"+dateEarly.Year+"' AND '" + dateLate.Month + "/" + dateLate.Day + "/" + dateLate.Year + "' GROUP BY StockName,StockDescription,StockAmountHeld,StockRestockValue,StockPrice,ManufacturerName,StockCategory ORDER BY Count(StockHistory.StockId), Stock.StockAmountHeld DESC;";
            }
            else
            {
                SQLCmd = "SELECT StockName as Name,StockAmountHeld as Amount_Held,StockRestockValue as Restock_Value,StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category FROM STOCK LEFT JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId LEFT JOIN WeddingListBridgeStock on WeddingListBridgeStock.StockId = Stock.StockId LEFT JOIN PurchaseBridgeStock on PurchaseBridgeStock.StockId = Stock.StockId left JOIN StockHistory ON Stock.StockId = StockHistory.StockId INNER JOIN Purchase on Purchase.PurchaseId = PurchaseBridgeStock.PurchaseId WHERE Purchase.DateOfPurchase BETWEEN '" + dateEarly.Month + "/" + dateEarly.Day + "/" + dateEarly.Year + "' AND '" + dateLate.Month + "/" + dateLate.Day + "/" + dateLate.Year + "' GROUP BY StockName,StockDescription,StockAmountHeld,StockRestockValue,StockPrice,ManufacturerName,StockCategory ORDER BY Count(StockHistory.StockId), Stock.StockAmountHeld ASC;";
            }
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        public List<Classes.ClsStock> SearchByFastMovingList(bool fast, DateTime dateEarly, DateTime dateLate)
        {
            string SQLCmd;
            if (fast)
            {
                SQLCmd = "SELECT Stock.StockId, StockDescription as StockDescription,StockName as Name,StockAmountHeld as Amount_Held,StockRestockValue as Restock_Value,StockPrice as Stock_Price,StockCategory as Category,Manufacturer.ManufacturerId as Manufacturer, (StockAmountHeld - SUM(WeddingListBridgeStock.StockAmount)) as Amount_Not_Reserved,(Sum(WeddingListBridgeStock.StockAmount)/ StockRestockValue) as TimesHitRestockValue FROM STOCK LEFT JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId LEFT JOIN WeddingListBridgeStock on WeddingListBridgeStock.StockId = Stock.StockId INNER JOIN StockHistory ON Stock.StockId = StockHistory.StockId INNER JOIN PurchaseBridgeStock on PurchaseBridgeStock.StockId = Stock.StockId INNER JOIN Purchase on Purchase.PurchaseId = PurchaseBridgeStock.PurchaseId WHERE Purchase.DateOfPurchase BETWEEN '" + dateEarly.Month + "/" + dateEarly.Day + "/" + dateEarly.Year + "' AND '" + dateLate.Month + "/" + dateLate.Day + "/" + dateLate.Year + "' GROUP BY Stock.StockId,StockName,StockDescription,StockAmountHeld,StockRestockValue,StockPrice,Manufacturer.ManufacturerId,StockCategory ORDER BY Count(StockHistory.StockId), Stock.StockAmountHeld DESC;";
            }
            else
            {
                SQLCmd = "SELECT Stock.StockId, StockDescription as StockDescription,StockName as Name,StockAmountHeld as Amount_Held,StockRestockValue as Restock_Value,StockPrice as Stock_Price,StockCategory as Category,Manufacturer.ManufacturerId as Manufacturer, (StockAmountHeld - SUM(WeddingListBridgeStock.StockAmount)) as Amount_Not_Reserved,(Sum(WeddingListBridgeStock.StockAmount)/ StockRestockValue) as TimesHitRestockValue FROM STOCK LEFT JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId LEFT JOIN WeddingListBridgeStock on WeddingListBridgeStock.StockId = Stock.StockId INNER JOIN StockHistory ON Stock.StockId = StockHistory.StockId INNER JOIN PurchaseBridgeStock on PurchaseBridgeStock.StockId = Stock.StockId INNER JOIN Purchase on Purchase.PurchaseId = PurchaseBridgeStock.PurchaseId WHERE Purchase.DateOfPurchase BETWEEN '" + dateEarly.Month + "/" + dateEarly.Day + "/" + dateEarly.Year + "' AND '" + dateLate.Month + "/" + dateLate.Day + "/" + dateLate.Year + "' GROUP BY Stock.StockId,StockName,StockDescription,StockAmountHeld,StockRestockValue,StockPrice,Manufacturer.ManufacturerId,StockCategory ORDER BY Count(StockHistory.StockId), Stock.StockAmountHeld ASC;";
            }
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetListStockFromRdr(db);
        }
        //returns a list of all Stock registers as a datatable from the database
        public System.Data.DataTable GetDataTableStockOrderByStockAsc()
        {
            string SQLCmd = "SELECT StockName as Name, StockAmountHeld as Amount_Held,StockRestockValue as Restock_Value, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category, (0 - SUM(WeddingListBridgeStock.StockAmount)) as Potential_Shortage FROM STOCK LEFT JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId LEFT JOIN WeddingListBridgeStock on WeddingListBridgeStock.StockId = Stock.StockId GROUP BY Stock.StockId,StockName,StockDescription,StockAmountHeld,StockRestockValue,StockPrice,ManufacturerName,StockCategory ORDER BY Stock.StockAmountHeld ASC; ";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        //Returns a list of all Backend.Classes.ClsStock objects under a search of name/manufcutrer
        public List<Classes.ClsStock> SearchByModelManufacturer(string se)
        {
            string SQLCmd = "SELECT * FROM Stock INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockName LIKE '%" + se + "%' Or ManufacturerName like '%" + se + "%' ORDER BY StockName";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return GetStockListFromRdr();
        }
        //Returns a datatable containing registers under a search of name/manufcutrer
        public System.Data.DataTable SearchByModelManufacturerDataTable(string se)
        {
            string SQLCmd = "SELECT StockName as Name, StockAmountHeld as Amount_Held,StockRestockValue as Restock_Value, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category, (0 - SUM(WeddingListBridgeStock.StockAmount)) as Potential_Shortage FROM STOCK LEFT JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId LEFT JOIN WeddingListBridgeStock on WeddingListBridgeStock.StockId = Stock.StockId WHERE StockName LIKE '%" + se + "%' Or ManufacturerName like '%" + se + "%' GROUP BY StockName,StockDescription,StockAmountHeld,StockRestockValue,StockPrice,ManufacturerName,StockCategory ORDER BY StockName;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        //Return the manufacturer name from Stock where the id is equal to the input.
        public string GetManufacturerName(int id)
        {
            string SQLCmd = "SELECT TOP 1 Manufacturer.ManufacturerName FROM Stock INNER JOIN Manufacturer ON Manufacturer.ManufacturerId=Stock.ManufacturerId WHERE Stock.ManufacturerId=" + Convert.ToString(id);
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetStringFromRdr(db);
        }
        //Decrease amount by an amount given
        public void UpdateAmount(int a, int sid)
        {
            string SQLCmd = "UPDATE Stock SET StockAmountHeld = StockAmountHeld + " + a + " WHERE StockId = "+sid+";";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        #endregion
        #region Private Methods
        private List<Classes.ClsStock> GetStockListFromRdr()
        {
            List<Classes.ClsStock> l = new List< Classes.ClsStock > ();
            while (db.Rdr.Read())
            {
                int id = db.Rdr.GetInt32(0);
                string desc = db.Rdr.GetString(1);
                string name = db.Rdr.GetString(2);
                int amount = db.Rdr.GetInt32(3);
                int restockValue = db.Rdr.GetInt32(4);
                decimal price = db.Rdr.GetDecimal(5);
                string stockCategory = db.Rdr.GetString(6);
                int manid = db.Rdr.GetInt32(7);
                Classes.ClsStock s = new Classes.ClsStock(id, name, desc, price, manid, amount, restockValue, stockCategory);
                l.Add(s);
            }
            return l;
        }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
        }
        #endregion
    }
}
