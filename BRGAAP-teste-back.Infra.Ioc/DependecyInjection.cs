using BRGAAP_back_teste.Application.Interfaces;
using BRGAAP_back_teste.Application.Services;
using BRGAAP_teste_back.Domain.Interfaces;
using BRGAAP_teste_back.Infra.Data.Context;
using BRGAAP_teste_back.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Infra.Ioc
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<ApplicantionDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("postgresConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicantionDbContext).Assembly.FullName));
                
            });
            return services;
        }
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddApplicationServices()
                .AddApplicationRepositories();
            return services;
        }
        private static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<INotaFiscalService, NotaFiscalService>();
            services.AddScoped<IClienteService, ClienteSevice>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            return services;
        }
        private static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
        {
            services.AddScoped<INotaFiscalRepository, NotaFiscalRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IUnitiOfWork, UnitOfWork>();
            return services;
        }
    }
}
