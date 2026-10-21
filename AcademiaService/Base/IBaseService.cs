using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain.Base;

namespace AcademiaService.Base
{
    public interface IBaseService<TypeEntity> where TypeEntity : IBaseEntity
    {
    }
}
