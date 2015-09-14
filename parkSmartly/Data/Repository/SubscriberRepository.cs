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
    public class SubscriberRepository : EntityService<Subscriber>, ISubscriberRepository
    {
    }
}
