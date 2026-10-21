using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademiaRepository.Mapping 
{
    public class DivisaoMap : IEntityTypeConfiguration<Divisao>
    {
        public void Configure(EntityTypeBuilder<Divisao> Builder)
        {
            Builder.ToTable("Divisao");
            Builder.HasKey(x => x.ID);
            Builder.Property(x => x.Descricao).IsRequired(true).HasMaxLength(200);
        }
    }
}
