using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Exceptions
{
    public class RuleTypeMismatch: Exception
    {
        public RuleTypeMismatch() : base("Rule Condition mismatching with type")
        {

        }
    }
}
