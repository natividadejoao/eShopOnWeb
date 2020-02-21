using MediatR;
using Web.Dto;
using Application.Adapters;
using AutoMapper;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseWhilistBasket;

namespace Web.Command.CommandWhilistBasket
{
    public class CreateManyWhilistBasketCommand : IRequestHandler<CreateManyWhilistBasket,IEnumerable<WhilistBasketDto>>
    {
        private readonly IAsyncWhilistBasketRepository repository;
        private readonly IMapper mapper;

        public CreateManyWhilistBasketCommand(IAsyncWhilistBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistBasketDto>> Handle(CreateManyWhilistBasket request, CancellationToken cancellationToken)
        {
            var command = await repository.CreateMany(request.items);
            return mapper.Map<IEnumerable<WhilistBasketDto>>(command);
        }
    }
}