using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;
using Application.Adapters.Repositories;
using AutoMapper;
using MediatR;
using Web.Dto;
using Web.Response.ResponseBasket;

namespace Web.Command.CommandBasket
{
    public class UpdateBasketByIdCommand : IRequestHandler<UpdateBasketById, IEnumerable<BasketDto>>
    {   
        private readonly IAsyncBasketRepository repository;
        private readonly IMapper mapper;

        public UpdateBasketByIdCommand(IAsyncBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<BasketDto>> Handle(UpdateBasketById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}