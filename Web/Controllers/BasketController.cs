using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Entities.Baskets;
using Application.Adapters.Repositories;
using Microsoft.Extensions.Logging;
using MediatR;
using Web.Query.RequestsBasket;
using System.Collections.Generic;
using Web.Response.ResponseBasket;
using System.Linq;

namespace Web.Controllers
{   
    public class BasketController : Controller
    {   
        private readonly IAsyncBasketRepository reposiotry;
        private readonly ILogger<BasketController> logger;
        private readonly IMediator mediator;

        public BasketController(IAsyncBasketRepository reposiotry, ILogger<BasketController> logger, IMediator mediator)
        {
            this.reposiotry = reposiotry;
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet()]
        [Route("basket/count")]
        public async Task<IActionResult> Count(Basket catalog, CancellationToken cancellation)
        {
                var command = new CountBasket(catalog);
                var result = await mediator.Send(command);
                return View(result);
            
        }


        [HttpPost()]
        public async Task<IActionResult> Create(Basket catalog, CancellationToken cancellation)
        {
              var command = new CreateBasket(catalog);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }

        [HttpPost()]
        public async Task<IActionResult> CreateMany(IEnumerable<Basket> catalog, CancellationToken cancellation)
        {
            var command = new CreateManyBasket(catalog);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteById([FromBody] DeleteBasketById command)
        {
             var result = await mediator.Send(command);
            return CreatedAtAction("Update",new {basketId = result.Select(x =>x.id)},result);
        }

        [HttpGet()]
        [Route("basket")]
        public async Task<IActionResult> GetItems(string username)
        {
              var query = new GetBasket(username);
            var result = await mediator.Send(query);
           return View(result);
        }

           [HttpGet()]
        [Route("baskets")]
        public async Task<IActionResult> GetItemsById(string username, uint id)
        {
              var query = new GetBasketById(username,id);
            var result = await mediator.Send(query);
           return View(result);
        }
        
        [HttpGet()]
        [Route("baskets/order/{something}")]
        public async Task<IActionResult> OrderBySomething(Basket catalog, object criterio, CancellationToken cancellation)
        {
            var query = new OrderBySomething(catalog,criterio);
            var result =await mediator.Send(query);
            return View(result);
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateById([FromBody] UpdateBasketById command)
        {
                var result = await mediator.Send(command);
            return CreatedAtAction("Update",new {basketId = result.Select(x =>x.id)},result);
        }
    }
}