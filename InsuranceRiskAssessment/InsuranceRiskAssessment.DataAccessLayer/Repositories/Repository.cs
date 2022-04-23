using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Data;
using InsuranceRiskAssessment.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceRiskAssessment.DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly InsuranceRiskAssessmentDbContext _context;
        public Repository(InsuranceRiskAssessmentDbContext dbContext)
        {
            _context = dbContext;
        }
        public bool Create(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            _context.Set<T>().Add(entity);
            return _context.SaveChanges() != 0;
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            return _context
                .Set<T>()
                .Where(predicate)
                .ToList();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _context.
                Set<T>()
                .FirstOrDefault(predicate);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges() != 0;
        }

        public bool RemoveById(int id)
        {
            var item = _context.Set<T>().FirstOrDefault(item => item.Id == id);
            if (item != null)
            {
                _context.Set<T>()
                    .Remove(item);
                return _context.SaveChanges() != 0;

            }
            else
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            if (entity.Id != 0)
            {
                entity.ModifiedAt = DateTime.Now;
                _context.Update(entity);
                return _context.SaveChanges() != 0;
            }
            else
            {
                return false;
            }
        }
    }
}
