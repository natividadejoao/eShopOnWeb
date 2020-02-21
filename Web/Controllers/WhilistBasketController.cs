using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Entities.Whilists;
using Application.Adapters.Repositories;
using Microsoft.Extensions.Logging;
using MediatR;
using Web.Response.ResponseWhilistBasket;
using Web.Query.RequestsWhilistBasket;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers
{     [Authorize(Roles = "UserManager")]
    public class WhilistBasketController : Controller{
        private readonly IAsyncWhilistBasketRepository reposiotry;
        private readonly ILogger<WhilistBasketController> logger;
        private readonly IMediator mediator;

        public WhilistBasketController(IAsyncWhilistBasketRepository reposiotry, ILogger<WhilistBasketController> logger, IMediator mediator)
        {
            this.reposiotry = reposiotry;
            this.logger = logger;
            this.mediator = mediator;
        }

         [Authorize(Roles = "Administrator")]
        [HttpGet()]
        [Route("whilistBasket")]
        public async Task<IActionResult> Count(WhilistBasket catalog, CancellationToken cancellation)
        {
             var command = new CountWhilistBasket(catalog);
                var result = await mediator.Send(command);
                return View(result);
        }

        [HttpPost()] 
        public async Task<IActionResult> Create([FromBody] CreateWhilistBasket command)
        {       
                var result = await mediator.Send(command);
                return CreatedAtAction("CreateWhilistBasket", new {x =result.SelectMany(x => x.baskets).ToList(),result});
        }

        [HttpPost()]
        public async Task<IActionResult> CreateMany([FromBody] CreateManyWhilistBasket command)
        {
            
                var result = await mediator.Send(command);
                return CreatedAtAction("CreateManyWhilistBasket",new {x = result.SelectMany(x => x.baskets).ToList(),result});
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteById([FromBody] DeleteWhilistBasketById command)
        {
            
                var result = await mediator.Send(command);
                return CreatedAtAction("DeleteWhilistById", new { x = result.Select(x =>  x.id).ToList(),result});
          
        }

         [Authorize(Roles = "Administrator")]
        [HttpGet()]
        [Route("whilistBasket")]
        public async Task<IActionResult> GetItems(string username)
        {
            var query = new GetWhilistBaskets(username);
            var result = await mediator.Send(query);
           return View(result);
        }

         [Authorize(Roles = "Administrator")]
        [HttpGet()]
        [Route("whilistBasket/id")]
        public async Task<IActionResult> GetItemsById(string username, uint id)
        {
              var query = new GetWhilistBasketById(username,id);
            var result = await mediator.Send(query);
           return View(result);
        }

        [HttpGet()]
        [Route("whilistBasketOrder/criterio")]
        public async Task<IActionResult> OrderBySomething(WhilistBasket catalog, object criterio, CancellationToken cancellation)
        {
              var query = new OrderBySomething(catalog,criterio);
            var result =await mediator.Send(query);
            return View(result);
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateById([FromBody] UpdateWhilistBasketById command)
        {
            
                
                var result = await mediator.Send(command);
                return CreatedAtAction("UpdateById", new { x =result.Select(x => x.id).ToList(),result});
       
        }
    }
}