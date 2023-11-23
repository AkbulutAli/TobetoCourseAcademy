using Core.Utilities.Results;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null);
        IDataResult<Category> Get(Expression<Func<Category, bool>> filter);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
		IDataResult<Category> GetById(int id);

    }



}
