using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult();
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult();
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccesDataResult<List<Instructor>>(_instructorDal.GetAll());
        }

        public IDataResult<Instructor> GetById(int Id)
        {
            return new SuccesDataResult<Instructor>(_instructorDal.Get(i => i.InstructorId == Id));
        }

        public IResult Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
            return new ErrorResult();

        }
    }
}
