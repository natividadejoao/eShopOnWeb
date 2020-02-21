using FluentValidation;
using Web.Response.ResponseWhilistCatalog;

namespace Web.Validation.ValidationWhilistBasket
{
    public class CreateManyWhilistCatalogValidation : AbstractValidator<CreateManyWhilistCatalog>

    {
        public CreateManyWhilistCatalogValidation()
        {  
            RuleForEach(x => x.items).NotNull();
        }
    }
}