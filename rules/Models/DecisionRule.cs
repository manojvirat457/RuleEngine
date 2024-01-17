namespace Core.Models
{
    public class DecisionRule : BaseRule
    {
        public List<RuleItem>? Condition { get; set; }
        public object Default { get; set; } = "";
    }

    public class RuleItem
    {
        public string? Expression { get; set; }
        public string? Result { get; set; }

    }
}
