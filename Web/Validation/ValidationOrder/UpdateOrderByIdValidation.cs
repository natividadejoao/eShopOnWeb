using FluentValidation;
using Web.Response.ResponseOrder;

namespace Web.Validation.ValidationOrder
{
    public class UpdateOrderByIdValidation : AbstractValidator<UpdateOrderById>
    {
        public UpdateOrderByIdValidation()
        {  
            RuleFor(x => x.id).NotEmpty();
            RuleFor(x => x.item).NotEmpty().NotNull();
        }
    }
}