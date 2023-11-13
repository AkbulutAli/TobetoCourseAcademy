using Entites.Concretes;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IInsturctorService
    {
        List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null);
        Instructor Get(Expression<Func<Instructor, bool>> filter);
        void Add (Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);

    }


}
