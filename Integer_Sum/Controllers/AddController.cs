using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integer_Sum.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        public int Post(IntegerModel model)
        {
            if (model.FirstInteger == 0 || model.SecondInteger == 0)
                throw new ArgumentNullException("FirstInteger or SecondInteger is required");

            return model.FirstInteger + model.SecondInteger;
        }
    }
}
