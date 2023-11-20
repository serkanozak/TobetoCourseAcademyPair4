﻿using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService : IGenericService<Course>
    {
        IDataResult<List<CourseDetailDto>> GetCourseDetails();

    }
}
