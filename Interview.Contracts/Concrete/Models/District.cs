using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interview.Contracts.Concrete.Models
{
    [Serializable()]
    public class District
    {
        public District()
        {
            Zips = new List<Zip>();
        }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlElement("Zip", typeof(Zip))]
        public List<Zip> Zips { get; set; }
    }
}
