using FluentValidation;
using Web.Response.ResponseWhilistBasket;

namespace Web.Validation.ValidationWhilistBasket
{
    public class CreateWhilistBasketValidation : AbstractValidator<CreateWhilistBasket>

    {
        public CreateWhilistBasketValidation()
        {  
            RuleFor(x => x.catalog).NotNull();
            
        }
    }
}