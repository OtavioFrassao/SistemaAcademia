using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain.Base;
using AcademiaRepository.Context;
using Microsoft.EntityFrameworkCore;
//instalamos o entity framework core e o entity framework core sql server para podermos trabalhar com o banco de dados
//instalamos o npgsql.entityframeworkcore para podermos trabalhar com o banco de dados postgresql
//instalamos o entity framework.desing para podermos trabalhar com o banco de dados postgresql
//instalamos o entity framework core tools para podermos trabalhar com o banco de dados postgresql

namespace AcademiaRepository.Base
{
    /*Esta classe pega no contrato anterior e diz como o código deve ser executado no Entity Framework.   
     É injetado o MyDBContext através do construtor para dar acesso ao banco de dados.   
     No método Create, a entidade é preparada na memória (Add) e de seguida enviada fisicamente para o banco de dados (SaveChanges). */
    public class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDbContext;

        public BaseRepository(MyDBContext myDbContext)
        {
            _myDbContext = myDbContext;
            _myDbContext.Set<TypeEntity>();
        }
        public void Create(TypeEntity entity)
        {
            _myDbContext.ChangeTracker.Clear();
            _myDbContext.Attach(entity);
            // Define apenas a AvaliacaoFisica principal como Added
            _myDbContext.Entry(entity).State = EntityState.Added;
            _myDbContext.SaveChanges();
            _myDbContext.ChangeTracker.Clear();
        }

        /*Como o seu modelo não utiliza a chave estrangeira explícita (AlunoId) a pedido do professor, a solução é garantir que todas as consultas leiam os dados desconectados da memória (AsNoTracking()) e desanexar as entidades após salvar.*/

        /*O método Attach avisa ao EF Core que os objetos relacionados que já possuem ID (como o Aluno) já existem no banco e não devem ser inseridos novamente.*/
        public TypeEntity ReadById(int id)
        {
            _myDbContext.ChangeTracker.Clear();
            var dbContext = _myDbContext.Set<TypeEntity>().AsNoTracking().AsQueryable();
            return _myDbContext.Set<TypeEntity>().AsNoTracking().FirstOrDefault(x => x.ID == id);
        }

        public IList<TypeEntity> ReadAll()
        {
            _myDbContext.ChangeTracker.Clear();
            var dbContext = _myDbContext.Set<TypeEntity>().AsNoTracking().AsQueryable();
            return dbContext.ToList();
        }

        public void Update(TypeEntity obj)
        {
            _myDbContext.ChangeTracker.Clear();

            _myDbContext.Attach(obj);
            _myDbContext.Entry(obj).State = EntityState.Modified;

            _myDbContext.SaveChanges();
            _myDbContext.ChangeTracker.Clear();
        }
        public void Delete(int id)
        {
            _myDbContext.ChangeTracker.Clear();
            _myDbContext.Remove(ReadById(id));
            _myDbContext.SaveChanges();
            _myDbContext.ChangeTracker.Clear();
        }
    }
}
