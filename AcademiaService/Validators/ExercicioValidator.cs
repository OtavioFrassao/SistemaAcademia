using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using AcademiaDomain;

namespace AcademiaService.Validators
{
    public class ExercicioValidator : AbstractValidator<Exercicio>
    {
        public ExercicioValidator()
        {
            RuleFor(e => e.Nome)
                .NotEmpty().WithMessage("O nome do exercício é obrigatório.")
                .Length(2, 100).WithMessage("O nome do exercício deve ter entre 2 e 100 caracteres.");
            RuleFor(e => e.GrupoMuscular)
                .NotEmpty().WithMessage("O grupo muscular do exercício é obrigatório.")
                .Length(2, 100).WithMessage("O grupo muscular do exercício deve ter entre 2 e 100 caracteres.");
        }
    }
}
