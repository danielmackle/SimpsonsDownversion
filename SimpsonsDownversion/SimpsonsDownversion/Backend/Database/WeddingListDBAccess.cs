using System;
using System.Collections.Generic;
using System.Data;
namespace SimpsonsDownversion.Backend.Database
{
    public class WeddingListDBAccess : IDisposable
    {
        ///<summary>
        ///  A class containing methods and properties useful to the
        ///  management an interaction with the WeddingList table in the database
        ///</summary>
        #region Public Constructor
        public WeddingListDBAccess(Classes.ClsDatabase _db) { db = _db; }
        #endregion
        #region Private Variables
        private readonly Classes.ClsDatabase db;
        #endregion
        #region Public Class Methods
        //Deletes Wedding List registers where WeddingListId is a value.
        public void DeleteWeddingListFromId(int id)
        {
            string SQLCmd = "DELETE FROM WeddingListBridgeStock WHERE WeddingListId=" + id.ToString() + ";";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
            SQLCmd = "DELETE FROM WeddingListBridgePurchase WHERE WeddingListId=" + id.ToString() + ";";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
            SQLCmd = "DELETE FROM WeddingList WHERE WeddingListID=" + id.ToString() + ";";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        //Create new registers in Wedding List with the given values.
        public void InsertIntoWeddingListWithWeddingList(Classes.ClsWeddingList wl)
        {
            string SQLCmd = "INSERT INTO WeddingList(ClientTitle,ClientSurname,ClientForename,ClientTelNo,ClientPostCode,DateToFinish) VALUES ('" + wl.ClientTitle + "','" + wl.ClientSurname + "','" + wl.ClientForename + "','" + wl.ClientTelNo + "','" + wl.ClientPostCode + "','" + Convert.ToString(wl.DateToFinish.Month) + "/" + Convert.ToString(wl.DateToFinish.Day) + "/" + Convert.ToString(wl.DateToFinish.Year) + "');";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        //Get all wedding lists to be insterted into a data table.
        public DataTable GetAllWeddingListsAsDataTable()
        {
            string SQLCmd = "SELECT * FROM WeddingList;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        //Get all Wedding List Ids from a given name.
        public int GetWeddingListIdFromPostcode(string postcode)
        {
            string SQLCmd = "SELECT WeddingListId FROM WeddingList WHERE ClientPostcode='" + postcode + "';";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetInt32FromRdr(db);
        }
        //Get wedding lists where the name or postcode matches a given pattern.
        public List<Classes.ClsWeddingList> SearchByNamePostcode(string s)
        {
            string SQLCmd = "SELECT * FROM WeddingList WHERE ClientForename Like '%" + s + "%' OR ClientSurname like '%" + s + "%' OR ClientPostcode like '%" + s + "%';";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return GetListWeddingListFromRdr();
        }
        //Get all Wedding Lists and their values in a list of Backend.Classes.WeddingList objects.
        public List<Classes.ClsWeddingList> GetAllWeddingListsAsList()
        {
            string SQLCmd = "SELECT * FROM WeddingList ORDER BY WeddingList.ClientForename";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return GetListWeddingListFromRdr();
        }
        #endregion
        #region Private Methods
        //Returns a single List containing the object Backend.Classes.ClsWeddingList from reader. Less code repetition.
        public List<Classes.ClsWeddingList> GetListWeddingListFromRdr()
        {
            db.Rdr.Close();
            db.Rdr = db.Cmd.ExecuteReader();
            List<Classes.ClsWeddingList> list = new List<Classes.ClsWeddingList>();
            while (db.Rdr.Read())
            {
                string title = db.Rdr.GetString(1);
                string fname = db.Rdr.GetString(2);
                string sname = db.Rdr.GetString(3);
                string telNo = db.Rdr.GetString(4);
                string post = db.Rdr.GetString(5);
                DateTime date = db.Rdr.GetDateTime(6);
                Classes.ClsWeddingList wl = new Classes.ClsWeddingList(title, sname, fname, telNo, post, date);
                list.Add(wl);
            }
            return list;
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
            if (disposing)
            {
            }
        }
        #endregion
    }
}