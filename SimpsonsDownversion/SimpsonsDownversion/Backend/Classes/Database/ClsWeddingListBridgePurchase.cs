using System;
namespace SimpsonsDownversion.Backend.Classes.Database
{
    public class ClsWeddingListBridgePurchase : IDisposable
    {
        ///<summary>
        ///  A class controlling all the variables and properties to be held 
        ///  in the table WeddingListBridgePurchase when the database is read
        ///</summary>
        #region Public Constructor
        public ClsWeddingListBridgePurchase() { }
        public ClsWeddingListBridgePurchase(int _wid, int _pid)
        {
            WedId = _wid;
            PurchaseId = _pid;
        }
        public ClsWeddingListBridgePurchase(int _wedId, int _purchaseId, string _forename, string _surname, string _add1, string _add2, string _add3, string _postcode, long _telNo, bool _signed, string _message)
        {
            WedId = _wedId;
            PurchaseId = _purchaseId;
            Forename = _forename;
            Surname = _surname;
            Add1 = _add1;
            Add2 = _add2;
            Add3 = _add3;
            Postcode = _postcode;
            TelNo = _telNo;
            Signed = _signed;
            Message = _message;
        }
        public ClsWeddingListBridgePurchase(int _wedId, int _purchaseId, string _forename, string _surname, string _add1, string _add2, string _add3, string _postcode, long _telNo)
        {
            WedId = _wedId;
            PurchaseId = _purchaseId;
            Forename = _forename;
            Surname = _surname;
            Add1 = _add1;
            Add2 = _add2;
            Add3 = _add3;
            Postcode = _postcode;
            TelNo = _telNo;
        }
        #endregion
        #region Private Variables
        private string forename;
        private string surname;
        private string add1;
        private string add2;
        private string add3;
        private string message;
        private bool signed;
        private long telNo;
        private string postcode;
        private int wedId;
        private int purchaseId;
        #endregion
        #region Public Properties
        public string Forename { get => forename; set => forename = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Add1 { get => add1; set => add1 = value; }
        public string Add2 { get => add2; set => add2 = value; }
        public string Add3 { get => add3; set => add3 = value; }
        public string Postcode { get => postcode; set => postcode = value; }
        public string Message { get => message; set => message = value; }
        public bool Signed { get => signed; set => signed = value; }
        public long TelNo { get => telNo; set => telNo = value; }
        public int WedId { get => wedId; set => wedId = value; }
        public int PurchaseId { get => purchaseId; set => purchaseId = value; }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
