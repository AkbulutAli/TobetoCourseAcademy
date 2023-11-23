using Business.Abstract;
using Entites.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InstructorsController : ControllerBase
	{
		IInstructorService _instructorService;
		public InstructorsController(IInstructorService instructorService)
		{
			_instructorService = instructorService;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _instructorService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("get")]
		public IActionResult Get(int id)
		{
			var result = _instructorService.GetById(id);
			if (result.Success)
			{
				return Ok(result);

			}
			return BadRequest(result);
		}


		[HttpPost("add")]
		public IActionResult Add(Instructor instructor)
		{
			var result = _instructorService.Add(instructor);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpDelete("delete")]
		public IActionResult Delete(int id)
		{
			var deletedCourse = _instructorService.GetById(id).Data;
			var result = _instructorService.Delete(deletedCourse);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Instructor instructor)
		{
			var result = _instructorService.Update(instructor);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
