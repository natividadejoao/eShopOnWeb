using MediatR;
using Web.Dto;
using AutoMapper;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseBasket;

namespace Web.Command.CommandBasket
{
    public class CreateManyBasketCommand : IRequestHandler<CreateManyBasket,IEnumerable<BasketDto>>
    {
        private readonly IAsyncBasketRepository repository;
        private readonly IMapper mapper;

        public CreateManyBasketCommand(IAsyncBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<BasketDto>> Handle(CreateManyBasket request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}