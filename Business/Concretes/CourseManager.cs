using Business.Abstract;
using DataAccess.Abstracts;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            return _courseDal.Get(filter);
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            return _courseDal.GetAll(filter);
        }

        public List<Course> GetByCategoryId(int categoryId)
        {
            return _courseDal.GetAll(p=> p.CategoryId == categoryId);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
