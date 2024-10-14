using System;
using System.Collections.Generic;
namespace SimpsonsDownversion.Backend.Database
{
    public class WeddingListBridgeStockDBAccess : IDisposable
    {
        ///<summary>
        ///  A class containing methods and properties useful to the
        ///  management an interaction with the WeddingListBridgeStock table in the database
        ///</summary>
        #region Public Constructors
        public WeddingListBridgeStockDBAccess(Classes.ClsDatabase _db) { db = _db; }
        #endregion
        #region Private Variables
        private readonly Classes.ClsDatabase db;
        #endregion
        #region Public Class Methods
        //return the WeddingListId from StockId from Stock.
        public int GetWeddingListIdFromStockId(int stockId)
        {
            string SQLCmd = "SELECT WeddingListId FROM WeddingListBridgeStock WHERE StockId=" + stockId + ";";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetInt32FromRdr(db);
        }
        //Delete the register specified by WeddingListid and Stockid inputs.
        public void RemoveRowFromWIdAndSId(int wid, int sid)
        {
            string SQLCmd = "DELETE FROM WeddingListBridgeStock WHERE StockId=" + sid + " AND WeddingListId=" + wid + ";";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        //return the AmountHeld from WeddingListId,StockId from Stock.
        public int GetWeddingListBridgeStockAmountFromStockIdWeddingListId(int stockId, int weddingListId)
        {
            string SQLCmd = "SELECT StockAmount FROM WeddingListBridgeStock WHERE StockId=" + stockId + " AND WeddingListId=" + weddingListId + ";";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetInt32FromRdr(db);
        }
        //return nothing and construct a new register in the databae with given values.
        public void InsertIntoWeddingListBridgeStock(int w, int s, int amt)
        {
            string SQLCmd = "INSERT INTO WeddingListBridgeStock(WeddingListId,StockID,StockAmount)VALUES(" + w + "," + s + "," + amt + ");";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        //Delete a register from a specified weddinglistid.
        public void DeleteWeddingListStockFromWeddingListId(int id)
        {
            string SQLCmd = "DELETE FROM WeddingListBridgeStock WHERE WeddingListId=" + id.ToString();
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        //Return a set of Stock items as a list of Backend.Classes.ClsStock objects specified by a WeddingList id they are attatcked to via WeddingListBridgeStock.
        public List<Classes.ClsStock> GetListStockFromWeddingListId(int id)
        {
            string SQLCmd = "SELECT * FROM Stock INNER JOIN WeddingListBridgeStock ON WeddingListBridgeStock.StockId=Stock.StockId WHERE WeddingListBridgeStock.WeddingListId=" + id + " ORDER BY Stock.StockName;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetListStockFromRdr(db);
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
