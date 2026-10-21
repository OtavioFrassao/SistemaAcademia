using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using AcademiaDomain;

namespace AcademiaService.Validators
{
    public class AlunoValidator : AbstractValidator<Aluno>
    {
        public AlunoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório")
                .NotNull().WithMessage("O nome não pode ser nulo")
                .Length(2, 100).WithMessage("O nome deve ter entre 2 e 100 caracteres");
            RuleFor(a => a.DataNascimento)
                .InclusiveBetween(new DateTime(1900, 1, 1), DateTime.Now).WithMessage("A data do aluno deve estar entre a data mínima e a data atual.");
            RuleFor(a => a.Email)
                .NotEmpty().WithMessage("O email do aluno é obrigatório.")
                .EmailAddress().WithMessage("O email do aluno deve ser um endereço de email válido.");
            RuleFor(a => a.Telefone)
                .NotEmpty().WithMessage("O telefone do aluno é obrigatório.")
                .Matches(@"^\(\d{2}\) \d{4,5}-\d{4}$").WithMessage("O telefone do aluno deve estar no formato (XX) XXXXX-XXXX.");
            RuleFor(a => a.CPF)
                .NotEmpty().WithMessage("O CPF do aluno é obrigatório.")
                .Matches(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$").WithMessage("O CPF do aluno deve estar no formato XXX.XXX.XXX-XX.");
            RuleFor(a => a.StatusMatricula)
                .IsInEnum().WithMessage("O status da matrícula do aluno deve ser um valor válido.");
        }
    }
}
