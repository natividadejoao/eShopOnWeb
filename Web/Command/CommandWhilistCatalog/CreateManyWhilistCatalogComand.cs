using MediatR;
using Web.Dto;
using Application.Adapters;
using AutoMapper;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseWhilistCatalog;

namespace Web.Command.CommandWhilistCatalog
{
    public class CreateManyWhilistCatalogCommand : IRequestHandler<CreateManyWhilistCatalog,IEnumerable<WhilistCatalogDto>>
    {
        private readonly IAsyncWhilistCatalogRepository repository;
        private readonly IMapper mapper;

        public CreateManyWhilistCatalogCommand(IAsyncWhilistCatalogRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistCatalogDto>> Handle(CreateManyWhilistCatalog request, CancellationToken cancellationToken)
        {
            var command = await repository.CreateMany(request.items);
            return mapper.Map<IEnumerable<WhilistCatalogDto>>(command);
        }
    }
}