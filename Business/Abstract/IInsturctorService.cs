using Core.Utilities.Results;
using Entites.Concretes;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        IDataResult<List<Instructor>> GetAll(Expression<Func<Instructor, bool>> filter = null);
        IDataResult<Instructor> Get(Expression<Func<Instructor, bool>> filter);
        IResult Add (Instructor instructor);
        IResult Update(Instructor instructor);
        IResult Delete(Instructor instructor);
		IDataResult<Instructor> GetById(int id);


    }


}
