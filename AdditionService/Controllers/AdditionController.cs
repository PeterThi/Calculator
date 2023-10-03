using Microsoft.AspNetCore.Mvc;

namespace AdditionService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdditionController : ControllerBase
    {

        public AdditionController()
        {

        }

        [HttpPost]
        public int Post(int leftNumber, int rightNumber)
        {
            return leftNumber + rightNumber;

        }
    }
}