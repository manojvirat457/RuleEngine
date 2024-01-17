using DynamicExpresso;
using Core.Exceptions;
using Core.Models;
using Core.RuleTypes;

namespace Core
{
    public static class Rule
    {
        public static Response ExecuteSimple(SimpleRule ruleModel)
        {
            try
            {
                return new Response() { result = Simple.BuildSimple(ruleModel) };
            }
            catch (RuleTypeMismatch ex)
            {
                throw ex;
            }
            catch (RuleExecutionException ex)
            {
                throw ex;
            }
        }

        public static Response ExecuteDecision(DecisionRule ruleModel)
        {
            try
            {
                return new Response() { result = Decision.BuildDecision(ruleModel)};
            }
            catch (RuleTypeMismatch ex)
            {
                throw ex;
            }
            catch (RuleExecutionException ex)
            {
                throw ex;
            }
        }
        

        

    }
}