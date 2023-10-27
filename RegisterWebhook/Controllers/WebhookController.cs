using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/webhook")]
public class WebhookController : ControllerBase
{
    private readonly ILogger<WebhookController> _logger;

    public WebhookController(ILogger<WebhookController> logger)
    {
        _logger = logger;
    }

    [HttpPost("register-pos")]
    public IActionResult RegisterPosWebhook(RegisterPosPayload payload)
    {
        // Process the incoming payload and generate the response
        var response = new WebhookUrls
        {
            OrdersWebhookURL = "https://integrator.com/ordersWebhookURL",
            SyncProductsURL = "https://integrator.com/syncProductsURL",
            SyncTablesURL = "https://integrator.com/syncTablesURL",
            SyncFloorsURL = "https://integrator.com/syncFloorsURL"
        };

        // Log the received payload (optional)
        _logger.LogInformation("Received Register POS webhook request: {Payload}", payload);

        return Ok(response);
    }
}
