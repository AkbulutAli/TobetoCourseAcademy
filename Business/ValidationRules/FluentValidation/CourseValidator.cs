using Entites.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {            
			RuleFor(c => c.Name).NotEmpty();
			RuleFor(c => c.Name).MinimumLength(2);
			RuleFor(c => c.Price).NotEmpty();
			RuleFor(c => c.Price).GreaterThan(0);
			RuleFor(c => c.Price).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
			RuleFor(c => c.Name).Must(StartsWithA).WithMessage("Ürünler A harfi ile başlamalı");
		}
		private bool StartsWithA(string arg)
		{
			return arg.StartsWith("A");
		}
	}

}
