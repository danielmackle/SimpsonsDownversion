using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpsonsDownversion.Backend.Database
{
    public class StockHistoryDBAccess
    {
        public StockHistoryDBAccess(Classes.ClsDatabase _db)
        {
            db = _db;
        }
        private Classes.ClsDatabase db;
        public void StockLevelOvercome(int sid)
        {
            string SQLCmd = "INSERT INTO StockHistory (StockId, DateOfOvercome) VALUES ("+sid+",GetDate());";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
    }
}
