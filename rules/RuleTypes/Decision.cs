using Core.Executor;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RuleTypes
{
    public static class Decision
    {
        public static List<object> BuildDecision(DecisionRule model)
        {
            List<RuleItem> conditions = model.Condition ?? new List<RuleItem>();
            var parameters = Utilities.BuildParameters(model);
            List<object> result = new List<object>();

            foreach (RuleItem rule in conditions)
            {
                if ((bool)Evaluator._interpreter.Eval(rule.Expression, parameters)) result.Add(rule.Result);
            }

            if(result.Count == 0)
            {
                result.Add(model.Default);
            }

            return result;
        }
    }
}

