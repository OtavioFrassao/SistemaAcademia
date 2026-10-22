using AcademiaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaRepository.Mapping
{
    public class AvaliacaoFisicaMap : IEntityTypeConfiguration<AvaliacaoFisica>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoFisica> Builder)
        {
            Builder.ToTable("Avalição Fisica");
            Builder.HasKey(x => x.ID);
            Builder.Property(x => x.Peso).IsRequired(true);
            Builder.Property(x => x.Altura).IsRequired(true);
            Builder.Property(a => a.DataAvaliacao).IsRequired();
            Builder.Property(a => a.Observacao).HasMaxLength(250);

            // Relacionamento: Várias avaliações pertencem a um Aluno
            Builder.HasOne(a => a.Aluno).WithMany(al => al.AvaliacoesFisicas).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
