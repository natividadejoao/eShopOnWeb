using FluentValidation;
using Web.Response.ResponseWhilistBasket;

namespace Web.Validation.ValidationWhilistBasket
{
    public class UpdateWhilistBasketValidation : AbstractValidator<UpdateWhilistBasketById>
    {
        public UpdateWhilistBasketValidation()
        {   RuleFor(x => x.item).NotNull();
            RuleFor(x => x.id).NotNull();
        }
    }
}