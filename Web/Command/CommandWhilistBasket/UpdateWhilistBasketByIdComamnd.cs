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
    public class UpdateWhilistBasketByIdCommand : IRequestHandler<UpdateWhilistBasketById, IEnumerable<WhilistBasketDto>>
    {   
        private readonly IAsyncWhilistBasketRepository repository;
        private readonly IMapper mapper;

        public UpdateWhilistBasketByIdCommand(IAsyncWhilistBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<WhilistBasketDto>> Handle(UpdateWhilistBasketById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}