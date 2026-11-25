
using System;
using System.Linq;
using AcademiaDomain;
using AcademiaRepository.Base;
using AcademiaRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace AcademiaRepository.Repositories
{
    public class TreinoRepository : BaseRepository<Treino>
    {
        public TreinoRepository(MyDBContext myDbContext)
            : base(myDbContext)
        {
        }

        public override void Update(Treino obj)
        {
            _myDbContext.ChangeTracker.Clear();

            try
            {
                // Busca o treino original e seus itens no banco
                var treino = _myDbContext.Treino
                    .IgnoreAutoIncludes()
                    .AsTracking()
                    .Include(t => t.ItensTreino)
                    .FirstOrDefault(t => t.ID == obj.ID);

                if (treino == null)
                    throw new Exception("Treino não encontrado.");

                var itensRecebidos = obj.ItensTreino.ToList();
                var itensOriginais = treino.ItensTreino.ToList();

                // Atualiza os dados principais do treino
                treino.NomeTreino = obj.NomeTreino;
                treino.Descricao = obj.Descricao;
                treino.DataInicio = obj.DataInicio;
                treino.DataFim = obj.DataFim;

                treino.Aluno = _myDbContext.Aluno
                    .AsTracking()
                    .First(a => a.ID == obj.Aluno.ID);

                // Remove os itens que não estão mais na lista
                foreach (var original in itensOriginais)
                {
                    if (!itensRecebidos.Any(i => i.ID == original.ID))
                    {
                        _myDbContext.ItemTreino.Remove(original);
                    }
                }

                // Adiciona ou atualiza os exercícios
                foreach (var item in itensRecebidos)
                {
                    var existente = itensOriginais
                        .FirstOrDefault(i => i.ID == item.ID);

                    if (item.ID != 0 && existente == null)
                        throw new Exception("Item de treino inválido.");

                    bool novo = existente == null;

                    if (novo)
                    {
                        existente = new ItemTreino
                        {
                            Treino = treino
                        };
                    }

                    existente.Exercicio = _myDbContext.Exercicio
                        .AsTracking()
                        .First(e => e.ID == item.Exercicio.ID);

                    existente.Series = item.Series;
                    existente.Repeticoes = item.Repeticoes;
                    existente.CargaRecomendada =
                        item.CargaRecomendada;

                    if (novo)
                    {
                        _myDbContext.ItemTreino.Add(existente);
                    }
                }

                // Salva todas as alterações juntas
                _myDbContext.SaveChanges();
            }
            finally
            {
                _myDbContext.ChangeTracker.Clear();
            }
        }
    }
}
