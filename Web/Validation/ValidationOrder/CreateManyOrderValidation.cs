using FluentValidation;
using Web.Response.ResponseOrder;

namespace Web.Validation.ValidationOrder
{
    public class CreateManyOrderValidation : AbstractValidator<CreateManyOrder>

    {
        public CreateManyOrderValidation()
        {  
            RuleForEach(x => x.items).NotEmpty().NotNull();
        }
    }
}