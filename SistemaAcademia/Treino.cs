using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademiaDomain.Base;

namespace AcademiaDomain
{
    public class Treino : BaseEntity
    {
        public string Descricao { get; set; } = string.Empty;


        public DateTime DataInicio { get; set; }


        public DateTime DataFim { get; set; }


        public Aluno Aluno { get; set; }

        public virtual ICollection<ItemTreino> ItensTreino { get; set; } = new List<ItemTreino>();
    }
}