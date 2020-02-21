using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using Application.Adapters.Repositories;
using Application.Entities.Baskets;
using System.Collections.Generic;
using Web.Response.ResponseProBasket;
using System.Linq;
using Web.Query.RequestsProBasket;

namespace Web.Controllers
{
    public class ProBasketController : Controller
    {   
        private readonly IAsyncProBasketRepository reposiotry;
        private readonly ILogger<ProBasketController> logger;
        private readonly IMediator mediator;

        public ProBasketController(IAsyncProBasketRepository reposiotry, ILogger<ProBasketController> logger, IMediator mediator)
        {
            this.reposiotry = reposiotry;
            this.logger = logger;
            this.mediator = mediator;
        }

          [HttpGet()]
        [Route("probaskets")]
        public async Task<IActionResult> Count(ProBasket catalog, CancellationToken cancellation)
        {
             var command = new CreateProBasket(catalog);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }


        [HttpPost()]
        public async Task<IActionResult> Create(ProBasket catalog, CancellationToken cancellation)
        {
            var command = new CreateProBasket(catalog);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }

         [HttpPost()]
       
        public async Task<IActionResult> CreateMany(IEnumerable<ProBasket> catalog, CancellationToken cancellation)
        {
           var command = new CreateManyProBasket(catalog);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteById([FromBody] DeleteProBasketById command)
        {
            var result = await mediator.Send(command);
                return CreatedAtAction("Delete",new {proBasketId = result.Select(x =>x.id)},result);
        }

        [HttpGet()]
        [Route("probaskets")]
        public async Task<IActionResult> GetItems(string username)
        {
             var query = new GetProBasket(username);
            var result = await mediator.Send(query);
           return View(result);
        }

           [HttpGet()]
        [Route("probaskets")]
        public async Task<IActionResult> GetItemsById(string username, uint id)
        {
               var query = new GetProBasketById(username,id);
            var result = await mediator.Send(query);
           return View(result);
        }

        [HttpGet()]
        [Route("probaskets")]
        public async Task<IActionResult> OrderBySomething(ProBasket catalog, object criterio, CancellationToken cancellation)
        {
            var query = new OrderBySomething(catalog,criterio);
            var result =await mediator.Send(query);
            return View(result);
        }

        [HttpPut()]
     
        public async Task<IActionResult> UpdateById([FromBody] UpdateProBasketById command)
        {
              var result = await mediator.Send(command);
            return CreatedAtAction("Update",new {probasketId = result.Select(x =>x.id)},result);
        }
    }
    
}