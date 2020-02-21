using MediatR;
using Web.Dto;
using AutoMapper;
using System.Collections.Generic;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistCatalog;
using System.Threading.Tasks;

namespace Web.Handler.HandlersWhilistCatalog
{
  /*   public class CountWhilistCatalogHandler : IRequestHandler<CountWhilistCatalog, IEnumerable<WhilistCatalogDto>>
    {   
        private readonly IAsyncWhilistCatalogRepository reposiotry;
        private readonly IMapper mapper;

        public CountWhilistCatalogHandler(IAsyncWhilistCatalogRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public Task<IEnumerable<WhilistCatalogDto>> Handle(CountWhilistCatalog request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    } */
}