using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Projeto.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Model.Model;
using Projeto.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Projeto.Data.Repositories.Interface;
using Projeto.Data.Repositories.Repository;
using Projeto.Service.Interface;
using Projeto.Service.Service;

namespace Projeto.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Projeto.Api", Version = "v1" });
            });

            services.AddDbContext<AppDbContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CondominioDto, Condominio>();
                cfg.CreateMap<Condominio, CondominioDto>();
                cfg.CreateMap<Predio, PredioDto>();
                cfg.CreateMap<PredioDto, Predio>();
                cfg.CreateMap<ApartamentoDto, Apartamento>();
                cfg.CreateMap<Apartamento, ApartamentoDto>();
                cfg.CreateMap<ProprietarioDto, Proprietario>();
                cfg.CreateMap<Proprietario, ProprietarioDto>();
                cfg.CreateMap<Morador, MoradorDto>();
                cfg.CreateMap<MoradorDto, Morador>();
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            //Repository
            services.AddTransient<ICondominioRepository, CondominioRepository>();
            services.AddTransient<IPredioRepository, PredioRepository>();
            services.AddTransient<IProprietarioRepository, ProprietarioRepository>();
            services.AddTransient<IApartamentoRepository, ApartamentoRepository>();


            //Service
            services.AddTransient<ICondominioService, CondominioService>();
            services.AddTransient<IPredioService, PredioService>();
            services.AddTransient<IApartamentoService, ApartamentoService>();
            services.AddTransient<IProprietarioService, ProprietarioService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Projeto.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
