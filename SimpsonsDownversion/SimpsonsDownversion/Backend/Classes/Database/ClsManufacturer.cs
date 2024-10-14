using System;
namespace SimpsonsDownversion.Backend.Classes
{
    public class ClsManufacturer : IDisposable
    {
        ///<summary>
        ///  A class controlling all the variables and properties to be held 
        ///  in the table Manufacturer when the database is read
        ///</summary>
        #region Public Constructors
        public ClsManufacturer() { }
        public ClsManufacturer(int _manufacturerId, string _manufacturerName, string _manufacturerAddress, string _manufacturerTelNo)
        {
            ManufacurerId = _manufacturerId;
            ManufacurerName = _manufacturerName;
            ManufacturerAddress = _manufacturerAddress;
            ManufacturerTelNo = _manufacturerTelNo;
        }
        #endregion
        #region Private Variables
        private int manufacurerId;
        private string manufacurerName;
        private string manufacturerAddress;
        private string manufacturerTelNo;
        #endregion
        #region Public Properties
        public int ManufacurerId { get => manufacurerId; set => manufacurerId = value; }
        public string ManufacurerName { get => manufacurerName; set => manufacurerName = value; }
        public string ManufacturerAddress { get => manufacturerAddress; set => manufacturerAddress = value; }
        public string ManufacturerTelNo { get => manufacturerTelNo; set => manufacturerTelNo = value; }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}