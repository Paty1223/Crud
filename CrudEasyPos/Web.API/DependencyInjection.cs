using Application;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Web.API;

public static class DependencyInjectiion
{

}
public static  IServiceCollection AddPresentation(this IServiceCollection service)
{
    Services.AddControlles();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    return Services;
}