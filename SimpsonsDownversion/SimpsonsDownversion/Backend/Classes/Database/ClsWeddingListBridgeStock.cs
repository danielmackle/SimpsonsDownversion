using System;
namespace SimpsonsDownversion.Backend.Classes
{
    public class ClsWeddingListBridgeStock : IDisposable
    {
        ///<summary>
        ///  A class controlling all the variables and properties to be held 
        ///  in the table WeddingListBridgeStock when the database is read
        ///</summary>
        #region Public Constructor
        public ClsWeddingListBridgeStock() { }
        public ClsWeddingListBridgeStock(int _weddingListId, int _stockId, int _stockAmount)
        {
            WeddingListId = _weddingListId;
            StockId = _stockId;
            StockAmount = _stockAmount;
        }
        #endregion
        #region Private Variables
        private int weddingListId;
        private int stockId;
        private int stockAmount;
        #endregion
        #region Public Properties
        public int WeddingListId { get => weddingListId; set => weddingListId = value; }
        public int StockId { get => stockId; set => stockId = value; }
        public int StockAmount { get => stockAmount; set => stockAmount = value; }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
