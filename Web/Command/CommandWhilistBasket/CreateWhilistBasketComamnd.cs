using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;
using Application.Adapters.Repositories;
using Application.Entities.Catalogs;
using AutoMapper;
using MediatR;
using Web.Dto;
using Web.Response.ResponseWhilistBasket;

namespace Web.Command.CommandWhilistBasket
{
    public class CreateWhilistBasketCommand : IRequestHandler<CreateWhilistBasket, IEnumerable<WhilistBasketDto>>
    {
        private readonly IAsyncWhilistBasketRepository repository;
        private readonly IMapper mapper;

        public CreateWhilistBasketCommand(IAsyncWhilistBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistBasketDto>> Handle(CreateWhilistBasket request, CancellationToken cancellationToken)
        {
             var command = await repository.Create(request.catalog);
             return mapper.Map<IEnumerable<WhilistBasketDto>>(command);
        }
    }
}