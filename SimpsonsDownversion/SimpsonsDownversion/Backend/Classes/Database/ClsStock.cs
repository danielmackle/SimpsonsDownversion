using System;
namespace SimpsonsDownversion.Backend.Classes
{
    public class ClsStock : IDisposable
    {
        ///<summary>
        ///  A class controlling all the variables and properties to be held 
        ///  in the table Stock when the database is read
        ///</summary>
        #region Public Constructors
        public ClsStock() { }
        public ClsStock(int _stockId, string _stockName, string _stockDescription, decimal _stockPrice, int _manufacturerId, int _amountHeld, int _restockValue, string _cat)
        {
            StockId = _stockId;
            StockName = _stockName;
            StockDescription = _stockDescription;
            StockPrice = _stockPrice;
            ManufacturerId = _manufacturerId;
            AmountHeld = _amountHeld;
            RestockValue1 = _restockValue;
            stockCategory = _cat;
        }
        #endregion
        #region Private Variables
        private int stockId;
        private int amountHeld;
        private string stockDescription;
        private decimal stockPrice;
        private string stockName;
        private int manufacturerId;
        private int RestockValue;
        private string stockCategory;
        #endregion
        #region Public Properties
        public int StockId { get => stockId; set => stockId = value; }
        public string StockDescription { get => stockDescription; set => stockDescription = value; }
        public decimal StockPrice { get => stockPrice; set => stockPrice = value; }
        public int ManufacturerId { get => manufacturerId; set => manufacturerId = value; }
        public string StockName { get => stockName; set => stockName = value; }
        public int AmountHeld { get => amountHeld; set => amountHeld = value; }
        public int RestockValue1 { get => RestockValue; set => RestockValue = value; }
        public string StockCategory { get => stockCategory; set => stockCategory = value; }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}