using FluentValidation;
using Web.Response.ResponseWhilistBasket;

namespace Web.Validation.ValidationWhilistBasket
{
    public class DeleteWhilistBasketValidation : AbstractValidator<DeleteWhilistBasketById>
    {
        public DeleteWhilistBasketValidation()
        {   
            RuleFor(x => x.catalog).NotNull();
            RuleFor(x => x.id).NotNull();
        }
    }
}