using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Data.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression); // x=>x.name == "elektronik". Geriye sorgu sonucunda gönderilen class ın db deki listesini döner
        void Add(T entity);
        T Find(int id);
        T Get(Expression<Func<T, bool>> expression); // geriye sorgu sunucunda 1 kayıt döner
        void Update(T entity);
        void Delete(T entity);
        int Save();
        // Asenkron Metotlar
        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task<int> SaveAsync();
    }
}
