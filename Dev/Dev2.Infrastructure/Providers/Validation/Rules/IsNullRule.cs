﻿using System;
using Dev2.Providers.Errors;

namespace Dev2.Providers.Validation.Rules
{
    public class IsNullRule : Rule<object>
    {
        public IsNullRule(Func<object> getValue)
            : base(getValue)
        {
        }

        public override IActionableErrorInfo Check()
        {
            var value = GetValue();
            if(value == null)
            {
                return new ActionableErrorInfo(DoError)
                {
                    Message = LabelText + " value cannot be null."
                };
            }
            return null;
        }
    }
}