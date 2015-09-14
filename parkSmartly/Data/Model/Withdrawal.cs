using parkSmartly.Data.Entities.Base;
using parkSmartly.Data.Entities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkSmartly.Data.Model
{
    public class Withdrawal : MongoEntity
    {
        public string User { get; set; }
        public decimal AmountToWithdraw { get; set; }
        public decimal ActualAmount { get; set; }
        public string AccountNumber { get; set; }
        public DateTime DateWithdrawal { get; set; }
    }
}
