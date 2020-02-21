using MediatR;
using Web.Dto;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistBasket;

namespace Web.Handler.HandlersWhilistBasket
{
  /*   public class CountWhilistBasketHandler : IRequestHandler<CountWhilistBasket, IEnumerable<WhilistBasketDto>>
    {   
        private readonly IAsyncWhilistBasketRepository reposiotry;
        private readonly IMapper mapper;

        public CountWhilistBasketHandler(IAsyncWhilistBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistBasketDto>> Handle(CountWhilistBasket request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.Count(request.catalog);
            return mapper.Map<IEnumerable<WhilistBasketDto>>(query);
        }
    } */
}