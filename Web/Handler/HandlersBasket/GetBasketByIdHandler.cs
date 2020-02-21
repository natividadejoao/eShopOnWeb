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
    public class GetBasketByIdHandler : IRequestHandler<GetBasketById,IEnumerable<BasketDto>>
    {
        private readonly IAsyncBasketRepository reposiotry;
        private readonly IMapper mapper;

        public GetBasketByIdHandler(IAsyncBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<BasketDto>> Handle(GetBasketById request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.ReadAll(x => x.id == request.id);
            return mapper.Map<IEnumerable<BasketDto>>(query);
        }
    }
}