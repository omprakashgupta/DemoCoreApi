using Library.Model;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoCoreApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		// GET: api/<UserController>
		[HttpPost]
		[Route("Search")]
		[SwaggerOperation(Summary = "Search user", Description = "My description")]
		public ActionResult<string[]> Search([FromBody] SearchUserDto search)
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<UserController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<UserController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<UserController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<UserController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
