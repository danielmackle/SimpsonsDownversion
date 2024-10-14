using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsDownversion.Backend.Reports
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            db = new Classes.ClsDatabase();
        }
        private readonly Classes.ClsDatabase db;
        private void FormReport_Load(object sender, EventArgs e)
        {
            Database.WeddingListDBAccess wlDBA = new Database.WeddingListDBAccess(db);
            int id = wlDBA.GetWeddingListIdFromPostcode(Classes.ClsSystem.wlToPrint.ClientPostCode);
            weddingListTableAdapter.Connection = db.Conn;
            if (db.Rdr != null)
            {
                db.Rdr.Close();
            }
            dataSet1.EnforceConstraints = false;
            weddingListTableAdapter.Fill(dataSet1.WeddingList, id);
            reportViewer1.RefreshReport();
        }
    }
}
