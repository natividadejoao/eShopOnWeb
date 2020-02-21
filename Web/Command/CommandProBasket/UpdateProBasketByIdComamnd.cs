using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;
using Application.Adapters.Repositories;
using Application.Entities.Catalogs;
using AutoMapper;
using MediatR;
using Web.Dto;
using Web.Response.ResponseProBasket;

namespace Web.Command.CommandProBasket
{
    public class UpdateProBasketByIdCommand : IRequestHandler<UpdateProBasketById, IEnumerable<ProBasketDto>>
    {   
        private readonly IAsyncProBasketRepository repository;
        private readonly IMapper mapper;

        public UpdateProBasketByIdCommand(IAsyncProBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<ProBasketDto>> Handle(UpdateProBasketById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}