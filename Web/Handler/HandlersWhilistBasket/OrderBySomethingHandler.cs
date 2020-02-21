using System.Collections.Generic;
using Web.Dto;
using MediatR;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistBasket;

namespace Web.Handler.HandlersWhilistBasket
{
  /*   public class OrderBySomethingHandler :  IRequestHandler<OrderBySomething, IEnumerable<WhilistBasketDto>>
    {
         private readonly IAsyncWhilistBasketRepository reposiotry;
        private readonly IMapper mapper;

        public OrderBySomethingHandler(IAsyncWhilistBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistBasketDto>> Handle(OrderBySomething request, CancellationToken cancellationToken)
        {
            var query = await Task.Run(() => reposiotry.OrderByCriterio(request.items,request.criterio));
            return mapper.Map<IEnumerable<WhilistBasketDto>>(query);
            
        }
    } */
}