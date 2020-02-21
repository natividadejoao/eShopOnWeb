using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Web.Dto;
using AutoMapper;
using Application.Adapters.Repositories;
using Web.Query.RequestsOrder;

namespace Web.Handler.HandlersOrder
{
    public class GetOrderHandler : IRequestHandler<GetOrders, IEnumerable<OrderDto>>
    {   
        private readonly IAsyncOrderRepository repo;
        private readonly IMapper mapper;

        public GetOrderHandler(IAsyncOrderRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> Handle(GetOrders request, CancellationToken cancellationToken)
        {
            var query = await repo.ReadAll();
            return mapper.Map<IEnumerable<OrderDto>>(query);
        }
    }
}