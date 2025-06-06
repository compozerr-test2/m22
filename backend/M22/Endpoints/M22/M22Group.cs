using Carter;
using Microsoft.AspNetCore.Routing;

namespace M22.Endpoints.M22;

public class M22Group : CarterModule
{
    public M22Group() : base("/m22")
    {
        WithTags(nameof(M22));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddM22Route();
    }
}