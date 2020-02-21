using MediatR;
using Web.Dto;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistCatalog;

namespace Web.Handler.HandlersWhilistCatalog
{
/*     public class GetWhilistCatalogByIdHandler : IRequestHandler<GetWhilistCatalogById,IEnumerable<WhilistCatalogDto>>
    {
        private readonly IAsyncWhilistCatalogRepository reposiotry;
        private readonly IMapper mapper;

        public GetWhilistCatalogByIdHandler(IAsyncWhilistCatalogRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistCatalogDto>> Handle(GetWhilistCatalogById request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.ReadAll(x => x.id == request.id);
            return mapper.Map<IEnumerable<WhilistCatalogDto>>(query);
        }
    } */
}