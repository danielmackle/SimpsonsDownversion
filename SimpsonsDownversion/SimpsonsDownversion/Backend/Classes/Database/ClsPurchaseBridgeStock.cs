using System;
namespace SimpsonsDownversion.Backend.Classes.Database
{
    public class ClsPurchaseBridgeStock : IDisposable
    {
        ///<summary>
        ///  A class controlling all the variables and properties to be held 
        ///  in the table PurchaseBridgeStock when the database is read
        ///</summary>
        #region Public Constructors
        public ClsPurchaseBridgeStock() { }
        public ClsPurchaseBridgeStock(int _stockId, int _purchaseId, int _amount)
        {
            PurchaseId = _purchaseId;
            Amount = _amount;
            StockId = _stockId;
        }
        #endregion
        #region Private Variables
        private int stockId;
        private int amount;
        private int purchaseId;
        #endregion
        #region Public Properties
        public int PurchaseId { get => purchaseId; set => purchaseId = value; }
        public int Amount { get => amount; set => amount = value; }
        public int StockId { get => stockId; set => stockId = value; }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
