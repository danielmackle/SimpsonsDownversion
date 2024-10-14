using System;
namespace SimpsonsDownversion.Backend.Classes.Database
{
    public class ClsPurchase : IDisposable
    {
        ///<summary>
        ///  A class controlling all the variables and properties to be held 
        ///  in the table Purchase when the database is read
        ///</summary>
        #region Public Constructors
        public ClsPurchase() { }
        public ClsPurchase(DateTime _dop, bool _istock)
        {
            DateOfPurchase = _dop;
            IsStock = _istock;
        }
        #endregion
        #region Private Variables
        private DateTime dateOfPurchase;
        private bool isStock;
        #endregion
        #region Public Properties
        public DateTime DateOfPurchase { get => dateOfPurchase; set => dateOfPurchase = value; }
        public bool IsStock { get => isStock; set => isStock = value; }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
