using InvoiceReaderAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceReaderAPI.Controllers
{
    [ApiController]
    [Route("api/pof")]
    public class ProofOfPaymentController : ControllerBase
    {
        private readonly ILogger<ProofOfPaymentController> _logger;

        public ProofOfPaymentController(ILogger<ProofOfPaymentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<RequestOutput>> Post([FromForm] RequestInput requestInput)
        {
            _logger.Log(LogLevel.Information, Environment.GetEnvironmentVariable("TEST"));

            // validate image
            // deserializes request 
            // create entity in db
            // upload image to blob 
            // updates image URL from blob in DB
            // post job in form recognizer
            // wait a few seconds
            // get job status from form recognizer

            var response = new RequestOutput
            {
                Id = 1,
                Content = "Teste"
            };

            return response;
        }
    }
}
