using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Adapters;

using AutoMapper;
using MediatR;
using Web.Dto;

using Web.Response.ResponseCatalogItem;

namespace Web.Command.CommandCatalogItem
{
    public class UpdateCatalogItemByIdCommand : IRequestHandler<UpdateCatalogById, IEnumerable<CatalogItemDto>>
    {   
        private readonly IAsyncCatalogItemReposiotry repository;
        private readonly IMapper mapper;

        public UpdateCatalogItemByIdCommand(IAsyncCatalogItemReposiotry repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public  Task<IEnumerable<CatalogItemDto>> Handle(UpdateCatalogById request, CancellationToken cancellationToken)
        {
         
            return  Task.Run(() => mapper.Map<IEnumerable<CatalogItemDto>>(repository.UpdateById(request.item,request.id)));
            
        }
    }
}