using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Entities.Whilists;
using Microsoft.Extensions.Logging;
using MediatR;
using Application.Adapters.Repositories;
using Web.Query.RequestsWhilistCatalog;
using Web.Response.ResponseWhilistCatalog;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers
{    [Authorize(Roles = "UserManager")]
    public class WhilistCatalogController : Controller
    {   
         private readonly IAsyncWhilistCatalogRepository reposiotry;
        private readonly ILogger<WhilistCatalogController> logger;
        private readonly IMediator mediator;

        public WhilistCatalogController(IAsyncWhilistCatalogRepository reposiotry, ILogger<WhilistCatalogController> logger, IMediator mediator)
        {
            this.reposiotry = reposiotry;
            this.logger = logger;
            this.mediator = mediator;
        }

         [Authorize(Roles = "Administrator")]
          [HttpGet()]
        [Route("whilistCatalog")]
        public async Task<IActionResult> Count(WhilistCatalog catalog, CancellationToken cancellation)
        {
             var command = new CountWhilistCatalog(catalog);
                var result = await mediator.Send(command);
                return View(result);
        }

         [HttpPost()]
        public async Task<IActionResult> Create([FromBody] CreateWhilistCatalog command)
          {       
                var result = await mediator.Send(command);
                return CreatedAtAction("CreateWhilistBasket", new {x =result.SelectMany(x => x.items).ToList(),result});
        }
              

        [HttpPost()]
        
        public async Task<IActionResult> CreateMany([FromBody] CreateManyWhilistCatalog command)
         {
            
                var result = await mediator.Send(command);
                return CreatedAtAction("CreateManyWhilistBasket",new {x = result.SelectMany(x => x.items).ToList(),result});
        }

          [HttpDelete()]
        
        public async Task<IActionResult> DeleteById([FromBody] DeleteWhilistCatalogById command)
       {
            
                var result = await mediator.Send(command);
                return CreatedAtAction("DeleteWhilistById", new { x = result.Select(x =>  x.id).ToList(),result});
          
        }
        
         [Authorize(Roles = "Administrator")]
         [HttpGet()]
          [Route("whilistCatalog")]
        public async Task<IActionResult> GetItems(string username)
        {
            var query = new GetWhilistCatalog(username);
            var result = await mediator.Send(query);
           return View(result);
        }

         [Authorize(Roles = "Administrator")]
        [HttpGet()]
        [Route("whilistCatalog/{id}")]
        public async Task<IActionResult> GetItemsById(string username, uint id)
        {
              var query = new GetWhilistCatalogById(username,id);
            var result = await mediator.Send(query);
           return View(result);
        }

          [HttpGet()]
        [Route("whilistCatalogOrder/criterio")]
        public async Task<IActionResult> OrderBySomething(WhilistCatalog catalog, object criterio, CancellationToken cancellation)
        {
              var query = new OrderBySomething(catalog,criterio);
            var result =await mediator.Send(query);
            return View(result);
        }

        [HttpPut()]
       
        public async Task<IActionResult> UpdateById([FromBody] UpdateWhilistCatalogById command)
       {
            
                
                var result = await mediator.Send(command);
                return CreatedAtAction("UpdateById", new { x =result.Select(x => x.id).ToList(),result});
       
        }
    }
}