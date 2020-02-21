using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Web.Dto;
using Application.Adapters;
using AutoMapper;
using Web.Query.RequestsCatalogItem;

namespace Web.Handler.HandlersCatalogItem
{
    public class GetCatalogItemHandler : IRequestHandler<GetCatalogItems, IEnumerable<CatalogItemDto>>
    {   
        private readonly IAsyncCatalogItemReposiotry repo;
        private readonly IMapper mapper;

        public GetCatalogItemHandler(IAsyncCatalogItemReposiotry repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CatalogItemDto>> Handle(GetCatalogItems request, CancellationToken cancellationToken)
        {
            var query = await repo.ReadAll();
            return mapper.Map<IEnumerable<CatalogItemDto>>(query);
        }
    }
}