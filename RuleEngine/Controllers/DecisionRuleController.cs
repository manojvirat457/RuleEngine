using Microsoft.AspNetCore.Mvc;
using Core;
using Core.Models;

namespace RuleEngine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecisionRuleController : ControllerBase
    {

        private readonly ILogger<DecisionRuleController> _logger;

        public DecisionRuleController(ILogger<DecisionRuleController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [ActionName("Decision")]
        public Response ExecuteDecision([FromBody] DecisionRule ruleModel)
        {
            return Rule.ExecuteDecision(ruleModel);
        }
    }
}
