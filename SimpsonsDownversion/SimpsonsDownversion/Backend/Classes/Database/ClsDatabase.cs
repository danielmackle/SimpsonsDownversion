using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SimpsonsDownversion.Backend.Classes
{
    public class ClsDatabase : IDisposable
    {
        ///<summary>
        /// This class instantiates tools to control the SQL Database.
        ///</summary>
        #region Public Constructor
        public ClsDatabase() { Connect(new SqlConnectionStringBuilder()); }
        #endregion
        #region Private Variables
        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataReader rdr;
        #endregion
        #region Public Properties
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlDataReader Rdr { get => rdr; set => rdr = value; }
        #endregion
        #region Public Class Methods
        //Connects the database to c#
        //MUST run before doing anything
        public bool Connect(SqlConnectionStringBuilder scStrBuild)
        {
            try
            {
                scStrBuild.DataSource =  "(LocalDB)\\mssqllocaldb";
                scStrBuild.IntegratedSecurity = true;
                scStrBuild.AttachDBFilename = "@\\Backend\\Database\\DBMainSystem.mdf";
                conn = new SqlConnection(scStrBuild.ToString());
                cmd = new SqlCommand();
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}