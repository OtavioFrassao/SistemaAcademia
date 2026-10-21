using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademiaRepository.Mapping
{
    public class ExercicioMap : IEntityTypeConfiguration<Exercicio>
    {
        public void Configure(EntityTypeBuilder<Exercicio> Builder)
        {
            Builder.ToTable("Exercicio");
            Builder.HasKey(x => x.ID);
            Builder.Property(x => x.Nome).IsRequired(true).HasMaxLength(50);
            Builder.Property(x => x.GrupoMuscular).IsRequired(true).HasMaxLength(50);
        }
    }
}
