using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevOpsTestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        string appEnvironment;
        public HomeController(IOptions<AppSettingData> settings)
        {
            appEnvironment = settings.Value.AppEnvironment;
        }

        [HttpGet("CheckEnvironment")]
        public ActionResult<string> CheckEnvironment()
        {
            return Ok("Hello I am " + appEnvironment);
        }
    }
}
