using FluentValidation;
using Web.Response.ResponseBasket;

namespace Web.Validation.ValidationBasket
{
    public class UpdateBasketCommandValidator : AbstractValidator<UpdateBasketById>
    {
        public UpdateBasketCommandValidator()
        {   
            RuleFor( x => x.id).NotEmpty();
            RuleFor(x => x.item).NotEmpty();
        }
    }
}