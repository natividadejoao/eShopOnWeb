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
/*     public class GetWhilistBasketByIdHandler : IRequestHandler<GetWhilistBasketById,IEnumerable<WhilistBasketDto>>
    {
        private readonly IAsyncWhilistBasketRepository reposiotry;
        private readonly IMapper mapper;

        public GetWhilistBasketByIdHandler(IAsyncWhilistBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistBasketDto>> Handle(GetWhilistBasketById request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.ReadAll(x => x.id == request.id);
            return mapper.Map<IEnumerable<WhilistBasketDto>>(query);
        }
    } */
}