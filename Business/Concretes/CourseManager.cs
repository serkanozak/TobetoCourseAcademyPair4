using Business.Abstracts;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
            if (course.CourseName.Length<3)
            {
                return new ErrorResult(Messages.CourseError);
            }

            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccesDataResult<List<Course>>(_courseDal.GetAll(), Messages.CourseListed);
        }

        public IDataResult<Course> GetById(int Id)
        {
            return new SuccesDataResult<Course>(_courseDal.Get(c => c.CourseId == Id), Messages.CourseListed);
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccesDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails(), Messages.CourseListed);
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseModified);
        }
    }
}
