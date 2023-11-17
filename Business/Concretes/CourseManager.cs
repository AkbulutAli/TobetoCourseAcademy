using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public IDataResult<Course> Get(Expression<Func<Course, bool>> filter)
        {
            return new SuccessDataResult < Course > (_courseDal.Get(filter),Messages.CoursesListed);
        }

        public IDataResult<List<Course>> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(filter),Messages.CoursesListed);
        }

        public IDataResult<List<Course>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p=> p.CategoryId == categoryId));
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);

        }
    }
}
