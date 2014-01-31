﻿using System;
using Dev2.Providers.Errors;

namespace Dev2.Providers.Validation.Rules
{
    public class IsNumericRule : Rule<string>
    {
        public IsNumericRule(Func<string> getValue, Action onInvalid = null)
            : base(getValue, onInvalid)
        {
        }

        public override IActionableErrorInfo Check()
        {
            int value;
            if(!int.TryParse(GetValue(), out value))
            {
                return new ActionableErrorInfo(OnInvalid)
                {
                    Message = "The value must be a whole number.",
                    FixData = "Please provide a whole number for this field."
                };
            }
            return null;
        }
    }
}

