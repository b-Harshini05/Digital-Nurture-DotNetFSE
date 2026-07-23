using Microsoft.AspNetCore.Mvc;

namespace Handson1_FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new()
        {
            "Value1",
            "Value2",
            "Value3"
        };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound();

            return Ok(values[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);

            return Ok(values);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] string value)
        {
            if(id<0 || id>=values.Count)
                return BadRequest();

            values[id]=value;

            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(id<0 || id>=values.Count)
                return BadRequest();

            values.RemoveAt(id);

            return Ok(values);
        }
    }
}