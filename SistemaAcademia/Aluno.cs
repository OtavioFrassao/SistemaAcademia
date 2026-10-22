using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademiaDomain.Base;

namespace AcademiaDomain
{
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        public bool StatusMatricula { get; set; }

        public string CPF { get; set; }

        public virtual ICollection<Treino> Treinos { get; set; } = new List<Treino>();
        public virtual ICollection<AvaliacaoFisica> AvaliacoesFisicas { get; set; } = new List<AvaliacaoFisica>();
        /*A palavra virtual é o segredo aqui. Ela permite que, mais tarde, quando o Entity Framework for buscar um Aluno à base de dados PostgreSQL, ele consiga preencher automaticamente esta lista com todos os treinos que pertencem a esse aluno, sem que tenha de fazer pesquisas complexas.*/
    }
}