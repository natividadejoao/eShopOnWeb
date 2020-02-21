using System.Collections.Generic;
using Web.Dto;
using MediatR;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;
using Application.Adapters.Repositories;
using Web.Query.RequestsProBasket;

namespace Web.Handler.HandlersProBasket
{
    public class OrderBySomethingHandler :  IRequestHandler<OrderBySomething, IEnumerable<ProBasketDto>>
    {
         private readonly IAsyncProBasketRepository reposiotry;
        private readonly IMapper mapper;

        public OrderBySomethingHandler(IAsyncProBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProBasketDto>> Handle(OrderBySomething request, CancellationToken cancellationToken)
        {
            var query = await Task.Run(() => reposiotry.OrderByCriterio(request.items,request.criterio));
            return mapper.Map<IEnumerable<ProBasketDto>>(query);
            
        }
    }
}