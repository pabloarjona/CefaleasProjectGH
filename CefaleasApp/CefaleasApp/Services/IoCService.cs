using CefaleasApp.Models;
using CefaleasApp.Services.Interfaces;
using CefaleasApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Pitasoft.Client;
using Pitasoft.Shell.Services;
using Pitasoft.Shell.Xamarin.Services;
using System;
using System.Text.Json;

namespace CefaleasApp.Services
{
    public class IoCService : IoCServiceBase
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            string apiUrl= Configuration["ApiUrls:Production"];
            JsonSerializerOptions settings = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            services.AddSingleton(new SettingRestService
            {
                UriString = apiUrl,
                JsonSeializerOptions = settings,
            });

            // Registro de servicios
            services.AddSingleton<CefaleasRestService>();
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<IXamarin1SettingsService, Xamarin1SettingsService>();
            services.AddSingleton<IDialogService, DialogService>();
            services.AddSingleton<IMenuService, MenuService>();
            services.AddSingleton<ICriteriosCefalea, CriteriosCefalea>();

            // Registrar la ViewModels
            services.AddSingleton<UsuarioViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MenuViewModel>();
            services.AddSingleton<StartViewModel>();
            services.AddSingleton<AboutViewModel>();
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<PacienteViewModel>();
            services.AddSingleton<PacienteDetailViewModel>();
            services.AddSingleton<SignUpViewModel>();
            services.AddSingleton<FormularioViewModel>();
            services.AddSingleton<DiagnosticoViewModel>();
        }
    }
}