using MediatR;
using Web.Dto;

using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsProBasket;

namespace Web.Handler.HandlersProBasket
{
    public class CountProBasketHandler : IRequestHandler<CountProBasket, IEnumerable<ProBasketDto>>
    {   
        private readonly IAsyncProBasketRepository reposiotry;
        private readonly IMapper mapper;

        public CountProBasketHandler(IAsyncProBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProBasketDto>> Handle(CountProBasket request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.Count(request.catalog);
            return mapper.Map<IEnumerable<ProBasketDto>>(query);
        }
    }
}