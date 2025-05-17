using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsAPI.Domain.AppEntity;
using NewsAPI.Infastrcture;

namespace NewsAPI.AppHandler.Genrics
{
    public class GenricRepo<T> : IGenricRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;

        public GenricRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(T item)
        => await _dbContext.Set<T>().AddAsync(item);

        public void DeleteAsync(T item)
        {
            _dbContext.Remove(item);
        }

        public async Task<IEnumerable<T>> GetAllWithAsync() => await _dbContext.Set<T>().AsNoTracking().ToListAsync();

        public async Task<T?> GetbyIdAsync(int id) => await _dbContext.Set<T>().FindAsync(id);

        public void Update(T item)
        {
            _dbContext.Update(item);
        }
    }
}
