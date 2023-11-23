using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entites.Concretes;
using Entites.DTOs;
using System.Linq.Expressions;
using Core.Aspects.Autofac.Validation;


namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
		[ValidationAspect(typeof(CourseValidator))]
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

       

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(c=>c.Id==id),Messages.CoursesListed);
        }

        public IDataResult<List<CourseDetailDto>> GetDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails(),Messages.CoursesListed);//mesaj düzeltilecek
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);

        }
    }
}
