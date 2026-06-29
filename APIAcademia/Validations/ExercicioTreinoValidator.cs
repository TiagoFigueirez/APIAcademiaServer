using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class ExercicioTreinoValidator : AbstractValidator<ExercicioTreino>
    {
        public ExercicioTreinoValidator()
        {
            RuleFor(x => x.Series)
                .GreaterThan(0).WithMessage("O valor não pode ser zero")
                .InclusiveBetween(1, 100).WithMessage("O numero de Series deve esta entre 1 a 100."); ;

            RuleFor(x => x.Repeticoes)
                .InclusiveBetween(1, 100).WithMessage("O numero de Repetições deve esta entre 1 a 100.");

            RuleFor(x => x.ExercicioId)
                .NotNull().WithMessage("os treinos devem estar atrelados ao menos um exercicio");

            RuleFor(x => x.TreinoId)
                .NotNull().WithMessage("os treinos  devem estar atrelados ao menos um treino geral");
        }
    }
}
