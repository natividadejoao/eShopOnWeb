using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;
using Application.Adapters.Repositories;
using Application.Entities.Catalogs;
using AutoMapper;
using MediatR;
using Web.Dto;

using Web.Response.ResponseWhilistCatalog;

namespace Web.Command.CommandWhilistCatalog
{
    public class CreateWhilistCatalogCommand : IRequestHandler<CreateWhilistCatalog, IEnumerable<WhilistCatalogDto>>
    {
        private readonly IAsyncWhilistCatalogRepository repository;
        private readonly IMapper mapper;

        public CreateWhilistCatalogCommand(IAsyncWhilistCatalogRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistCatalogDto>> Handle(CreateWhilistCatalog request, CancellationToken cancellationToken)
        {
             var command = await repository.Create(request.catalog);
             return mapper.Map<IEnumerable<WhilistCatalogDto>>(command);
        }
    }
}