using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingInASPNETCoreWebAPI.Controllers
{

    [ApiController]
    public class RoutingASPDOTNETController : ControllerBase
    {
        public int idNum;
        public string nameOfEmp;

        [HttpPost]
        [Route("api/outingInASPNETCoreWebAPI/setData")]
        public IActionResult SetData(string name, int id)
        {
            idNum = id;
            nameOfEmp = name;
            if (nameOfEmp != null && idNum != null)
            {
                return Ok(nameOfEmp + " " + idNum);
            }
            else
            {

                return NotFound("Data not found");
            }
        }
    }
}