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
    public class GetOrderByIdHandler : IRequestHandler<GetOrderById,IEnumerable<OrderDto>>
    {
        private readonly IAsyncOrderRepository reposiotry;
        private readonly IMapper mapper;

        public GetOrderByIdHandler(IAsyncOrderRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> Handle(GetOrderById request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.ReadAll(x => x.id == request.id);
            return mapper.Map<IEnumerable<OrderDto>>(query);
        }
    }
}