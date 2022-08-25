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
            var agendamento = serviceProvider.GetService<IAgendamentoService>();

            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenu(dentists, agendamento));

        }
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IDentistaService, DentistaService>()
                .AddScoped<IAgendamentoService, AgendamentoService>();
        }
    }
}