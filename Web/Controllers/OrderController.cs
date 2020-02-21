using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Entities.Orders;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Adapters.Repositories;
using Web.Query.RequestsOrder;

using Web.Response.ResponseOrder;

using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers
{   [Authorize(Roles = "Administrator")]
    public class OrderController : Controller
    {
        
        private readonly IAsyncOrderRepository reposiotry;
        private readonly ILogger<OrderController> logger;
        private readonly IMediator mediator;

        public OrderController(ILogger<OrderController> logger, IMediator mediator, IAsyncOrderRepository reposiotry)
        {   this.reposiotry = reposiotry;
            this.logger = logger;
            this.mediator = mediator;
        }
        

         [HttpGet()]
        [Route("orders")]
        
        public async Task<IActionResult> Count(Order catalog, CancellationToken cancellation)
        {
            var query = new CountOrder(catalog);
            var result = await mediator.Send(query);
            return View(result);
        }

         [Authorize(Roles = "UserManager")]
        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] CreateManyOrder command)
        {
             var result = await mediator.Send(command);
            return CreatedAtAction("GetOrder",new {ordersId = result.Select(x =>x.id)},result);
        }

         [Authorize(Roles = "UserManager")]
        [HttpPost("")]
        public async Task<IActionResult> CreateMany([FromBody] CreateManyOrder command)
        { 
           var result = await mediator.Send(command);
            return CreatedAtAction("GetOrder",new {ordersId = result.Select(x =>x.id)},result);
            
        }

        [HttpPost("")]
        
        public async Task<IActionResult> DeleteById([FromBody] DeleteOrderById command)
        {
                var result = await mediator.Send(command);
                return CreatedAtAction("Delete",new {ordersId = result.Select(x =>x.id)},result);
      
        }

        
        [HttpGet("")]
         [Route("order")]
        public async Task<IActionResult> GetItems(string username)
        {
            var command = new GetOrders(username);
                var result = await mediator.Send(command);
                if(result != null)return Ok(result);
                return BadRequest("Try again");
        }

         [HttpGet("")]
        [Route("orders")]
        public async  Task<IActionResult> GetItemsById(string username, uint id)
        {
              var query = new GetOrderById(username,id);
            var result =await mediator.Send(query);
            return View(result);
        }

        [HttpGet("")]
        [Route("orders")]
        public async  Task<IActionResult> OrderBySomething(Order catalog, object criterio, CancellationToken cancellation)
        {
            var command = new OrderBySomething(catalog,criterio);
                var result = await mediator.Send(command);
                return View(result);
        }

               
        [HttpPut("")]
        public async Task<IActionResult> UpdateById([FromBody] UpdateOrderById command)
        {
             
            var result = await mediator.Send(command);
            return CreatedAtAction("Update",new {ordersId = result.Select(x =>x.id)},result);
        
         }
    }
}