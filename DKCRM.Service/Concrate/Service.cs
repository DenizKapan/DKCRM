using DKCRM.Core.Entities;
using DKCRM.Data;
using DKCRM.Data.Abstract;
using DKCRM.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Service.Concrate
{
    public class Service<T> : Repository<T> where T : class, IEntitiy, new()
    {
        public Service(DatabaseContext context) : base(context)
        {
        }
    }
}
