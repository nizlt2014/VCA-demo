
using ClaimsService.Application.DTOs;
using FluentValidation;

namespace ClaimsService.Application.Validators
{
    public class CreateClaimDtoValidator : AbstractValidator<CreateClaimDto>
    {
        public CreateClaimDtoValidator()
        {
            RuleFor(x => x.ClaimNumber).GreaterThan(0);
            RuleFor(x => x.PolicyId).GreaterThan(0);
            RuleFor(x => x.CustomerId).GreaterThan(0);
        }
    }
}
