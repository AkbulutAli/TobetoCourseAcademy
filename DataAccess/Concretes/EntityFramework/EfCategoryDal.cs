using DataAccess.Abstracts;
using Entites.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                return filter == null
                    ? context.Set<Category>().ToList() 
                    : context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
