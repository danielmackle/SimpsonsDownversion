using System;
using System.Windows.Forms;
namespace SimpsonsDownversion.Frontend.Forms
{
    public partial class FrmTitlePage : Form
    {
        ///<summary>
        ///  Used for easy navigation into the four submenus.
        ///</summary>
        #region Public Contructor
        public FrmTitlePage()
        {
            InitializeComponent();
            Backend.Classes.ClsDatabase db = new Backend.Classes.ClsDatabase();
            db.Connect(new SqlConnectionStringBuilder());
        }
        #endregion
        #region Private Class Methods
        //This method makes sure clicking any of the 2 will cause the same event
        private void OptionSelected(object sender, EventArgs e)
        {
            int hold = 0;//breaks it into two switchcases-saves repeating twice
            switch ((sender as Control).Name)//better than elifs
            {
                case "pbxCreateWeddingList":
                    hold = 1;
                    break;
                case "lblCreateWeddingList":
                    hold = 1;
                    break;
                case "pnlCreateWeddingList":
                    hold = 1;
                    break;
                case "pbxOrderWeddingList":
                    hold = 2;
                    break;
                case "lblOrderWeddingList":
                    hold = 2;
                    break;
                case "pnlOrderWeddingList":
                    hold = 2;
                    break;
                case "pbxOrder1":
                    hold = 3;
                    break;
                case "pbxOrder2":
                    hold = 3;
                    break;
                case "lblOrder":
                    hold = 3;
                    break;
            }
            switch (hold)//better than elifs
            {
                case 1:
                    Backend.Classes.ClsSystem.OpenNewForm(this, new FrmCreateWeddingList());
                    break;
                case 2:
                    Backend.Classes.ClsSystem.OpenNewForm(this, new FrmOrderFromWeddingList());
                    break;
                case 3:
                    Backend.Classes.ClsSystem.OpenNewForm(this, new FrmStockControl());
                    break;
            }
        }
        #endregion
    }
}
