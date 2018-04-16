using FluentValidation;

namespace ESX.UI.Web.Core.Validated
{
    public class PersonValidated : AbstractValidator<Aplication.Service.PersonViewModel.PersonViewModel>
    {
        public PersonValidated()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name is required");
            RuleFor(x => x.Email).NotNull().WithMessage("Email is required");
            RuleFor(x => x.Salary).NotNull().WithMessage("Salary is required");
        }
    }
}
