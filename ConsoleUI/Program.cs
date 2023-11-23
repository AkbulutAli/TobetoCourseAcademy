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
			//CourseTest();
			//DeleteCourse();
			//UpdateCourse();
			//CourseGetByDetail();
			//CourseGet();
			CourseGetAll();

		}

		private static void CourseGetAll()
		{
			CourseManager courseManager = new CourseManager(new EfCourseDal());
			var result = courseManager.GetAll();
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine(result.Message);
			Console.WriteLine("----------------------------------------------");
			foreach (var item in result.Data)
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.Price);
				Console.WriteLine(item.Description);
				Console.WriteLine("*******************************");


			}
		}

		private static void CourseGet()
		{
			CourseManager courseManager = new CourseManager(new EfCourseDal());
			var result = courseManager.Get(c => c.Price > 0);
			Console.WriteLine(result.Data.Name);
			Console.WriteLine(result.Data.Price);
			Console.WriteLine(result.Data.Description);
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine(result.Message);
			Console.WriteLine("----------------------------------------------");
		}

		private static void CourseGetByDetail()
		{
			CourseManager courseManager = new CourseManager(new EfCourseDal());
			var updatedCourse = courseManager.GetDetails();
			Console.WriteLine(updatedCourse.Message);
			foreach (var item in updatedCourse.Data)
			{
				Console.WriteLine(item.CourseId);
				Console.WriteLine(item.CourseName);
				Console.WriteLine(item.InstructorName);
				Console.WriteLine(item.CategoryName);
			}
			
			
		}

		private static void UpdateCourse()
		{
			CourseManager courseManager = new CourseManager(new EfCourseDal());
			var updatedCourse = courseManager.GetById(4);
			Console.WriteLine(updatedCourse.Data.Name);
			Console.WriteLine(updatedCourse.Data.Price);
			Console.WriteLine(updatedCourse.Data.Description);
			updatedCourse.Data.Price = 2000;
			updatedCourse.Data.Description = "Orhan Test";
			var result = courseManager.Update(updatedCourse.Data);
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine(result.Message);
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine(updatedCourse.Data.Name);
			Console.WriteLine(updatedCourse.Data.Price);
			Console.WriteLine(updatedCourse.Data.Description);
		}

		private static void DeleteCourse()
		{
			CourseManager courseManager = new CourseManager(new EfCourseDal());
			var deletedCourse = courseManager.GetById(3);
			var result = courseManager.Delete(deletedCourse.Data);
			Console.WriteLine(result.Message);
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
			Course course2 = new Course
			{
				Name = "C#",
				CategoryId = 2,
				InstructorId = 2,
				Price = 0,
				Description = "Hiç bir class çıplak olamaz.",
				ImageUrl = "www.google.com"
			};

			courseManager.Add(course1);
			courseManager.Add(course2);

			//if (result.Success)
			//{
			//    Console.WriteLine(course1.Name+" "+result.Message);

			//    //var data = courseManager.GetAll().Data.OrderByDescending(x=>x.Id).Take(1);
			//    //Console.WriteLine(data.ToList()[0].Name + " " + result.Message);

			//    //foreach ( var x in data )
			//    //{
			//    //    Console.WriteLine(x.Name + " " + result.Message);

			//    //}

			//}
			//else 
			//{
			//    Console.WriteLine(result.Message);
			//}

		}

		private static void InstructorTest()
		{
			InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

			Instructor instructor1 = new Instructor
			{
				Name = "Engin Demiroğ"
			};
			Instructor instructor2 = new Instructor
			{
				Name = "Halit Enes Kalaycı"
			};
			instructorManager.Add(instructor1);
			instructorManager.Add(instructor2);

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
				Name = "Programlama",
			};
			Category category2 = new Category
			{
				Name = "Yazılım",
			};

			categoryManager.Add(category1);
			categoryManager.Add(category2);
		}
	}
}