using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademiaDomain
{
    public class Treino : BaseEntity
    {
        public string Descricao { get; set; }


        public DateTime DataInicio { get; set; }


        public DateTime DataFim { get; set; }


        public int AlunoID { get; set; }


        public int DivisaoID { get; set; }

    }
}