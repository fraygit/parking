using parkSmartly.Data.Entities.Service;
using parkSmartly.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkSmartly.Data.Interface
{
    public interface ISearchRepository : IEntityService<Search>
    {
        void AssociateAddress(string id, string user);
        Task<List<Search>> GetAllSearches();
    }
}
