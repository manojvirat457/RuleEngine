using DynamicExpresso;

namespace Core.Executor
{
    public static class Evaluator
    {
        public static readonly Interpreter _interpreter = new Interpreter();

        public static object Evaluate(this string rule)
        {
            return _interpreter.Eval(rule);

        }
    }
}
