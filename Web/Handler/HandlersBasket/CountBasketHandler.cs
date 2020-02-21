using MediatR;
using Web.Dto;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsBasket;

namespace Web.Handler.HandlersBasket
{
    public class CountBasketHandler : IRequestHandler<CountBasket, IEnumerable<BasketDto>>
    {   
        private readonly IAsyncBasketRepository reposiotry;
        private readonly IMapper mapper;

        public CountBasketHandler(IAsyncBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public Task<IEnumerable<BasketDto>> Handle(CountBasket request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}