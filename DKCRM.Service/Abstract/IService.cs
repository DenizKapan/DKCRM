using DKCRM.Core.Entities;
using DKCRM.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntitiy, new()
    {
    }
}
