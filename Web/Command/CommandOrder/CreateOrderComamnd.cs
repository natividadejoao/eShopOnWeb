using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;
using Application.Adapters.Repositories;
using AutoMapper;
using MediatR;
using Web.Dto;
using Web.Response.ResponseOrder;

namespace Web.Command.CommandOrder
{
    public class CreateOrderCommand : IRequestHandler<CreateOrder, IEnumerable<OrderDto>>
    {
        private readonly IAsyncOrderRepository repository;
        private readonly IMapper mapper;

        public CreateOrderCommand(IAsyncOrderRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> Handle(CreateOrder request, CancellationToken cancellationToken)
        {
             var command = await repository.Create(request.catalog);
             return mapper.Map<IEnumerable<OrderDto>>(command);
        }
    }
}