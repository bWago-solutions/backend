namespace Web.Api.Endpoints;

public static class HealthEndpoint
{
    
    public static void MapHealthEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/health", () =>  Results.Ok("Service is healthy"));
    }
}