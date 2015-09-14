﻿using MongoDB.Driver;
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
    public class BadgeRepository : EntityService<Badge>, IBadgeRepository
    {
        public async Task<Badge> GetBadge(string user)
        {
            var builder = Builders<Badge>.Filter;
            var filter = builder.Eq("User", user);
            var badge = await this.ConnectionHandler.MongoCollection.Find(filter).FirstOrDefaultAsync();
            return badge;
        }

        public async Task<bool> SubmitCode(string code, string user)
        {
            var builder = Builders<Badge>.Filter;
            var filter = builder.Eq("User", user);
            var badge = await this.ConnectionHandler.MongoCollection.Find(filter).FirstOrDefaultAsync();
            if (badge.Code == code)
            {
                var update = Builders<Badge>.Update
                .Set("IsAddressVerified", "True")
                .CurrentDate("lastModified");
                await this.ConnectionHandler.MongoCollection.UpdateOneAsync(filter, update);
                return true;
            }
            return false;
        }
    }
}
