using System;
namespace SimpsonsDownversion.Backend.Database
{
    public class PurchaseDBAccess : IDisposable
    {
        ///<summary>
        ///  A class containing methods and properties useful to the
        ///  management an interaction with the Purchase table in the database
        ///</summary>
        #region Public Constructor
        public PurchaseDBAccess(Classes.ClsDatabase _db) { db = _db; }
        #endregion
        #region Private Variables
        private readonly Classes.ClsDatabase db;
        #endregion
        #region Public Methods
        //Inserts into purchase a new register of inputed values
        public void InsertPurchase(bool _isStock)
        {
            string SQLCmd;
            if (_isStock)
            {
                SQLCmd = "INSERT INTO Purchase(DateOfPurchase,IsStock) VALUES (GETDATE(),1);";
            }
            else
            {
                SQLCmd = "INSERT INTO Purchase(DateOfPurchase,IsStock) VALUES (GETDATE(),0);";
            }
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        public int GetBackPid()
        {
            string SQLCmd = "SELECT MAX(PurchaseId) FROM Purchase;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetInt32FromRdr(db);
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
