using Entites.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).Must(StartWithB);
        }
        private bool StartWithB(string arg)
        {
            return arg.StartsWith("B");
        } 
    }
}
