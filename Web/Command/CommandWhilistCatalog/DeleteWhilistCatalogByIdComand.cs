using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Web.Dto;
using Application.Adapters;
using Application.Entities.Catalogs;
using MediatR;

using System.Threading;

using Application.Adapters.Repositories;
using Web.Response.ResponseWhilistCatalog;

namespace Web.Command.CommandWhilistCatalog
{
    public class DeleteWhilistCatalogByIdCommand : IRequestHandler<DeleteWhilistCatalogById,IEnumerable<WhilistCatalogDto>>
    {
        private readonly IAsyncWhilistCatalogRepository repository;
        private readonly IMapper mapper;

        public DeleteWhilistCatalogByIdCommand(IAsyncWhilistCatalogRepository repository, IMapper mappper)
        {
            this.repository = repository;
            this.mapper = mappper;
        }

        public Task<IEnumerable<WhilistCatalogDto>> Handle(DeleteWhilistCatalogById request, CancellationToken cancellationToken)
        {
           
            return Task.Run(() => mapper.Map<IEnumerable<WhilistCatalogDto>>( repository.DeleteById(request.catalog,request.id)));
          
          
        }
    }
}