using Microsoft.AspNetCore.Mvc;

namespace assignment_four
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        //GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET: api/Users/id
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"value: {id}";
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody] string value) { }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}
