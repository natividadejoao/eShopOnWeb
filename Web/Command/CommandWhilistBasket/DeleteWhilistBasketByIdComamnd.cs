using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Web.Dto;
using Application.Adapters;
using Application.Entities.Catalogs;
using MediatR;

using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseWhilistBasket;

namespace Web.Command.CommandWhilistBasket
{
    public class DeleteWhilistBasketByIdCommand : IRequestHandler<DeleteWhilistBasketById,IEnumerable<WhilistBasketDto>>
    {
        private readonly IAsyncWhilistBasketRepository repository;
        private readonly IMapper mapper;

        public DeleteWhilistBasketByIdCommand(IAsyncWhilistBasketRepository repository, IMapper mappper)
        {
            this.repository = repository;
            this.mapper = mappper;
        }

        public Task<IEnumerable<WhilistBasketDto>> Handle(DeleteWhilistBasketById request, CancellationToken cancellationToken)
        {
           
            return Task.Run(() => mapper.Map<IEnumerable<WhilistBasketDto>>( repository.DeleteById(request.catalog,request.id)));
          
          
        }
    }
}