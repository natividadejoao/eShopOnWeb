using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;
using Application.Adapters.Repositories;
using Application.Entities.Catalogs;
using AutoMapper;
using MediatR;
using Web.Dto;
using Web.Response.ResponseOrder;

namespace Web.Command.CommandOrder
{
    public class UpdateOrderByIdCommand : IRequestHandler<UpdateOrderById, IEnumerable<OrderDto>>
    {   
        private readonly IAsyncOrderRepository repository;
        private readonly IMapper mapper;

        public UpdateOrderByIdCommand(IAsyncOrderRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<OrderDto>> Handle(UpdateOrderById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}