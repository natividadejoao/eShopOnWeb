using System.Collections.Generic;
using Web.Dto;
using MediatR;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsBasket;

namespace Web.Handler.HandlersBasket
{
    public class OrderBySomethingHandler :  IRequestHandler<OrderBySomething, IEnumerable<BasketDto>>
    {
         private readonly IAsyncBasketRepository reposiotry;
        private readonly IMapper mapper;

        public OrderBySomethingHandler(IAsyncBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public Task<IEnumerable<BasketDto>> Handle(OrderBySomething request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}