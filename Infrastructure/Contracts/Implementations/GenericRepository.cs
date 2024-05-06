using Application.Contracts.Interfaces;
using Domain.Models.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts.Implementations
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            
        }
        public Task Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public Task<List<TEntity>> GetAll()
        {
            return _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            var result = _dbSet.Find(id);
            if (result == null)
            {
                throw new Exception("Not Found");
            }
            return result;
        }
        public async Task Insert(TEntity entity)
        {
             await _dbSet.AddAsync(entity);
        }

        public Task Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }

    }
}
