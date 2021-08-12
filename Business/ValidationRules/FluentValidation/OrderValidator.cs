using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Quantity).GreaterThan(2);
        }
    }
}
