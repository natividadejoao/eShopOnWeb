using FluentValidation;
using Web.Response.ResponseProBasket;

namespace Web.Validation.ValidationProBasket
{
    public class DeleteProBasketValidator : AbstractValidator<DeleteProBasketById>
    {
        public DeleteProBasketValidator()
        {  
            RuleFor(x => x.id).NotEmpty();
            RuleFor(x => x.catalog).NotEmpty();
        }
    }
}