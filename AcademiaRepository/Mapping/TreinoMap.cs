using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademiaRepository.Mapping
{
    public class TreinoMap : IEntityTypeConfiguration<Treino>
    {
        public void Configure(EntityTypeBuilder<Treino> Builder)
        {
            Builder.ToTable("Treino");
            // Chave Primária
            Builder.HasKey(x => x.ID);
            Builder.Property(x => x.Descricao).IsRequired(true).HasMaxLength(150);
            Builder.Property(x => x.DataInicio).IsRequired(true);
            Builder.Property(x => x.DataFim).IsRequired(true);

            // Configuração das Chaves Estrangeiras (Relacionamentos)

            // Ligação com o Aluno (1 para N)
            Builder.HasOne(x => x.Aluno).WithMany(a => a.Treinos).OnDelete(DeleteBehavior.Cascade); //OnDelete cascate: Se apagar o aluno, os treinos dele são apagados

            // Relacionamento com ItensTreino
            Builder.HasMany(x => x.ItensTreino).WithOne(i => i.Treino).OnDelete(DeleteBehavior.Cascade);
            /*
             HasOne<Aluno>() e WithMany(x => x.Treinos): Esta linha traduz-se para SQL da seguinte forma: "Este Treino pertence a UM Aluno, e esse Aluno contém MUITOS Treinos na sua lista virtual". O Entity Framework vai usar o campo AlunoID para fazer a ligação oficial no PostgreSQL.

             HasOne<Divisao>() e WithMany(): O mesmo raciocínio aplica-se à Divisão. A diferença é que os parênteses do WithMany() estão vazios. Isto significa que não precisamos de criar uma lista de treinos dentro da classe Divisao (afinal, não nos interessa carregar a lista de todos os treinos do mundo sempre que procuramos pela divisão "Hipertrofia").
             */
        }
    }
}
