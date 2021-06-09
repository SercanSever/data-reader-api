using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interview.Contracts.Concrete.Models
{
    [Serializable()]
    public class Zip
    {
        [XmlAttribute("code")]
        public string Code { get; set; }
    }
}
