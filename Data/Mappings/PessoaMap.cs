using MediatRSample.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatRSample.Data.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Idade).IsRequired();
            builder.Property(p => p.Sexo).IsRequired();
        }
    }
}
