using parkSmartly.Data.Entities.Service;
using parkSmartly.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkSmartly.Data.Interface
{
    public interface IAccountStatementRepository : IEntityService<AccountStatement>
    {
        Task<decimal> GetCurrentBalance(string user);
        Task<List<AccountStatement>> GetStatement(string user);
    }
}
