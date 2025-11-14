using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Villa.Logging;
using Villa.Models.DTO;
using Villa.Services;

namespace Villa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestConnection : ControllerBase
    {
        public readonly ITestConnectionService _connectionService;

        public TestConnection (ITestConnectionService service)
        {
            _connectionService = service;
        }


        [HttpPost("test")]
        public IActionResult Test([FromBody]TestDTO test)
        {

            bool ok = _connectionService.TestConnection(test.server, test.username, test.password, out string err);

            if (ok)
            {
                return Ok(new { success = true, message = "Connection successful" });
            }

            return BadRequest(new { success = false, message = "Connection failed", error = err });

        }
    }
}
