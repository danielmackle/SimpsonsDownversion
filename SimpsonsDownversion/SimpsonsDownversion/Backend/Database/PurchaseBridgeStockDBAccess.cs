using System;
using System.Collections.Generic;
namespace SimpsonsDownversion.Backend.Database
{
    public class PurchaseBridgeStockDBAccess : IDisposable
    {
        ///<summary>
        ///  A class containing methods and properties useful to the
        ///  management an interaction with the PurchaseBridgeStock table in the database
        ///</summary>
        #region Public Constructor
        public PurchaseBridgeStockDBAccess(Classes.ClsDatabase _db) { db = _db; }
        #endregion
        #region Private Variables
        private readonly Classes.ClsDatabase db;
        #endregion
        #region Public Methods
        //Return nothing. Insert into the database a new register to the PurchaseBridgeStock table of inputed values.
        public void InsertPurchaseBridgeStock(Classes.Database.ClsPurchaseBridgeStock pBS)
        {
            string SQLCmd = "INSERT INTO PurchaseBridgeStock(PurchaseId,StockId,Amount) VALUES(" + pBS.PurchaseId + "," + pBS.StockId + "," + pBS.Amount + ");";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        //decrease amount by a given int
        public void AlterAmount(int a, int s)
        {
            string SQLCmd = "UPDATE WeddingListBridgeStock SET StockAmount = StockAmount + " + a + " WHERE StockId = "+s+";";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
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
