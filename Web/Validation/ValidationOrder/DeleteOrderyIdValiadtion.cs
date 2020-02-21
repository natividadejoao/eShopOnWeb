using FluentValidation;
using Web.Response.ResponseOrder;

namespace Web.Validation.ValidationOrder
{
    public class DeleteOrderyIdValiadtion : AbstractValidator<DeleteOrderById>
    {
        public DeleteOrderyIdValiadtion()
        {  RuleFor(x => x.catalog).NotNull().NotEmpty();
           RuleFor(x => x.id).NotEmpty();
        }
    }
}