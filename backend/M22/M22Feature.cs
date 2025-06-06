using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using M22.Services;

namespace M22;

public class M22Feature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IM22Service, M22Service>();
    }
}