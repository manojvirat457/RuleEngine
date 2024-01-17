using Core.Exceptions;
using Core.Executor;
using Core.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Core.RuleTypes
{
    public static class Simple
    {
        public static bool BuildSimple(SimpleRule model)
        {
            return (bool)Evaluator._interpreter.Eval(model.Condition, Utilities.BuildParameters(model)) is bool v ? v : throw new RuleExecutionException();
        }
    }
}
