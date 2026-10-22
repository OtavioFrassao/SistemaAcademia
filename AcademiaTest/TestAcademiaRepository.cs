using AcademiaDomain;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AcademiaTest
{
    [TestClass]
    public class TestAcademiaRepository
    {
        public partial class MyDBContext : DbContext
        {
            public DbSet<Aluno> Aluno { get; set; }
            public DbSet<AvaliacaoFisica> AvaliacaoFisica { get; set; }
            public DbSet<Exercicio> Exercicio { get; set; }
            public DbSet<ItemTreino> ItemTreino { get; set; }
            public DbSet<Treino> Treino { get; set; }

            public MyDBContext()
            {
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                //Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                var server = "localhost";
                var port = "5432";
                var username = "postgres";
                var password = "ifsp";
                var database = "AcademiaDBTestes";
                var conStr = $"Host={server};Port={port};Database={database};Username={username};Password={password}";

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseNpgsql(conStr);
                }
            }
        }

        [ClassInitialize]
        public static void SetupDatabase(TestContext context)
        {
            using (var db = new MyDBContext())
            {
                db.Database.EnsureDeleted(); // Apaga o banco de testes antigo se existir
                db.Database.EnsureCreated(); // Cria as tabelas do zero de forma limpa
            }
        }

        [TestMethod]
        public void CriarBanco()
        {
            using (var db = new MyDBContext())
            {
                Assert.IsNotNull(db);
            }
        }


        [TestMethod]
        public void InsereExercicio()
        {
            using (var db = new MyDBContext())
            {
                db.Exercicio.Add(new Exercicio { ID = 1, Nome = "Supino Reto", GrupoMuscular = "Peito" });
                db.Exercicio.Add(new Exercicio { ID = 2, Nome = "Puxada Frontal", GrupoMuscular = "Costas" });
                db.Exercicio.Add(new Exercicio { ID = 3, Nome = "Agachamento Livre", GrupoMuscular = "Pernas" });
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarExercicio()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Exercicio)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

        [TestMethod]
        public void InsereAluno()
        {
            using (var db = new MyDBContext())
            {
                db.Aluno.Add(new Aluno { ID = 1, Nome = "Otávio Frassão", CPF = "111.222.333-44", Email = "otavio@email.com", Telefone = "11999999999", DataNascimento = new DateTime(2000, 1, 1), StatusMatricula = true });
                db.Aluno.Add(new Aluno { ID = 2, Nome = "João Silva", CPF = "555.666.777-88", Email = "joao@email.com", Telefone = "11888888888", DataNascimento = new DateTime(1995, 5, 10), StatusMatricula = true });
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarAluno()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Aluno)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

        [TestMethod]
        public void InsereAvaliacaoFisica()
        {
            using (var db = new MyDBContext())
            {
                var aluno = db.Aluno.FirstOrDefault(x => x.ID == 1);

                //garante que pelo menos um aluno esteja criado para funcionar o teste
                if (aluno == null)
                {
                    aluno = new Aluno { Nome = "Otávio Frassão", CPF = "111.222.333-44", Email = "otavio@email.com", Telefone = "11999999999", DataNascimento = new DateTime(2000, 1, 1), StatusMatricula = true };
                    db.Aluno.Add(aluno);
                    db.SaveChanges();
                }

                var avaliacao = new AvaliacaoFisica
                {
                    ID = 1,
                    Peso = 75.5,
                    Altura = 1.78,
                    DataAvaliacao = DateTime.Now,
                    Observacao = "Avaliação inicial de reavaliação",
                    Aluno = aluno!
                };

                db.AvaliacaoFisica.Add(avaliacao);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarAvaliacaoFisica()
        {
            using (var db = new MyDBContext())
            {
                var avaliacoes = db.AvaliacaoFisica.Include(a => a.Aluno).ToList();
                foreach (var item in avaliacoes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item, new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles }));
                }
            }
        }

        [TestMethod]
        public void InsereTreinoEItens()
        {
            using (var db = new MyDBContext())
            {
                var aluno = db.Aluno.FirstOrDefault(x => x.ID == 1);
                if (aluno == null)
                {
                    aluno = new Aluno { Nome = "Otávio Frassão", CPF = "111.222.333-44", Email = "otavio@email.com", Telefone = "11999999999", DataNascimento = new DateTime(2000, 1, 1), StatusMatricula = true };
                    db.Aluno.Add(aluno);
                    db.SaveChanges();
                }

                var exercicioSupino = db.Exercicio.FirstOrDefault(x => x.ID == 1);

                var treino = new Treino
                {
                    ID = 1,
                    Descricao = "Foco Hipertrofia - Peito",
                    DataInicio = DateTime.Now,
                    DataFim = DateTime.Now.AddMonths(1),
                    Aluno = aluno!,
                    ItensTreino = new List<ItemTreino>()
                };

                treino.ItensTreino.Add(new ItemTreino { ID = 1, Exercicio = exercicioSupino!/* Atribuído o objeto Exercicio diretamente*/, Series = 4, Repeticoes = "12", CargaRecomendada = "20kg de cada lado" });

                db.Treino.Add(treino);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarTreinoEItens()
        {
            using (var db = new MyDBContext())
            {
                // Include garante que ele traga a lista de itens de treino ao buscar o treino (como o professor faria num relatório)
                var treinos = db.Treino.Include(t => t.ItensTreino).ToList();
                foreach (var item in treinos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item, new JsonSerializerOptions { ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles }));
                }
            }
        }
}
}
