using AcademiaDomain;
using AcademiaRepository.Base;
using AcademiaRepository.Context;
using AcademiaService.Base;
using AcademiaService.Validators;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AcademiaTest
{
    [TestClass]
    public class TestAcademiaService
    {
        // O = null!; remove o aviso de campo não anulável no construtor
        private ServiceCollection services = null!;

        [ClassInitialize]

        public static void SetupDatabase(TestContext context)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var instance = new TestAcademiaService();
            var provider = instance.ConfigureServices();

            using (var scope = provider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<MyDBContext>();
                db.Database.EnsureDeleted(); // Apaga banco de testes anterior
                db.Database.EnsureCreated(); // Recria tabelas atualizadas

                // Carga inicial para garantir que ID = 1 exista para as chaves estrangeiras
                var alunoBase = new Aluno
                {
                    Nome = "Aluno Base Teste",
                    CPF = "000.111.222-33",
                    Email = "aluno.base@email.com",
                    Telefone = "(14) 99999-0000",
                    DataNascimento = new DateTime(2000, 1, 1),
                    StatusMatricula = true
                };
                db.Aluno.Add(alunoBase);

                var exercicioBase = new Exercicio
                {
                    Nome = "Supino Reto Base",
                    GrupoMuscular = "Peito"
                };
                db.Exercicio.Add(exercicioBase);

                db.SaveChanges();
            }
        }

        public ServiceProvider ConfigureServices()
        {
            var conStr = "Host=localhost;Port=5432;Database=AcademiaDBTestes;Username=postgres;Password=ifsp";
            services = new ServiceCollection();

            services.AddDbContext<MyDBContext>(options => options.UseNpgsql(conStr));

            // Registro dos Repositórios e Serviços Genéricos para cada entidade
            IServiceCollection serviceCollection = services.AddScoped<IBaseRepository<Aluno>, BaseRepository<Aluno>>();
            services.AddScoped<IBaseService<Aluno>, BaseService<Aluno>>();

            services.AddScoped<IBaseRepository<Exercicio>, BaseRepository<Exercicio>>();
            services.AddScoped<IBaseService<Exercicio>, BaseService<Exercicio>>();

            services.AddScoped<IBaseRepository<AvaliacaoFisica>, BaseRepository<AvaliacaoFisica>>();
            services.AddScoped<IBaseService<AvaliacaoFisica>, BaseService<AvaliacaoFisica>>();

            services.AddScoped<IBaseRepository<Treino>, BaseRepository<Treino>>();
            services.AddScoped<IBaseService<Treino>, BaseService<Treino>>();

            // Configuração do AutoMapper
            services.AddSingleton(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Aluno, Aluno>();
                cfg.CreateMap<Exercicio, Exercicio>();
                cfg.CreateMap<AvaliacaoFisica, AvaliacaoFisica>();
                cfg.CreateMap<Treino, Treino>();
                cfg.CreateMap<ItemTreino, ItemTreino>();
            }, NullLoggerFactory.Instance).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestAlunoService()
        {
            var serviceProvider = ConfigureServices();
            var alunoService = serviceProvider.GetService<IBaseService<Aluno>>()!;
            var aluno = new Aluno
            {
                Nome = "Otávio Service Test",
                CPF = "999.888.777-66",
                Email = "otavio.service@email.com",
                Telefone = "(14) 99999-8888",
                DataNascimento = new DateTime(2002, 5, 20),
                StatusMatricula = true
            };

            var result = alunoService!.Create<Aluno, Aluno, AlunoValidator>(aluno);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestAvaliacaoFisicaService()
        {
            var serviceProvider = ConfigureServices();
            using (var scope = serviceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<MyDBContext>();
                var avaliacaoService = scope.ServiceProvider.GetRequiredService<IBaseService<AvaliacaoFisica>>();

                var aluno = new Aluno
                {
                    Nome = "Aluno Avaliação Teste",
                    CPF = "123.456.789-00",
                    Email = "avaliacao@email.com",
                    Telefone = "(14) 98888-7777",
                    DataNascimento = new DateTime(2000, 1, 1),
                    StatusMatricula = true
                };
                var avaliacao = new AvaliacaoFisica
                {
                    Peso = 78.0,
                    Altura = 1.80,
                    DataAvaliacao = DateTime.Now,
                    Observacao = "Teste via Service",
                    Aluno = aluno
                };

                var result = avaliacaoService.Create<AvaliacaoFisica, AvaliacaoFisica, AvaliacaoFisicaValidator>(avaliacao);
                Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                }));
            }
        }

        [TestMethod]
        public void TestTreinoService()
        {
            var serviceProvider = ConfigureServices();
            using (var scope = serviceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<MyDBContext>();
                var treinoService = scope.ServiceProvider.GetRequiredService<IBaseService<Treino>>();

                // Busca as entidades no contexto do escopo para evitar a tentativa de reinserção
                var aluno = new Aluno
                {
                    Nome = "Aluno Treino Teste",
                    CPF = "111.222.333-00",
                    Email = "treino@email.com",
                    Telefone = "(14) 97777-6666",
                    DataNascimento = new DateTime(2000, 1, 1),
                    StatusMatricula = true
                };

                var exercicio = new Exercicio
                {
                    Nome = "Supino Reto Teste",
                    GrupoMuscular = "Peito"
                };

                var treino = new Treino
                {
                    Descricao = "Treino A - Peito",
                    DataInicio = DateTime.Now,
                    DataFim = DateTime.Now.AddMonths(1),
                    Aluno = aluno,
                    ItensTreino = new List<ItemTreino>
                    {
                        new ItemTreino
                        {
                            Exercicio = exercicio,
                            Series = 4,
                            Repeticoes = "10",
                            CargaRecomendada = "25kg"
                        }
                    }
                };

                var result = treinoService.Create<Treino, Treino, TreinoValidator>(treino);
                Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                }));
            }
        }
    }
}
