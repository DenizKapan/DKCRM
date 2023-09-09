using DKCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Data.Abstract
{
    public interface IDistrictRepository : IRepository<District>
    {
        Task<District> GetDistrict(int districtId);
        Task<District> GetDistrictAsync(Expression<Func<District, bool>> expression);
        Task<List<District>> GetDistrict();
        Task<List<District>> GettDistrictAsync(Expression<Func<District, bool>> expression);
    }
}
