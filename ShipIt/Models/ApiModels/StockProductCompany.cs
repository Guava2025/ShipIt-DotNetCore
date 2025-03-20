using System.Collections;
using System.Data;
using ShipIt.Models.ApiModels;
using ShipIt.Models.DataModels;

namespace ShipIt.Models.ApiModels
{
    public class StockProductCompany
    {
        public StockDataModel StockDataModel { get; set; }
        public CompanyDataModel CompanyDataModel { get; set; }
        public ProductDataModel ProductDataModel { get; set; }

        public StockProductCompany(IDataReader dataReader) 
        {
            StockDataModel = new StockDataModel(dataReader);
            CompanyDataModel = new CompanyDataModel(dataReader);
            ProductDataModel = new ProductDataModel(dataReader);
        }
        
    }
}