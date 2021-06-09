using Interview.Contracts.Concrete.Models;
using Interview.Contracts.Contracts;
using Interview.Service.CustomExceptions;
using Interview.Service.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Service.Manager
{
    public class DataConverterManagerService : IDataConverterManagerService
    {
        public IDataConverterService GetConverter()
        {
            string source = ConfigurationManager.AppSettings["defaultDataSource"];
            switch (source)
            {
                case "XML": return Activator.CreateInstance<XmlDataConverterService>();
                case "CSV": return Activator.CreateInstance<CsvDataConverterService>();
                default:
                    throw new InvalidSourceTypeException();
            }
        }

        public void SetDataSourceToCsv()
        {
            ConfigurationManager.AppSettings.Set("defaultDataSource", "CSV");
        }

        public void SetDataSourceToXml()
        {
            ConfigurationManager.AppSettings.Set("defaultDataSource", "XML");
        }
    }
}
