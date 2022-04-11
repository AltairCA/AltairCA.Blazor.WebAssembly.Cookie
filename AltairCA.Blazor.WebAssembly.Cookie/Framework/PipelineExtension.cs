using AltairCA.Blazor.WebAssembly.Cookie.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AltairCA.Blazor.WebAssembly.Cookie.Framework;

public static class PipelineExtension
{
    public static IServiceCollection AddAltairCACookieService(this IServiceCollection services,Action<AltairCABlazorCookieConfigOptions> configure)
    {
        services.Configure(configure);
        services.AddSingleton<IAltairCABlazorCookieUtil, AltairCABlazorCookieUtil>();
        return services;
    } 
}