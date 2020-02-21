using FluentValidation;
using Web.Response.ResponseWhilistCatalog;

namespace Web.Validation.ValidationWhilistBasket
{
    public class UpdateWhilistCatalogValidation : AbstractValidator<UpdateWhilistCatalogById>
    {
        public UpdateWhilistCatalogValidation()
        {  
            RuleFor(x => x.item).NotNull();
            RuleFor(x => x.id).NotNull();
        }
    }
}