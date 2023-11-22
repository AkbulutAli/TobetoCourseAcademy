using Core.Utilities.Results;
using Entites.Concretes;
using Entites.DTOs;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll(Expression<Func<Course, bool>> filter = null);
        IDataResult<Course> Get(Expression<Func<Course, bool>> filter);
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);
        IDataResult<List<Course>> GetByCategoryId(int categoryId);
        IDataResult<List<CourseDetailDto>> GetDetails();
        IDataResult<Course> GetById(int id);

    }



}
