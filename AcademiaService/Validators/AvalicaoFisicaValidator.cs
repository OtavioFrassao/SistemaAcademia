using AcademiaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaService.Validators
{
    public class AvaliacaoFisicaValidator : AbstractValidator<AvaliacaoFisica>
    {
        public AvaliacaoFisicaValidator()
        {
            RuleFor(a => a.Peso)
                .GreaterThan(0).WithMessage("O peso deve ser maior que zero.");

            RuleFor(a => a.Altura)
                .GreaterThan(0).WithMessage("A altura deve ser maior que zero.");

            RuleFor(a => a.DataAvaliacao)
                .InclusiveBetween(new DateTime(1900, 1, 1), DateTime.Now)
                .WithMessage("A data da avaliação deve estar entre 1900 e a data atual.");

            RuleFor(a => a.Aluno)
                .NotNull().WithMessage("A avaliação física precisa estar associada a um aluno.");
        }
    }
}
