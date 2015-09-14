using MongoDB.Driver;
using parkSmartly.Data.Entities.Service;
using parkSmartly.Data.Interface;
using parkSmartly.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkSmartly.Data.Repository
{
    public class AccountStatementRepository : EntityService<AccountStatement>, IAccountStatementRepository
    {
        public async Task<decimal> GetCurrentBalance(string user)
        {
            var builder = Builders<AccountStatement>.Filter;
            var filter = builder.Eq("User", user);
            List<AccountStatement> accountStatement = await this.ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (accountStatement.Any())
            {
                var lastTransaction = accountStatement.OrderByDescending(n => n.Id).First();
                return lastTransaction.CurrentBalance;
            }
            return 0;
        }

        public async Task<List<AccountStatement>> GetStatement(string user)
        {
            var builder = Builders<AccountStatement>.Filter;
            var filter = builder.Eq("User", user);
            List<AccountStatement> accountStatement = await this.ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            return accountStatement;
        }
    }
}
