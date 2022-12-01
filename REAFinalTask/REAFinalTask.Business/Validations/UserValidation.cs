using FluentValidation;
using REAFinalTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.Business.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.UserName).NotNull().NotEmpty().WithMessage("Username can not be null!").WithMessage("Username can not be null!").
              MinimumLength(1).WithMessage("Username must be has 1 character at least!");
        }
    }
}
