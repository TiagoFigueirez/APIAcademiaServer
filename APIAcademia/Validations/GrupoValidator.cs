using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class GrupoValidator : AbstractValidator<Grupo>
    {
        public GrupoValidator()
        {
            RuleFor(x => x.Nome)
                .Length(2,60).WithMessage("O nome Deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("O nome está em branco");
        }
    }
}
