using Microsoft.AspNetCore.Mvc;
using OmsApp.Dtos;
using OmsApp.Services.OrderService;

namespace OmsApp.Controllers.Order;

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrdersAsync();
            return Ok(orders);
        }

        [HttpPost]
        public async Task<ActionResult<CreateOrderDto>> CreateOrder(CreateOrderDto createOrderDto)
        {
            var createdOrder = await _orderService.CreateOrderAsync(createOrderDto);
            return CreatedAtAction(nameof(GetAllOrders), new {id = createdOrder.Id}, createdOrder);
        }
    }