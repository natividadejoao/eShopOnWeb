using FluentValidation;
using Web.Response.ResponseOrder;

namespace Web.Validation.ValidationOrder
{
    public class CreateOrderValidation : AbstractValidator<CreateOrder>
    {
        public CreateOrderValidation()
        {  
            RuleFor(x => x.catalog).NotEmpty().NotNull();
        }
    }
}