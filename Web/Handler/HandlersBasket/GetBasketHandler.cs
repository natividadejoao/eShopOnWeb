using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Web.Dto;
using AutoMapper;
using Application.Adapters.Repositories;
using Web.Query.RequestsBasket;

namespace Web.Handler.HandlersBasket
{
    public class GetBasketHandler : IRequestHandler<GetBasket, IEnumerable<BasketDto>>
    {   
        private readonly IAsyncBasketRepository repo;
        private readonly IMapper mapper;

        public GetBasketHandler(IAsyncBasketRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public Task<IEnumerable<BasketDto>> Handle(GetBasket request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}