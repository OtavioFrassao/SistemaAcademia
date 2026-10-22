using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;
using AcademiaDomain;
using AcademiaRepository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AcademiaRepository.Context
{
    /*
     Ao herdar de DbContext, esta classe torna-se o núcleo de comunicação entre a sua aplicação em C# e o servidor PostgreSQL.
     As declarações DbSet<...> avisam formalmente o Entity Framework de que existirão tabelas com os nomes das suas entidades.
     A configuração AppContext.SetSwitch dentro do construtor serve para corrigir uma incompatibilidade clássica do driver do PostgreSQL ao tentar guardar o formato de datas do .NET.
     O bloco OnModelCreating é o local onde o contexto "lê" as regras detalhadas de cada tabela.
     */
    public class MyDBContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Divisao> Divisao { get; set; }
        public DbSet<Exercicio> Exercicio { get; set; }
        public DbSet<ItemTreino> ItemTreino { get; set; }
        public DbSet<Treino> Treino { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>(new AlunoMap().Configure);
            modelBuilder.Entity<Divisao>(new DivisaoMap().Configure);
            modelBuilder.Entity<Exercicio>(new ExercicioMap().Configure);
            modelBuilder.Entity<ItemTreino>(new ItemTreinoMap().Configure);
            modelBuilder.Entity<Treino>(new TreinoMap().Configure);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Altere "sua_senha" para a senha real que definiu quando instalou o PostgreSQL no seu computador
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SistemaAcademiaDB;Username=postgres;Password=ifsp");
            }
        }

    }
}
