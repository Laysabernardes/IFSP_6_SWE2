using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using WINDOWS_FORMS.Repositories; 

namespace WINDOWS_FORMS
{
    internal static class Program
    {
        public static IHost AppHost { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppHost = CreateHostBuilder().Build();
            AppHost.Start();

            var formUsuarios = AppHost.Services.GetRequiredService<FormUsuarios>();
            Application.Run(formUsuarios);
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddHttpClient<IUsuarioRepository, UsuarioRepository>(client =>
                    {
                        client.BaseAddress = new Uri("https://localhost:7000/");
                    });

                    services.AddTransient<FormUsuarios>();
                    services.AddTransient<FormCadastro>();
                });
    }
}