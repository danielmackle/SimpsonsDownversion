using System;
namespace SimpsonsDownversion.Backend.Classes
{
    public class ClsWeddingList : IDisposable
    {
        ///<summary>
        ///  A class controlling all the variables and properties to be held 
        ///  in the table WeddingList when the database is read
        ///</summary>
        #region Public Constructors
        public ClsWeddingList() { }
        public ClsWeddingList(string _clientTitle, string _clientSurname, string _clientForename, string _clientTelNo, string _clientPostCode, DateTime _dateToFinish)
        {
            ClientTelNo = _clientTelNo;
            ClientPostCode = _clientPostCode;
            ClientTitle = _clientTitle;
            ClientSurname = _clientSurname;
            ClientForename = _clientForename;
            DateToFinish = _dateToFinish;
        }
        #endregion
        #region Private Variables
        private string clientTitle;
        private string clientForename;
        private string clientSurname;
        private string clientTelNo;
        private string clientPostCode;
        private DateTime dateToFinish;
        #endregion
        #region Public Properties
        public string ClientTelNo { get => clientTelNo; set => clientTelNo = value; }
        public string ClientPostCode { get => clientPostCode; set => clientPostCode = value; }
        public DateTime DateToFinish { get => dateToFinish; set => dateToFinish = value; }
        public string ClientTitle { get => clientTitle; set => clientTitle = value; }
        public string ClientForename { get => clientForename; set => clientForename = value; }
        public string ClientSurname { get => clientSurname; set => clientSurname = value; }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
