using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entites.Concretes;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course,TobetoCourseAcademyContext>,ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails() 
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var result = from c in context.Courses
                             join ca in context.Categories
                             on c.CategoryId equals ca.Id
                             join i in context.Instructors
                             on c.InstructorId equals i.Id
                             select new CourseDetailDto
                             {
                                 CategoryName = ca.Name,
                                 CourseId = c.Id,
                                 CourseName = c.Name,
                                 InstructorName = i.Name,

                             };
                return result.ToList();

            }
        }
       
    }
}
