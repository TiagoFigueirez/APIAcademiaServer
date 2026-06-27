using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class ProfessorValidator : AbstractValidator<Professor>
    {
        public ProfessorValidator()
        {
            RuleFor(x => x.Cref)
                .Length(11, 11).WithMessage("O Cref deve ter 6 caracteres")
                .NotEmpty().WithMessage("O Cref esta em branco");

            RuleFor(x => x.Especialidade)
                .Length(2, 60).WithMessage("A especialidade deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Especialidade esta em branco");

            RuleFor(x => x.funcionarioId)
                .NotNull().WithMessage("Os dados do professor deve pertencer a um funcionario");
        }
    }
}
