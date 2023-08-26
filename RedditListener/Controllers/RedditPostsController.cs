using Microsoft.AspNetCore.Mvc;
using RestSharp;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//Api controller class 
//Gets live threads and discussions based on upvotes/users

namespace RedditListener.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedditPostsController : ControllerBase
    {
        // GET: api/<PostsControlle>
        [HttpGet]
        public IEnumerable<string> GetLiveThreads()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PostsControlle>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostsControlle>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PostsControlle>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostsControlle>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        



    // [HttpGet("{id}", Name = "GetPosts")]
    //public async Task<IActionResult> GetByIdAsync(long id)
    //{
    //    var client = new RestClient($"http://api.football-data.org/v1/competitions/{id}/leagueTable");
    //    var request = new RestRequest(Method.Get);
    //    IRestResponse response = await client.ExecuteAsync(request);

    //    //TODO: transform the response here to suit your needs

    //    return Ok(data);
    }
}

