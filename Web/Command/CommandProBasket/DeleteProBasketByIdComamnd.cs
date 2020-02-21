using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Web.Dto;
using MediatR;

using System.Threading;
using Application.Adapters.Repositories;
using Web.Response.ResponseProBasket;

namespace Web.Command.CommandProBasket
{
    public class DeleteProBasketByIdCommand : IRequestHandler<DeleteProBasketById,IEnumerable<ProBasketDto>>
    {
        private readonly IAsyncProBasketRepository repository;
        private readonly IMapper mapper;

        public DeleteProBasketByIdCommand(IAsyncProBasketRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<ProBasketDto>> Handle(DeleteProBasketById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}