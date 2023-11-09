using CefaleasApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using CefaleasApp.DataAccess.SQLServer.Repository;

namespace CefaleasApp.DataAccess.SQLServer
{
    public static class DataAccessExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            services.AddDbContext<CefaleasContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Transient);
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<ICuestionarioRepository, CuestionarioRepository>();
            services.AddTransient<IEnfermedadRepository, EnfermedadRepository>();
            return services;
        }
    }
}
