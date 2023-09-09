using DKCRM.Core.Entities;
using DKCRM.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Data.Concrate
{
    public class DistrictRepository : Repository<District>, IDistrictRepository
    {
        public DistrictRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<District> GetDistrict(int id)
        {
            return await _context.Districts.AsNoTracking().Include(p => p.CityID).ToListAsync(); //-- _context.Districts.AsNoTracking().Include(p => p.CityID).ToListAsync();
        }

        public Task<List<District>> GetDistrict()
        {
            throw new NotImplementedException();
        }

        public Task<District> GetDistrictAsync(Expression<Func<District, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<District>> GettDistrictAsync(Expression<Func<District, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
