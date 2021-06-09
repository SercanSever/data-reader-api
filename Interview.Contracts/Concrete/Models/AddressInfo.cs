using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interview.Contracts.Concrete.Models
{
    [XmlRoot("AddressInfo")]
    public class AddressInfo
    {
        [XmlElement("City", typeof(City))]
        public List<City> City { get; set; }
    }
}
