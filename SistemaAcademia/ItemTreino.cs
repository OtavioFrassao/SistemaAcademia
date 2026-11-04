using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademiaDomain.Base;

namespace AcademiaDomain
{
    public class ItemTreino : BaseEntity
    {
        public int Series { get; set; }


        public string Repeticoes { get; set; } = string.Empty;


        public string CargaRecomendada { get; set; } = string.Empty;

        // Propriedades de navegação de objetos
        public  Exercicio Exercicio { get; set; } = null!;

        public  Treino Treino { get; set; } = null!;

    }
}