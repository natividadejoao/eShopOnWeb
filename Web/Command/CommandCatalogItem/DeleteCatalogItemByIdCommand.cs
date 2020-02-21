using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Web.Dto;
using Application.Adapters;
using Application.Entities.Catalogs;
using MediatR;

using System.Threading;
using Web.Response.ResponseCatalogItem;

namespace Web.Command.CommandCatalogItem
{
    public class DeleteCatalogItemByIdCommand : IRequestHandler<DeleteCatalogItemById,IEnumerable<CatalogItemDto>>
    {
        private readonly IAsyncCatalogItemReposiotry repository;
        private readonly IMapper mapper;

        public DeleteCatalogItemByIdCommand(IAsyncCatalogItemReposiotry repository, IMapper mappper)
        {
            this.repository = repository;
            this.mapper = mappper;
        }

        public Task<IEnumerable<CatalogItemDto>> Handle(DeleteCatalogItemById request, CancellationToken cancellationToken)
        {
           
            return Task.Run(() => mapper.Map<IEnumerable<CatalogItemDto>>( repository.DeleteById(request.catalog,request.id)));
          
          
        }
    }
}