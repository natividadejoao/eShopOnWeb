using FluentValidation;
using Web.Response.ResponseWhilistCatalog;

namespace Web.Validation.ValidationWhilistBasket
{
    public class DeleteWhilistCatalogValidation : AbstractValidator<DeleteWhilistCatalogById>
    {
        public DeleteWhilistCatalogValidation()
        {  
            RuleFor(x => x.catalog).NotNull();
            RuleFor(x => x.id).NotNull();
        }
    }
}