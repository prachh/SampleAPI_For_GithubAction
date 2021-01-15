using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Data;
using SampleAPI.Repository;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly IValueRepo valueRepo;
        public ValuesController(IValueRepo vr)
        {
            valueRepo = vr;
        }

       
        [HttpGet]
        [Route("ipinfo")]
        public async Task<ActionResult<IPtoCountry>> GetIpInfo(string ip)
        {
            return await valueRepo.GetIpInfo(ip);
        }

        [HttpPost]
        [Route("calculate")]
        public async Task<ActionResult<double>> CalCulate([FromBody]Operation operation)
        {
            return await valueRepo.CalCulater(operation);
        }

    }
}
