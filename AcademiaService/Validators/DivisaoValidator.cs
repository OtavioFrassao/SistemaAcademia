using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using AcademiaDomain;

namespace AcademiaService.Validators
{
    public class DivisaoValidator : AbstractValidator<Divisao>
    {
        public DivisaoValidator()
        {
            RuleFor(d => d.Descricao)
                .NotNull().WithMessage("A descrição da divisão não pode ser nula.")
                .NotEmpty().WithMessage("A descrição da divisão é obrigatória.")
                .Length(2, 200).WithMessage("A descrição da divisão deve ter entre 2 e 200 caracteres.");
        }
    }
}
