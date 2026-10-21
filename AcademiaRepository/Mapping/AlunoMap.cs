using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademiaRepository.Mapping
{
    /*
     A Interface Base: Ao implementar IEntityTypeConfiguration<Aluno>, o Entity Framework reconhece automaticamente este ficheiro quando o MyDBContext executar o OnModelCreating.
     Segurança de Dados: O IsRequired() impede que um aluno seja inserido na base de dados com campos em branco (transforma-se num NOT NULL no SQL do PostgreSQL).
     Otimização de Espaço: O HasMaxLength(50) limita o tamanho da coluna de texto, otimizando o desempenho das pesquisas e garantindo a integridade dos dados (transforma-se num VARCHAR(50)).
     */
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> Builder)
        {
            Builder.ToTable("Aluno");
            Builder.HasKey(x => x.ID);
            Builder.Property(x => x.Nome).IsRequired(true).HasMaxLength(50);
            Builder.Property(x => x.Email).IsRequired(true).HasMaxLength(50);
            Builder.Property(x => x.Telefone).IsRequired(true).HasMaxLength(16); //+55(14)997081218
            Builder.Property(x => x.DataNascimento).IsRequired(true);
            Builder.Property(x => x.StatusMatricula).IsRequired(true);
            Builder.Property(x => x.CPF).IsRequired(true).HasMaxLength(14); //123.456.789-01
        }
    }
}
