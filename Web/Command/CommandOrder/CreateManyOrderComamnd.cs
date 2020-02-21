using MediatR;
using Web.Dto;
using Application.Adapters;
using AutoMapper;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Threading;

using Application.Adapters.Repositories;
using Web.Response.ResponseOrder;

namespace Web.Command.CommandOrder
{
    public class CreateManyOrderCommand: IRequestHandler<CreateManyOrder,IEnumerable<OrderDto>>
    {
        private readonly IAsyncOrderRepository repository;
        private readonly IMapper mapper;

        public CreateManyOrderCommand(IAsyncOrderRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> Handle(CreateManyOrder request, CancellationToken cancellationToken)
        {
            var command = await repository.CreateMany(request.items);
            return mapper.Map<IEnumerable<OrderDto>>(command);
        }
    }
}