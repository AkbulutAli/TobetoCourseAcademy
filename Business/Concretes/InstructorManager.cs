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
    public class InstructorManager : IInsturctorService
    {
        IInstructorDal _insturctorDal;

        public InstructorManager(IInstructorDal insturctorDal)
        {
            _insturctorDal = insturctorDal;
        }

        public void Add(Instructor instructor)
        {
            _insturctorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _insturctorDal.Delete(instructor);
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            return _insturctorDal.Get(filter);
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            return _insturctorDal.GetAll(filter);
        }

        public void Update(Instructor instructor)
        {
            _insturctorDal.Update(instructor);
        }
    }
}
