using Application.Users.Create;
using MediatR;
using SharedKernel;
using Web.Api.Extensions;

namespace Web.Api.Endpoints;

public static class UserEndPoint
{
    public static void MapUserEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("api/users", async (CreateUserCommand command, ISender sender) =>
        {
            Result<Guid> result = await sender.Send(command);

            return result.IsSuccess ? Results.Ok(result.Value) : result.ToProblemDetails();
        });

        app.MapGet("api/health", () => Results.Ok("Service healthy"));
    }
}