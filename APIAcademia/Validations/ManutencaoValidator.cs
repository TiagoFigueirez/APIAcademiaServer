using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class ManutencaoValidator : AbstractValidator<Manutencao>
    {
        public ManutencaoValidator()
        {
            RuleFor(x => x.Data)
                .NotEmpty().WithMessage("Data da manutencao em branco");

            RuleFor(x => x.Valor)
                .GreaterThan(0).WithMessage("O valor não pode ser zero")
                .PrecisionScale(18, 2, false).WithMessage("O preço deve conter duas casas decimais");

            RuleFor(x => x.EquipamentoId)
                .NotNull().WithMessage("A manutençao deve pertencer a um equipamento");
        }
    }
}
