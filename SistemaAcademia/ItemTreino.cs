using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademiaDomain
{
    public class ItemTreino : BaseEntity
    {
        public  Treino Treino { get; set; }

        public  Exercicio Exercicio { get; set; }

        public int Series { get; set; }


        public string Repeticoes { get; set; }


        public string CargaRecomendada { get; set; }

    }
}