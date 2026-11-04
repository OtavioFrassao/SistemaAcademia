using AcademiaApp.Cadastros;
using AcademiaDomain;
using AcademiaRepository.Base;
using AcademiaRepository.Context;
using AcademiaService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.IO;

namespace AcademiaApp.Infra
{
    public class ConfigureDI
    {
        public static ServiceCollection Services = null!;
        public static IServiceProvider ServiceProvider = null!;

        public static void Configure()
        {
            Services = new ServiceCollection();

            #region Banco de Dados Injeção de Dependências
            var strCon = File.ReadAllText("Config/ConfigDB.txt").Trim();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            /*No Windows Forms, a conexão com o banco de dados fica viva durante toda a execução da tela. Quando a grid de consulta é carregada, o Entity Framework guarda o exercício na memória. Ao tentar salvar a edição, a arquitetura do projeto (usando o AutoMapper) cria uma "cópia" desse exercício com o mesmo ID. O Entity Framework bloqueia a atualização porque não aceita gerenciar duas versões do mesmo ID ao mesmo tempo.*/
            Services.AddDbContext<MyDBContext>(options =>
            {
                options.UseNpgsql(strCon);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }, ServiceLifetime.Transient);
            #endregion

            #region Repositorio Injeção de Dependência
            Services.AddScoped<IBaseRepository<Aluno>, BaseRepository<Aluno>>();
            Services.AddScoped<IBaseRepository<Exercicio>, BaseRepository<Exercicio>>();
            Services.AddScoped<IBaseRepository<AvaliacaoFisica>, BaseRepository<AvaliacaoFisica>>();
            Services.AddScoped<IBaseRepository<Treino>, BaseRepository<Treino>>();
            Services.AddScoped<IBaseRepository<ItemTreino>, BaseRepository<ItemTreino>>();
            #endregion

            #region Serviços Injeção de Dependência
            Services.AddScoped<IBaseService<Aluno>, BaseService<Aluno>>();
            Services.AddScoped<IBaseService<Exercicio>, BaseService<Exercicio>>();
            Services.AddScoped<IBaseService<AvaliacaoFisica>, BaseService<AvaliacaoFisica>>();
            Services.AddScoped<IBaseService<Treino>, BaseService<Treino>>();
            Services.AddScoped<IBaseService<ItemTreino>, BaseService<ItemTreino>>();
            #endregion

            #region AutoMapper Injeção de Dependência
            Services.AddSingleton(new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Aluno, Aluno>();
                cfg.CreateMap<Exercicio, Exercicio>();
                cfg.CreateMap<AvaliacaoFisica, AvaliacaoFisica>();
                cfg.CreateMap<Treino, Treino>();
                cfg.CreateMap<ItemTreino, ItemTreino>();
            }, NullLoggerFactory.Instance).CreateMapper());
            #endregion

            #region Registro dos Formulários
            Services.AddTransient<CadastroExercicio>();
            Services.AddTransient<CadastroAluno>();
            Services.AddTransient<CadastroAvaliacaoFisica>();
            Services.AddTransient<CadastroTreino>();
            Services.AddTransient<CadastroItemTreino>();
            #endregion

            ServiceProvider = Services.BuildServiceProvider();

            // Força a criação do banco AcademiaDB e suas tabelas caso ainda não existam
            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<MyDBContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
