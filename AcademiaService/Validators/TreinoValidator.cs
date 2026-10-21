using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AcademiaDomain;
using FluentValidation;
using static System.Net.WebRequestMethods;

namespace AcademiaService.Validators
{
    public class TreinoValidator : AbstractValidator<Treino>
    {
        public TreinoValidator()
        {
            RuleFor(t => t.Descricao)
                .NotEmpty().WithMessage("A descrição é obrigatória.")
                .MaximumLength(100).WithMessage("A descrição deve ter no máximo 100 caracteres.");
            RuleFor(t => t.DataInicio)
                .LessThanOrEqualTo(t => t.DataFim).WithMessage("A data de início deve ser menor ou igual à data de fim.");
            RuleFor(t => t.DataFim)
                .GreaterThanOrEqualTo(t => t.DataInicio).WithMessage("A data de fim deve ser maior ou igual à data de início.");
            RuleFor(t => t.AlunoID)
                .GreaterThan(0).WithMessage("O ID do aluno deve ser maior que zero.");
            RuleFor(t => t.DivisaoID)
                .GreaterThan(0).WithMessage("O ID da divisão deve ser maior que zero.");
            RuleFor(t => t.ItensTreino)
                .NotNull().WithMessage("A lista de exercícios não pode ser nula")
                .Must(list => list != null && list.Count > 0)
                .WithMessage("O treino deve ter pelo menos um exercício cadastrado");
        }
    }
}
