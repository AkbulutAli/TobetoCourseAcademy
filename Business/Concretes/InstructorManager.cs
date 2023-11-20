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
    public class InstructorManager : IInsturctorService
    {
        IInstructorDal _insturctorDal;

        public InstructorManager(IInstructorDal insturctorDal)
        {
            _insturctorDal = insturctorDal;
        }

        public IResult Add(Instructor instructor)
        {
            _insturctorDal.Add(instructor);
            return new SuccessResult(Messages.InstructorAdded);
        }

        public IResult Delete(Instructor instructor)
        {
            _insturctorDal.Delete(instructor);
            return new SuccessResult(Messages.InstructorDeleted);
        }

        public IDataResult<Instructor> Get(Expression<Func<Instructor, bool>> filter)
        {
            return new SuccessDataResult<Instructor>(_insturctorDal.Get(filter),Messages.InstructorListed);
        }

        public IDataResult<List<Instructor>> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            return new SuccessDataResult<List<Instructor>>(_insturctorDal.GetAll(filter), Messages.InstructorListed);
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Instructor>(_insturctorDal.Get(i=>i.Id==id),Messages.InstructorListed);

        }

        public IResult Update(Instructor instructor)
        {
            _insturctorDal.Update(instructor);
            return new SuccessResult(Messages.InstructorUpdated);
        }
    }
}
