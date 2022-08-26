using Microsoft.OpenApi.Models;

namespace MediatRSample.Config
{
    public class SwaggerConfig
    {
        public virtual void GerarDocumentacao(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Pessoas API",
                    Description = "API para Cadastro de Pessoas",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Contato",
                        Url = new Uri("https://example.com/contato")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "License",
                        Url = new Uri("https://example.com/license")
                    }
                });
            });
        }
    }
}