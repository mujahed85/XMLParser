using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLParsers.Models
{
    public class TenantInformations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TenantCode { get; set; }
        public string TenantName { get; set; }
        public int TenantType { get; set; }
        public int TradeLicenseNumber { get; set; }
        public int TradeLicenseState { get; set; }
        public int ContractCode { get; set; }
    }
}
