using BusinessLogic.Abstractions;
using BusinessLogic.Services;
using ComponentRegistrar.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ComponentRegistrar
{
    /// <summary>
    /// Регистратор сервиса
    /// </summary>
    public static class Registrar
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationSettings = configuration.Get<ApplicationSettings>();
            services.AddSingleton(applicationSettings);
            return services.AddSingleton((IConfigurationRoot)configuration)
                .InstallServices();
        }
        
        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<ICourseService, CourseService>()
                .AddSingleton<ILessonService, LessonService>()
                .AddScoped<IStudentService, StudentService>();
            return serviceCollection;
        }
    }
}