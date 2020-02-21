using MediatR;
using Web.Dto;
using Application.Adapters;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Web.Query.RequestsCatalogItem;

namespace Web.Handler.HandlersCatalogItem
{
    public class CountCatalogItemHandler : IRequestHandler<CountCatalogItem, IEnumerable<CatalogItemDto>>
    {   
        private readonly IAsyncCatalogItemReposiotry reposiotry;
        private readonly IMapper mapper;

        public CountCatalogItemHandler(IAsyncCatalogItemReposiotry reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CatalogItemDto>> Handle(CountCatalogItem request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.Count(request.catalog);
            return mapper.Map<IEnumerable<CatalogItemDto>>(query);
        }
    }
}