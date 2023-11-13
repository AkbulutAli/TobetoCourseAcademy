using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entites.Concretes;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            //Category category1 = new Category
            //{
            //    Name = "",
            //};

            //categoryManager.Add(category1);

            InstructorManager instructorManager = new InstructorManager(new EfIntructorDal());

            //Instructor instructor1 = new Instructor
            //{
            //    Name = "Engin Demiroğ"
            //};
            //instructorManager.Add(instructor1);

            //foreach (var item in instructorManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}


            CourseManager courseManager = new CourseManager(new EfCourseDal());
            //Course course1 = new Course
            //{
            //    Name = "C#",CategoryId = 1,InstructorId = 1,Price=0, Description="Hiç bir class çıplak olamaz.",ImageUrl="www.google.com"
            //};


            //courseManager.Add(course1);

            //foreach (var item in courseManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine(item.Description);

            //}


            Console.WriteLine(courseManager.GetByCategoryId(1)[0].Name);

        }
    }
}