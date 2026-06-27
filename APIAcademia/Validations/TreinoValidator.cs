using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class TreinoValidator : AbstractValidator<Treino>
    {
        public TreinoValidator()
        {
            RuleFor(x => x.DataVencimento).
                GreaterThan(DateTime.Today).WithMessage("A data deve ser no futuro.")
                .NotEmpty().WithMessage("Informe a data de vencimento do treino");
        }
    }
}
