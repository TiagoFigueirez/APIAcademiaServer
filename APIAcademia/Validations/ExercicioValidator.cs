using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class ExercicioValidator : AbstractValidator<Exercicio>
    {
        public ExercicioValidator()
        {
            RuleFor(x => x.Nome)
                .Length(2, 60).WithMessage("O nome deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("nome do usuario em branco");

            RuleFor(x => x.ParteDoCorpoTreino)
                .Length(2, 60).WithMessage("A parte do corpo do exercicio deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Parte do corpo do exercicio em branco");

            RuleFor(x => x.CaminhoVideo)
                .Length(1, 500);
        }
    }
}
