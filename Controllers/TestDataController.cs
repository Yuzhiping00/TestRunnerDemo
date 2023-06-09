using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestRunnerDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : ControllerBase
    {
        public TestDataController()
        {
        }

        [Authorize]
        [HttpGet]
        public ActionResult<List<TestData>> Get()
        {
            var data = new List<TestData>
            {
                new TestData
                {
                    Id = 4,
                    Name = "Test 1"
                },
            };

            return this.Ok(data);
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return new ContentResult
            {
                StatusCode = 400,
                Content = "Delete is not supported"
            };
        }
    }
}