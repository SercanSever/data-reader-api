using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interview.Contracts.Concrete.Models
{
    [Serializable()]
    public class City
    {
        public City()
        {
            Districts = new List<District>();
        }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("code")]
        public string Code { get; set; }
        [XmlElement("District", typeof(District))]
        public List<District> Districts { get; set; }
    }
}
