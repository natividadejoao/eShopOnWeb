using MediatR;
using Web.Dto;
using Application.Adapters;
using AutoMapper;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseProBasket;

namespace Web.Command.CommandProBasket
{
    public class CreateManyProBasketCommand : IRequestHandler<CreateManyProBasket,IEnumerable<ProBasketDto>>
    {
        private readonly IAsyncProBasketRepository repository;
        private readonly IMapper mapper;

        public CreateManyProBasketCommand(IAsyncProBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<ProBasketDto>> Handle(CreateManyProBasket request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}