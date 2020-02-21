using FluentValidation;
using Web.Response.ResponseBasket;

namespace Web.Validation.ValidationBasket
{
    public class DeleteBasketValidator : AbstractValidator<DeleteBasketById>
    {
        public DeleteBasketValidator()
        {  
            RuleFor(x => x.id).NotEmpty();
            RuleFor(x => x.catalog).NotEmpty();
        }
    }
}