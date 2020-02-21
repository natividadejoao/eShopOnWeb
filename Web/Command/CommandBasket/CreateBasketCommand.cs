using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters.Repositories;
using AutoMapper;
using MediatR;
using Web.Dto;
using Web.Response.ResponseBasket;

namespace Web.Command.CommandBasket
{
    public class CreateBasketCommand : IRequestHandler<CreateBasket, IEnumerable<BasketDto>>
    {
        private readonly IAsyncBasketRepository repository;
        private readonly IMapper mapper;

        public CreateBasketCommand(IAsyncBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<BasketDto>> Handle(CreateBasket request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}