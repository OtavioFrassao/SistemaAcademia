using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain;
using AcademiaDomain.Base;

namespace AcademiaRepository.Base
{
    /*Esta interface atua como um contrato, listando os métodos CRUD (Create, Read, Update, Delete) que o repositório é obrigado a ter.   A declaração genérica <TypeEntity> where TypeEntity : BaseEntity funciona como um filtro de segurança: garante que o repositório só aceite classes que possuam o campo ID validado pela sua classe base.*/
    public interface IBaseRepository<TypeEntity> where TypeEntity : IBaseEntity
    {
        //Metodos CRUD
        void Create(TypeEntity entity);
        TypeEntity ReadById(int id);
        IList<TypeEntity> ReadAll();
        void Update(TypeEntity entity);
        void Delete(int id);

    }
}
