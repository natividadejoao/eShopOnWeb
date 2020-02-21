using MediatR;
using Web.Dto;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsOrder;

namespace Web.Handler.HandlersOrder
{
    public class CountOrderHandler : IRequestHandler<CountOrder, IEnumerable<OrderDto>>
    {   
        private readonly IAsyncOrderRepository reposiotry;
        private readonly IMapper mapper;

        public CountOrderHandler(IAsyncOrderRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> Handle(CountOrder request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.Count(request.catalog);
            return mapper.Map<IEnumerable<OrderDto>>(query);
        }
    }
}