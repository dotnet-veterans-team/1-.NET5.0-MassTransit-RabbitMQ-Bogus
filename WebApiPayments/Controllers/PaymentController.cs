using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebApiPayments.Models;
using WebApiPayments.ViewModel;

namespace WebApiPayments.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IBusControl _bus;

        public PaymentController(IBusControl bus)
        {
            _bus = bus;
        }

        [HttpPost]
        [Route("/api/payments/")]
        public async Task<IActionResult> CreatePayment([FromBody] PaymentViewModel paymentViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Uri uri = new(RabbitMqSettings.RabbitMqUri);
            var endPoint = await _bus.GetSendEndpoint(uri);
            
            await Task.Delay(5000);
            
            await endPoint.Send(paymentViewModel);

            return Ok("Success");
        }
    }
}
