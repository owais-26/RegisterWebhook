public class RegisterPosPayload
{
    public string AccountId { get; set; }
    public string LocationId { get; set; }
    public string ExternalLocationId { get; set; }
    public string LocationName { get; set; }
}

public class WebhookUrls
{
    public string OrdersWebhookURL { get; set; }
    public string SyncProductsURL { get; set; }
    public string SyncTablesURL { get; set; }
    public string SyncFloorsURL { get; set; }
}
