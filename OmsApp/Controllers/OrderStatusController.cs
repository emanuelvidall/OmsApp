using Microsoft.AspNetCore.Mvc;
using OmsApp.Dtos;
using OmsApp.Services;

namespace OmsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderStatusController : ControllerBase
    {
        private readonly IOrderStatusService _orderStatusService;

        public OrderStatusController(IOrderStatusService orderStatusService)
        {
            _orderStatusService = orderStatusService;
        }
        
        //POST: api/OrderStatus
        [HttpPost]
        public async Task<IActionResult> CreateOrderStatus([FromBody] OrderStatusCreateDto orderStatusCreateDto)
        {
            if (orderStatusCreateDto == null)
            {
                return BadRequest("OrderStatus data is required.");
            }

            try
            {
                var orderStatus = await _orderStatusService.CreateOrderStatusAsync(orderStatusCreateDto);
                return Ok(orderStatus);
            }
            catch(ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}