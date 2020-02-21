using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Web.Dto;
using AutoMapper;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistCatalog;

namespace Web.Handler.HandlersWhilistCatalog
{
/*     public class GetWhilistCatalogHandler : IRequestHandler<GetWhilistCatalog, IEnumerable<WhilistCatalogDto>>
    {   
        private readonly IAsyncWhilistCatalogRepository repo;
        private readonly IMapper mapper;

        public GetWhilistCatalogHandler(IAsyncWhilistCatalogRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistCatalogDto>> Handle(GetWhilistCatalog request, CancellationToken cancellationToken)
        {
            var query = await repo.ReadAll();
            return mapper.Map<IEnumerable<WhilistCatalogDto>>(query);
        }
    } */
}