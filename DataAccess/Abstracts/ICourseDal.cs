using Core.DataAccess;
using Entites.Concretes;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal : IEntityRepository<Course>
    {
        List<CourseDetailDto> GetCourseDetails();
    }
}
