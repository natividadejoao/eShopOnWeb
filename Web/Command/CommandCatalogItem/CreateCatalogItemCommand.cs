using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;
using AutoMapper;
using MediatR;
using Web.Dto;
using Web.Response.ResponseCatalogItem;

namespace Web.Command.CommandCatalogItem
{
    public class CreateCatalogItemCommand : IRequestHandler<CreateCatalogItem, IEnumerable<CatalogItemDto>>
    {
        private readonly IAsyncCatalogItemReposiotry repository;
        private readonly IMapper mapper;

        public CreateCatalogItemCommand(IAsyncCatalogItemReposiotry repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CatalogItemDto>> Handle(CreateCatalogItem request, CancellationToken cancellationToken)
        {
             var command = await repository.Create(request.catalog);
             return mapper.Map<IEnumerable<CatalogItemDto>>(command);
        }
    }
}