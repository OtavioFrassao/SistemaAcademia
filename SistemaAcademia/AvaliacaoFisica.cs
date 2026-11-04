using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademiaDomain.Base;

namespace AcademiaDomain
{
    public class AvaliacaoFisica : BaseEntity
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public DateTime DataAvaliacao { get; set; } = DateTime.Now;
        public string Observacao { get; set; } = string.Empty;
        public float PercentualGordura { get; set; }

        // Objeto em vez de AlunoID simples
        public Aluno Aluno { get; set; } = null!;

    }
}