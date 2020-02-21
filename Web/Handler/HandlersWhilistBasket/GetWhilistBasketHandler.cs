using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Web.Dto;
using AutoMapper;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistBasket;

namespace Web.Handler.HandlersWhilistBasket
{
 /*    public class GetWhilistBasketHandler : IRequestHandler<GetWhilistBaskets, IEnumerable<WhilistBasketDto>>
    {   
        private readonly IAsyncWhilistBasketRepository repo;
        private readonly IMapper mapper;

        public GetWhilistBasketHandler(IAsyncWhilistBasketRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WhilistBasketDto>> Handle(GetWhilistBaskets request, CancellationToken cancellationToken)
        {
            var query = await repo.ReadAll();
            return mapper.Map<IEnumerable<WhilistBasketDto>>(query);
        }
    } */
}