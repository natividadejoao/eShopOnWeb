using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.Extensions.Logging;

using System.Threading.Tasks;
using System.Threading;
using Application.Adapters;
using Application.Entities.Catalogs;
using Web.Query.RequestsCatalogItem;
using System.Collections.Generic;
using Web.Response.ResponseCatalogItem;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers
{   
     [Authorize(Roles = "Administrator")]
    public class CatalogItemController: Controller
    {   
        private readonly IAsyncCatalogItemReposiotry reposiotry;
        private readonly ILogger<CatalogItemController> logger;
        private readonly IMediator mediator;

        public CatalogItemController(ILogger<CatalogItemController> logger, IMediator mediator, IAsyncCatalogItemReposiotry reposiotry)
        {   this.reposiotry = reposiotry;
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet()]
        [Route("catalogItem")]
         [Authorize(Roles = "UserManager")]
        public async Task<IActionResult> GetItems(string username){
            var query = new GetCatalogItems(username);
            var result = await mediator.Send(query);
            return View(result);

        }

        [HttpGet()]
        [Route("catalogItems/{id}")]
         [Authorize(Roles = "UserManager")]
        public async Task<IActionResult> GetItemsById(string username,uint id){
            var query = new GetCatalogItemById(username,id);
            var result = await mediator.Send(query);
           return View(result);
      
        }

        
        [HttpDelete()]
        
        public async Task<IActionResult> DeleteById(CatalogItem catalog,uint id,CancellationToken cancellation){
            try{
                var command = new DeleteCatalogItemById(catalog,id);
                var result = await mediator.Send(command);
                logger.LogInformation("Item delete");
            }
            catch(TaskCanceledException){
                logger.LogInformation("Item not delete");
            }
            return NoContent();
      
        }

        [HttpPost()]
        [Route("catalogItems")]
        public async Task<IActionResult> Create(CatalogItem catalog,CancellationToken cancellation){

                var command = new CreateCatalogItem(catalog);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }

        [HttpPost()]
        [Route("catalogItems")]
        public async Task<IActionResult> CreateMany(IEnumerable<CatalogItem> catalog,CancellationToken cancellation){

                var command = new CreateManyCatalogItem(catalog);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }         

        [HttpGet()]
        [Route("catalogItems")]
        public async Task<IActionResult> OrderBySomething(CatalogItem catalog,object criterio,CancellationToken cancellation){
            var query = new OrderBySomething(catalog,criterio);
            var result =await mediator.Send(query);
            return View(result);
      
        }

        [HttpGet()]
        [Route("catalogItems")]
        public async Task<IActionResult> Count(CatalogItem catalog,CancellationToken cancellation){
            
                var command = new CountCatalogItem(catalog);
                var result = await mediator.Send(command);
                return View(result);
            
        }

        [HttpPut()]
        [Route("catalogItems/{id}")]
        public async Task<IActionResult> UpdateById(CatalogItem catalog,uint id,CancellationToken cancellation){
            
            try{
                var command = new UpdateCatalogById(id,catalog);
                var result = await mediator.Send(command);
                logger.LogInformation("Item update");
            }
            catch(TaskCanceledException){
                logger.LogInformation("Item not update");
            }
            return NoContent();
        }

    }
}