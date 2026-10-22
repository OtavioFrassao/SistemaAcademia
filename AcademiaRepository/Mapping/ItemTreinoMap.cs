using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademiaRepository.Mapping
{
    public class ItemTreinoMap : IEntityTypeConfiguration<ItemTreino>
    {
        public void Configure(EntityTypeBuilder<ItemTreino> Builder)
        {
            Builder.ToTable("ItemTreino");
            Builder.HasKey(x => x.ID);
            Builder.Property(x => x.Series).IsRequired(true);
            Builder.Property(x => x.Repeticoes).IsRequired(true).HasMaxLength(50);
            Builder.Property(x => x.CargaRecomendada).IsRequired(true).HasMaxLength(50);

            // Ligação com o Treino (1 para N)
            Builder.HasOne<Treino>().WithMany(x => x.ItensTreino).HasForeignKey(x => x.Treino).OnDelete(DeleteBehavior.Cascade);

            // Ligação com o Exercicio (1 para N)
            Builder.HasOne<Exercicio>().WithMany().HasForeignKey(x => x.Exercicio).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
