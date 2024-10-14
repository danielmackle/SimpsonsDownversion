using System;
namespace SimpsonsDownversion.Backend.Database
{
    public class WeddingListBridgePurchaseDBAccess : IDisposable
    {
        ///<summary>
        ///  A class containing methods and properties useful to the
        ///  management an interaction with the Stock table in the database.
        ///</summary>
        #region Public Constructor
        public WeddingListBridgePurchaseDBAccess(Classes.ClsDatabase _db) { db = _db; }
        #endregion
        #region Private Variables
        private readonly Classes.ClsDatabase db;
        #endregion
        #region Public Methods
        //Create a new register of the inputed values.
        public void InsertWeddingListBridgePurchase(Classes.Database.ClsWeddingListBridgePurchase p, int i)
        {
            string SQLCmd = "";
            switch (i)
            {
                case 0:
                    {
                        SQLCmd = "INSERT INTO WeddingListBridgePurchase(PurchaseId,WeddingListId,Forename,Surname,Add1,Add2,Add3,PostCode,TelNo,Signed,MessageAdded) VALUES(" + p.PurchaseId + "," + p.WedId + ",'" + p.Forename + "','" + p.Surname + "','" + p.Add1 + "','" + p.Add2 + "','" + p.Add3 + "','" + p.Postcode + "'," + p.TelNo + ",'" + p.Signed + "','" + p.Message + "');";
                        break;
                    }
                case 1:
                    {
                        SQLCmd = "INSERT INTO WeddingListBridgePurchase(PurchaseId,WeddingListId,Forename,Surname,Add1,Add2,Add3,PostCode,TelNo) VALUES(" + p.PurchaseId + "," + p.WedId + ",'" + p.Forename + "','" + p.Surname + "','" + p.Add1 + "','" + p.Add2 + "','" + p.Add3 + "','" + p.Postcode + "'," + p.TelNo + ");";
                        break;
                    }
                case 2:
                    {
                        SQLCmd = "INSERT INTO WeddingListBridgePurchase(PurchaseId,WeddingListId) VALUES(" + p.PurchaseId + "," + p.WedId + ");";
                        break;
                    }
            }
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
