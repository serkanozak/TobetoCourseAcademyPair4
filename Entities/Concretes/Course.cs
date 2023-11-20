using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : IEntity
    {

        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public string InstructorId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
        public Instructor Instructor { get; set; }
    }
}
