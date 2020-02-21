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
    public class GetCatalogItemByIdHandler : IRequestHandler<GetCatalogItemById,IEnumerable<CatalogItemDto>>
    {
        private readonly IAsyncCatalogItemReposiotry reposiotry;
        private readonly IMapper mapper;

        public GetCatalogItemByIdHandler(IAsyncCatalogItemReposiotry reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CatalogItemDto>> Handle(GetCatalogItemById request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.ReadAll(x => x.id == request.id);
            return mapper.Map<IEnumerable<CatalogItemDto>>(query);
        }
    }
}