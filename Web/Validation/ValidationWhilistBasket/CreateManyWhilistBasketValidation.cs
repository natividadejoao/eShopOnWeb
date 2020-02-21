using FluentValidation;
using Web.Response.ResponseWhilistBasket;

namespace Web.Validation.ValidationWhilistBasket
{
    public class CreateManyWhilistBasketValidation : AbstractValidator<CreateManyWhilistBasket>

    {
        public CreateManyWhilistBasketValidation()
        {   RuleForEach(x => x.items).NotNull();
        }
    }
}