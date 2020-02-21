using System.Collections.Generic;
using Web.Dto;
using MediatR;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsOrder;

namespace Web.Handler.HandlersOrder
{
    public class OrderBySomethingHandler :  IRequestHandler<OrderBySomething, IEnumerable<OrderDto>>
    {
         private readonly IAsyncOrderRepository reposiotry;
        private readonly IMapper mapper;

        public OrderBySomethingHandler(IAsyncOrderRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> Handle(OrderBySomething request, CancellationToken cancellationToken)
        {
            var query = await Task.Run(() => reposiotry.OrderByCriterio(request.items,request.criterio));
            return mapper.Map<IEnumerable<OrderDto>>(query);
            
        }
    }
}