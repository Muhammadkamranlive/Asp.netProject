using RepositoryCourses.Middlerware;

namespace RepositoryCourses.Configurations
{
    public static class ConfigureMiddlware
    {
        public static IApplicationBuilder ConfigureErrorHandler(this IApplicationBuilder applicationBuilder)
            => applicationBuilder.UseMiddleware<GlobalErrorHandlingMiddleware>();
    }
}
