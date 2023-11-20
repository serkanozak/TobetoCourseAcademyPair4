using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobeteCourseContext>, ICourseDal
    {
        public List<CourseDetailDto>  GetCourseDetails()
        {
            using (TobeteCourseContext context = new TobeteCourseContext())
            {
                var result = from co in context.Courses
                             join ca in context.Categories
                             on co.CategoryId equals ca.CategoryId
                             select new CourseDetailDto
                             {
                                 CourseId = co.CourseId,
                                 CategoryName = ca.CategoryName,
                                 CourseName = co.CourseName
                             };
                return result.ToList();


            }
        }




    }
}
