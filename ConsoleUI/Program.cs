using Business.Concretes;
using Core.Utilities.Results;
using DataAccess.Concretes.EntityFramework;
using Entites.Concretes;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            //InstructorTest();
            CourseTest();



        }

        private static void CourseTest()
        {

            CourseManager courseManager = new CourseManager(new EfCourseDal());


            Course course1 = new Course
            {
                Name = "JAVASCRIPT",
                CategoryId = 1,
                InstructorId = 1,
                Price = 0,
                Description = "Hiç bir class çıplak olamaz.",
                ImageUrl = "www.google.com"
            };

            var result = courseManager.Add(course1);

            if (result.Success)
            {
                Console.WriteLine(course1.Name+" "+result.Message);

                //var data = courseManager.GetAll().Data.OrderByDescending(x=>x.Id).Take(1);
                //Console.WriteLine(data.ToList()[0].Name + " " + result.Message);

                //foreach ( var x in data )
                //{
                //    Console.WriteLine(x.Name + " " + result.Message);
                    
                //}

            }
            else 
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void InstructorTest()
        {
            InstructorManager instructorManager = new InstructorManager(new EfIntructorDal());

            Instructor instructor1 = new Instructor
            {
                Name = "Engin Demiroğ"
            };
            instructorManager.Add(instructor1);

            foreach (var item in instructorManager.GetAll().Data)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            Category category1 = new Category
            {
                Name = "",
            };

            categoryManager.Add(category1);
        }
    }
}