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
            _myDbContext.Add(entity);
            _myDbContext.SaveChanges();
        }
        public TypeEntity ReadById(int id)
        {
            var dbContext = _myDbContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList().Find(x => x.ID == id);
        }

        public IList<TypeEntity> ReadAll()
        {
            var dbContext = _myDbContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList();
        }

        public void Update(TypeEntity entity)
        {
            _myDbContext.Entry(entity).State = EntityState.Modified;
            _myDbContext.SaveChanges(true);
        }
        public void Delete(int id)
        {
            _myDbContext.Remove(ReadById(id));
            _myDbContext.SaveChanges();
        }
    }
}
