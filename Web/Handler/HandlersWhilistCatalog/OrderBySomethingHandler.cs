using System.Collections.Generic;
using Web.Dto;
using MediatR;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistCatalog;

namespace Web.Handler.HandlersWhilistCatalog
{
/*     public class OrderBySomethingHandler :  IRequestHandler<OrderBySomething, IEnumerable<WhilistCatalogDto>>
    {
         private readonly IAsyncWhilistCatalogRepository reposiotry;
        private readonly IMapper mapper;

        public OrderBySomethingHandler(IAsyncWhilistCatalogRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistCatalogDto>> Handle(OrderBySomething request, CancellationToken cancellationToken)
        {
            var query = await Task.Run(() => reposiotry.OrderByCriterio(request.items,request.criterio));
            return mapper.Map<IEnumerable<WhilistCatalogDto>>(query);
            
        }
    } */
}