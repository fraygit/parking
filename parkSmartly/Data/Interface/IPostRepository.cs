using parkSmartly.Data.Entities.Service;
using parkSmartly.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkSmartly.Data.Interface
{
    public interface IPostRepository : IEntityService<Space>
    {
        Task<List<Space>> GetSpacesByUser(string username);
        Task<Space> GetSpaces(string spaceObjectId);
        Task<bool> UpdatePhoto(string id, string path);
    }
}
