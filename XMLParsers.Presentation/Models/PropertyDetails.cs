using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLParsers.Models
{
    [XmlRoot("row")]
    public class PropertyDetails
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [XmlElement("PropertyCode")]
        public int PropertyCode { get; set; }
        [XmlElement("AnnualRent")]
        public int AnnualRent { get; set; }
        [XmlElement("BuiltArea")]
        public int BuiltArea { get; set; }
        [XmlElement("IsRented")]
        public bool IsRented { get; set; } 
    }
}
