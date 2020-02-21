using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Web.Dto;
using AutoMapper;
using Application.Adapters.Repositories;
using Web.Query.RequestsProBasket;

namespace Web.Handler.HandlersProBasket
{
    public class GetProBasketHandler : IRequestHandler<GetProBasket, IEnumerable<ProBasketDto>>
    {   
        private readonly IAsyncProBasketRepository repo;
        private readonly IMapper mapper;

        public GetProBasketHandler(IAsyncProBasketRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProBasketDto>> Handle(GetProBasket request, CancellationToken cancellationToken)
        {
            var query = await repo.ReadAll();
            return mapper.Map<IEnumerable<ProBasketDto>>(query);
        }
    }
}