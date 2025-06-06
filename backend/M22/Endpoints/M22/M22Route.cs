using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using M22.Services;

namespace M22.Endpoints.M22;

public static class M22Route
{
    public static RouteHandlerBuilder AddM22Route(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IM22Service m22Service) => new GetM22Response($"Hello, {m22Service.GetObfuscatedName(name)}!"));
    }
}