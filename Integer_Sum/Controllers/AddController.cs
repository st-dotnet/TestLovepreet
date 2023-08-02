using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integer_Sum.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly IntegerSumContext _context;

        public AddController(IntegerSumContext context)
        {
           _context = context;
        }
        public int Post(IntegerModel model)
        {
            if (model.FirstInteger == 0 || model.SecondInteger == 0)  
                throw new ArgumentNullException("FirstInteger or SecondInteger is required");

            var result= model.FirstInteger + model.SecondInteger;

            _context.IntegerSums.Add(new IntegerSum { IntegersSum = result });
            _context.SaveChanges();
            return result;
        }
    }
}
