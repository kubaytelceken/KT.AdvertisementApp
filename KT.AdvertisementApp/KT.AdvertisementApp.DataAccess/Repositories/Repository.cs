using KT.AdvertisementApp.Common.Enums;
using KT.AdvertisementApp.DataAccess.Contexts;
using KT.AdvertisementApp.DataAccess.Interfaces;
using KT.AdvertisementApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AdvertisementContext _context;

        public Repository(AdvertisementContext context)
        {
            _context = context;
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>> filter)
        {
            return await _context.Set<T>().Where(filter).AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<Tkey>(Expression<Func<T, Tkey>> selector,OrderByType orderByType = OrderByType.DESC)
        {
            if(orderByType == OrderByType.ASC)
            {
                return await _context.Set<T>().AsNoTracking().OrderBy(selector).ToListAsync();
            }
            else
            {
                return await _context.Set<T>().AsNoTracking().OrderByDescending(selector).ToListAsync();
            }         
        }


        public async Task<List<T>> GetAllAsync<Tkey>(Expression<Func<T, bool>> filter,Expression<Func<T, Tkey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            if (orderByType == OrderByType.ASC)
            {
                return await _context.Set<T>().OrderBy(selector).Where(filter).AsNoTracking().ToListAsync();
            }
            else
            {
                return await _context.Set<T>().OrderByDescending(selector).Where(filter).AsNoTracking().ToListAsync();
            }
        }

        public async Task<T> FindAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter,bool asnoTracking=false)
        {
            return !asnoTracking ? await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter) : await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public IQueryable<T> GetQuery()
        {
            return _context.Set<T>().AsQueryable(); 
        }


        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity,T unchanged)
        {
            _context.Entry(unchanged).CurrentValues.SetValues(entity);
        }
    }
}
