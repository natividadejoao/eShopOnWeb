using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Adapters;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;
using Web.Query.RequestsCatalogItem;

namespace Web.Handler.HandlersCatalogItem
{
    public class OrderBySomethingHandler :  IRequestHandler<OrderBySomething, IEnumerable<CatalogItemDto>>
    {
         private readonly IAsyncCatalogItemReposiotry reposiotry;
        private readonly IMapper mapper;

        public OrderBySomethingHandler(IAsyncCatalogItemReposiotry reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CatalogItemDto>> Handle(OrderBySomething request, CancellationToken cancellationToken)
        {
            var query = await Task.Run(() => reposiotry.OrderByCriterio(request.items,request.criterio));
            return mapper.Map<IEnumerable<CatalogItemDto>>(query);
            
        }
    }
}