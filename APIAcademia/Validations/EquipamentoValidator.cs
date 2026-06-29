using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class EquipamentoValidator : AbstractValidator<Equipamento>
    {
        public EquipamentoValidator()
        {
            RuleFor(x => x.Nome)
                .Length(2, 60).WithMessage("O nome deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Nome do usuario em branco");

            RuleFor(x => x.UnidadeId)
                .NotNull().WithMessage("O equipamento deve pertencer a uma unidade");
        }
    }
}
