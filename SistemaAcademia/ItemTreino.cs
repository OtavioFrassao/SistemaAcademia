using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademiaDomain
{
    public class ItemTreino : BaseEntity
    {
        public int TreinoID { get; set; }


        public int ExercicioID { get; set; }


        public int Series { get; set; }


        public string Repeticoes { get; set; }


        public string CargaRecomendada { get; set; }

    }
}