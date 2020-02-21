using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Web.Dto;
using MediatR;

using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseBasket;

namespace Web.Command.CommandBasket
{
    public class DeleteBasketByIdCommand : IRequestHandler<DeleteBasketById,IEnumerable<BasketDto>>
    {
        private readonly IAsyncBasketRepository repository;
        private readonly IMapper mapper;

        public DeleteBasketByIdCommand(IAsyncBasketRepository repository, IMapper mappper)
        {
            this.repository = repository;
            this.mapper = mappper;
        }

        public Task<IEnumerable<BasketDto>> Handle(DeleteBasketById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}