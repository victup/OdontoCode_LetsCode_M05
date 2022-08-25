using Microsoft.Extensions.DependencyInjection;
using OdontoCode.Domain;
using OdontoCode.Services;
using OdontoCode.Services.Interfaces;

namespace OdontoCode.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var dentists = serviceProvider.GetService<IDentistaService>();
            var paciente = serviceProvider.GetService<IPacienteService>();

           
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenu(dentists, paciente));

        }
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IDentistaService, DentistaService>()
                .AddScoped<IPacienteService, PacienteService>();
        }
    }
}