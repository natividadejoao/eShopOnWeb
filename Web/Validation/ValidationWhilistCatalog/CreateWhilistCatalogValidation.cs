using FluentValidation;
using Web.Response.ResponseWhilistCatalog;

namespace Web.Validation.ValidationWhilistBasket
{
      public class CreateWhilistCatalogValidation : AbstractValidator<CreateWhilistCatalog>

    {
        public CreateWhilistCatalogValidation()
        {  
            RuleFor(x => x.catalog).NotNull();
        }
    }
}