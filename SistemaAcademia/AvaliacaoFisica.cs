using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademiaDomain
{
    public class AvaliacaoFisica : BaseEntity
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public string Observacao { get; set; } = string.Empty;

        // Objeto em vez de AlunoID simples
        public Aluno Aluno { get; set; } = null!;

    }
}