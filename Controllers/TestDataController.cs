using AbodWebAPI.Middlewares;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Reflection.Metadata.Ecma335;

namespace AbodWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : ControllerBase
    {

        private readonly ILogger<TestDataController> _logger;

        public TestDataController(ILogger<TestDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTestData")]
        public IEnumerable<TestData> Get()
        {
            string json = System.IO.File.ReadAllText("test_data.json");
            var test_data = JsonConvert.DeserializeObject<List<TestData>>(json);

            if (test_data == null)
            {
                throw new Exception("Unable to load data");
            }

            return test_data.ToArray();
        }

        [HttpGet("{id}")]
        public TestData GetId(int id)
        {
            string json = System.IO.File.ReadAllText("test_data.json");
            var test_data = JsonConvert.DeserializeObject<List<TestData>>(json);

            if (test_data == null)
            {
                throw new Exception("Unable to load data");
            }

            var result = test_data.FirstOrDefault(s => s.Id == id);

            if(result == null)
            {
                throw new Exception("Unable to find ID");
            }

            return result;
        }
    }
}