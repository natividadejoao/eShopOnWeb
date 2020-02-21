using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters.Repositories;
using AutoMapper;
using MediatR;
using Web.Dto;

using Web.Response.ResponseWhilistCatalog;

namespace Web.Command.CommandWhilistCatalog
{
    public class UpdateWhilistCatalogByIdCommand : IRequestHandler<UpdateWhilistCatalogById, IEnumerable<WhilistCatalogDto>>
    {   
        private readonly IAsyncWhilistCatalogRepository repository;
        private readonly IMapper mapper;

        public UpdateWhilistCatalogByIdCommand(IAsyncWhilistCatalogRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<WhilistCatalogDto>> Handle(UpdateWhilistCatalogById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}