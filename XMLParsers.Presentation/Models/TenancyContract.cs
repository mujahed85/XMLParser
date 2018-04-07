using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLParsers.Models
{
    public class TenancyContract
    {
        #region POCO Properties Decalaration
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractCode { get; set; }
        public int ContractAmount { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public string ContractStatus { get; set; }
        public int SecurityDeposit { get; set; }
        public int PaymentCount { get; set; }
        #endregion


        List<PropertyDetails> PropertyInformations = null;
        TenantInformations objTenantInformations = null;

        public TenancyContract()
        {
            PropertyInformations = new List<PropertyDetails> ();
            objTenantInformations = new TenantInformations();
        }
    }
}
