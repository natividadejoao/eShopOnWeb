using FluentValidation;
using Web.Response.ResponseProBasket;

namespace Web.Validation.ValidationBasket
{
    public class UpdateProBasketCommandValidator : AbstractValidator<UpdateProBasketById>
    {
        public UpdateProBasketCommandValidator()
        {   
            RuleFor( x => x.id).NotEmpty();
            RuleFor(x => x.item).NotEmpty();
        }
    }
}