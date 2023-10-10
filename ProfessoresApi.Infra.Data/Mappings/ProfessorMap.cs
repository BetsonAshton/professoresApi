using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProfessoresApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Infra.Data.Mappings
{
    public class ProfessorMap: IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("PROFESSOR");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Nome)
            .HasColumnName("NOME")
            .HasMaxLength(150)
            .IsRequired();

            builder.Property(p => p.Matricula)
                .HasColumnName("MATRICULA")
                .IsRequired();

            builder.Property(P => P.Cpf)
               .HasColumnName("CPF")
               .HasMaxLength(11)
               .IsRequired();

            builder.Property(P => P.DataCadastro)
                .HasColumnName("DATACADASTRO")
                .IsRequired();

        }
    }
}
