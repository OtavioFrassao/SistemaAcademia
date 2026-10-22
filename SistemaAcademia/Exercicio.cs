using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademiaDomain.Base;

namespace AcademiaDomain
{
    public class Exercicio : BaseEntity
    {
        public string Nome { get; set; }


        public string GrupoMuscular { get; set; } = string.Empty;

    }
}