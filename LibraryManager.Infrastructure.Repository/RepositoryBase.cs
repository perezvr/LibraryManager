using LibraryManager.Domain.Core.Interfaces.Repositories;
using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManager.Infrastructure.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : ModelBase
    {
        protected readonly ApplicationContext _context;

        protected DbSet<T> DbSet { get; set; }

        public RepositoryBase(ApplicationContext context)
        {
            _context = context;
            DbSet = context.Set<T>();
        }

        public void Add(T obj)
        {
            DbSet.Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T obj)
        {
            DbSet.Remove(obj);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> Get()
        {
            return DbSet.ToList();
        }

        public virtual T Get(int id)
        {
            return DbSet.Find(id);
        }
    }
}
