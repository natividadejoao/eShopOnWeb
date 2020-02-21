using MediatR;
using Web.Dto;
using Application.Adapters;
using AutoMapper;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Threading;

using Web.Response.ResponseCatalogItem;

namespace Web.Command.CommandCatalogItem
{
    public class CreateManyCatalogItemCommand : IRequestHandler<CreateManyCatalogItem,IEnumerable<CatalogItemDto>>
    {
        private readonly IAsyncCatalogItemReposiotry repository;
        private readonly IMapper mapper;

        public CreateManyCatalogItemCommand(IAsyncCatalogItemReposiotry repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CatalogItemDto>> Handle(CreateManyCatalogItem request, CancellationToken cancellationToken)
        {
            var command = await repository.CreateMany(request.items);
            return mapper.Map<IEnumerable<CatalogItemDto>>(command);
        }
    }
}