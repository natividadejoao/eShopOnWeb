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
    public class GetProBasketByIdHandler : IRequestHandler<GetProBasketById,IEnumerable<ProBasketDto>>
    {
        private readonly IAsyncProBasketRepository reposiotry;
        private readonly IMapper mapper;

        public GetProBasketByIdHandler(IAsyncProBasketRepository reposiotry, IMapper mapper)
        {
            this.reposiotry = reposiotry;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProBasketDto>> Handle(GetProBasketById request, CancellationToken cancellationToken)
        {
            var query = await reposiotry.ReadAll(x => x.id == request.id);
            return mapper.Map<IEnumerable<ProBasketDto>>(query);
        }
    }
}