using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace SimpsonsDownversion.Backend.Classes
{
    //iDisposable necessary for using() statements
    public class ClsSystem : IDisposable
    {
        ///<summary>
        ///  An overall class which holds useful methods so they are not repeated.
        ///  As well as small,interformal data not worthy of the database.
        ///</summary>
        public static ClsWeddingList wlToPrint = new ClsWeddingList();
        #region Public Static Class Methods
        //Runs the SQL command input - Used very commonly
        public static bool ValidateAmountFromText(string s)
        {
            try
            {
                int i = Convert.ToInt32(s);
                if (i <= 0 || i >= 2147483647)
                {
                    throw new Exception();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void RunSQLSelect(string input, ClsDatabase db)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = input;
            if (db.Rdr != null)
            {
                db.Rdr.Close();
            }
            db.Rdr = db.Cmd.ExecuteReader();
        }
        //Runs SQL without expecting a response. Avoids nasty errors later down the line.
        public static void RunSQLNonSelect(string input, ClsDatabase db)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = input;
            if (db.Rdr != null)
            {
                db.Rdr.Close();
            }
            db.Cmd.ExecuteNonQuery();
        }
        //Return bool based on if string can be converted toan int with no thrown exceptions.
        public static bool ValidateStringToBeTelNo(string s)
        {
            try
            {
                Convert.ToInt64(s);
                if (s.Length != 11) { throw new Exception(); }
                return true;
            }
            catch { return false; }
        }
        //returns false if a given string consists of anything but an array of char letter types
        public static bool ValidateStringLetters(string s)
        {
            try
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new Exception();
                    }
                }
                return true;
            }
            catch { return false; }
        }
        //returns false if a given string consists of anything but an array of char letter or whitespace types
        public static bool ValidateStringLettersSpaces(string s)
        {
            try
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        throw new Exception();
                    }
                }
                return true;
            }
            catch { return false; }
        }
        //returns false if a given string containing int is invalid
        public static bool ValidateTelNo(string s)
        {
            try
            {
                Convert.ToInt64(s);
                return true;
            }
            catch { return false; }
        }
        //returns false if a given string consists of anything but an array of char letter or whitespace types
        public static bool ValidatePostcodeRegex(string s)
        {
            try
            {
                //We love JB ty for the regex man
                string totallyCorrectRegex = @"^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([AZa-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$";
                Match match = Regex.Match(s, totallyCorrectRegex, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    return true;
                }
                throw new Exception();
            }
            catch { return false; }
        }
        //returns false if a given datetime is obviously silly :0
        public static bool ValidateDateTime(DateTime s)
        {
            try
            {
                if (s > DateTime.UtcNow.AddYears(2))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch { return false; }
        }
        //Returns a single int from reader. Less code repetition.
        public static int GetInt32FromRdr(ClsDatabase db)
        {
            try
            {
                while (db.Rdr.Read())
                {
                    var v = db.Rdr.GetInt32(0);
                    return v;
                }
            }
            catch { }
            db.Rdr.Close();
            return 0;
        }
        //Returns a single List containing the object Backend.Classes.ClsStock from reader. Less code repetition.
        public static List<ClsStock> GetListStockFromRdr(ClsDatabase db)
        {
            db.Rdr.Close();
            db.Rdr = db.Cmd.ExecuteReader();
            List<ClsStock> list = new List<ClsStock>();
            while (db.Rdr.Read())
            {
                int sId = db.Rdr.GetInt32(0);
                string stockDescription = db.Rdr.GetString(1);
                string sName = db.Rdr.GetString(2);
                int sAmountHeld = db.Rdr.GetInt32(3);
                int sRestockValue = db.Rdr.GetInt32(4);
                decimal sPrice = db.Rdr.GetDecimal(5);
                string stockCategory = db.Rdr.GetString(6);
                int mId = db.Rdr.GetInt32(7);
                ClsStock wl = new ClsStock(sId, sName, stockDescription, sPrice, mId, sAmountHeld, sRestockValue, stockCategory);
                list.Add(wl);
            }
            db.Rdr.Close();
            return list;
        }
        //Returns a single DataTable from reader. Less code repetition.
        public static DataTable GetDataTable(ClsDatabase db)
        {
            DataTable dt = new DataTable();
            dt.Load(db.Rdr);
            return dt;
        }
        //Returns a single string object from rdr.
        public static string GetStringFromRdr(ClsDatabase db)
        {
            try
            {
                while (db.Rdr.Read())
                {
                    var v = db.Rdr.GetString(0);
                    return v;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        //Returns a single list of string objects from rdr.
        public static List<String> GetListStringFromRdr(ClsDatabase db)
        {
            List<String> list = new List<String>();
            int hold = 0;
            while (db.Rdr.Read())
            {
                list.Add(db.Rdr.GetString(hold));
                hold++;
            }

            return list;
        }
        //Opens a form and closes the current. Used for form changes.
        public static void OpenNewForm(Form ths, Form ne)
        {
            ths.Hide();
            ne.ShowDialog();
            ths.Close();
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