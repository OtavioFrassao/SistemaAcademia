using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain;
using FluentValidation;

namespace AcademiaService.Validators
{
    public class ItemTreinoValidator : AbstractValidator<ItemTreino>
    {
        public ItemTreinoValidator()
        {
            RuleFor(it => it.TreinoID)
                .NotEmpty().WithMessage("TreinoID é obrigatório.")
                .GreaterThan(0).WithMessage("TreinoID deve ser maior que zero.");
            RuleFor(it => it.ExercicioID)
                .NotEmpty().WithMessage("ExercicioID é obrigatório.")
                .GreaterThan(0).WithMessage("ExercicioID deve ser maior que zero.");
            RuleFor(it => it.Series)
                .NotEmpty().WithMessage("Series é obrigatório.")
                .GreaterThan(0).WithMessage("Series deve ser maior que zero.");
            RuleFor(it => it.Repeticoes)
                .NotEmpty().WithMessage("Repeticoes é obrigatório.");
            RuleFor(it => it.CargaRecomendada)
                .NotEmpty().MaximumLength(50).WithMessage("CargaRecomendada é obrigatório.");

        }
    }
}
