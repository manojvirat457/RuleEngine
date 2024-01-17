using Core.Exceptions;
using Core.Extensions;
using Core.Models;
using DynamicExpresso;
using System.Text.Json;

namespace Core
{
    public static class Utilities
    {
        public static Parameter[] BuildParameters(BaseRule ruleModel)
        {
            List<Parameter> parameters = new List<Parameter>();

            foreach (var input in ruleModel.Input)
            {
                parameters.Add(new Parameter(name: input.Key, value: input.Value));
            }

            return parameters.ToArray();
        }


    }
}
