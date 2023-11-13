using Entites.Concretes;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetAll(Expression<Func<Course, bool>> filter = null);
        Course Get(Expression<Func<Course, bool>> filter);
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
        List<Course> GetByCategoryId(int categoryId);
    }



}
