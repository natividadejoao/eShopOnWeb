using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Web.Dto;
using Application.Adapters;
using MediatR;

using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseOrder;

namespace Web.Command.CommandOrder
{
    public class DeleteOrderByIdCommand : IRequestHandler<DeleteOrderById,IEnumerable<OrderDto>>
    {
        private readonly IAsyncOrderRepository repository;
        private readonly IMapper mapper;

        public DeleteOrderByIdCommand(IAsyncOrderRepository repository, IMapper mappper)
        {
            this.repository = repository;
            this.mapper = mappper;
        }

        public Task<IEnumerable<OrderDto>> Handle(DeleteOrderById request, CancellationToken cancellationToken)
        {
           
            return Task.Run(() => mapper.Map<IEnumerable<OrderDto>>( repository.DeleteById(request.catalog,request.id)));
          
          
        }
    }
}