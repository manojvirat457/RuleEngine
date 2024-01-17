using Microsoft.AspNetCore.Mvc;
using Core;
using Core.Models;

namespace RuleEngine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleRuleController : ControllerBase
    {

        private readonly ILogger<SimpleRuleController> _logger;

        public SimpleRuleController(ILogger<SimpleRuleController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [ActionName("Simple")]
        public Response ExecuteSimple([FromBody] SimpleRule ruleModel)
        {
            return Rule.ExecuteSimple(ruleModel);   
        }
    }
}
