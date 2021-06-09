using Interview.Contracts.Concrete.Models;
using Interview.Contracts.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interview.Service.Services
{
    public class XmlDataConverterService : IDataConverterService
    {
        public List<City> ConvertData()
        {
            string path = ConfigurationManager.AppSettings["xmlPath"];
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AddressInfo));
            StreamReader reader = new StreamReader(path);
            var result = (AddressInfo)xmlSerializer.Deserialize(reader);
            reader.Close();
            return result.City;
        }
    }
}
