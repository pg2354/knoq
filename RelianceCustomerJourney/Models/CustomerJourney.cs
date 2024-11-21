using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelianceCustomerJourney.Models
{
    public class CustomerJourney
    {
        public string PreSrNumber { get; set; }
        public int Id { get; set; }
        public string ClientId { get; set; }

        public string CustomerName { get; set; }

        public string PolicyNo { get; set; }

        public string UserSapCode { get; set; }

        public string STCode { get; set; }

        public string STName { get; set; }

        public string BankAccountNo { get; set; }

        public string ConfirmBankAccountNo { get; set; }

        public string NeftCode { get; set; }

        public string BankName { get; set; }

        public string ExistingFund { get; set; }

        public string TargetFund { get; set; }

        public string MobileNo { get; set; }

        public string Emailid { get; set; }
        
    }
    
}