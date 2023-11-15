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
                Name = "C#",
                CategoryId = 1,
                InstructorId = 1,
                Price = 0,
                Description = "Hiç bir class çıplak olamaz.",
                ImageUrl = "www.google.com"
            };


            var result = courseManager.Add(course1);
            if (result.Success)
            {
                Console.WriteLine("Ürün eklendi");
                Console.WriteLine(result.Messages);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //Console.WriteLine(courseManager.Add(course1).Message);


            //foreach (var item in courseManager.Add(course1))
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine(item.Description);


            //}


            //Console.WriteLine(courseManager.GetByCategoryId(1)[0].Name);
        }

        private static void InstructorTest()
        {
            InstructorManager instructorManager = new InstructorManager(new EfIntructorDal());

            Instructor instructor1 = new Instructor
            {
                Name = "Engin Demiroğ"
            };
            instructorManager.Add(instructor1);

            foreach (var item in instructorManager.GetAll())
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