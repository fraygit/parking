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
    public class UserProfileRepository : EntityService<UserProfile>, IUserProfileRepository
    {
        public async Task<UserProfile> GetUserProfile(string user)
        {
            var builder = Builders<UserProfile>.Filter;
            var filter = builder.Eq("Username", user);
            var userProfile = await this.ConnectionHandler.MongoCollection.Find(filter).FirstOrDefaultAsync();
            return userProfile;
        }
    }
}
