using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class UnidadeValidator : AbstractValidator<Unidade>
    {
        public UnidadeValidator()
        {
            RuleFor(x => x.NomeFatasia)
               .Length(2, 60).WithMessage("O nome fantasia Deve conter entre 2 a 60 caracteres")
               .NotEmpty().WithMessage("Nome fantasia em branco");

            RuleFor(x => x.Endereco)
               .Length(2, 100).WithMessage("O endereço deve conter entre 2 a 100 caracteres")
               .NotEmpty().WithMessage("O endereço está em branco");

            RuleFor(x => x.Cep)
               .Length(8, 8).WithMessage("O CEP Deve conter 8 caracteres")
               .NotEmpty().WithMessage("CEP em branco");

            RuleFor(x => x.Numero)
               .Length(1, 20).WithMessage("O numero deve conter entre 1 a 20 caracteres")
               .NotEmpty().WithMessage("Numero em branco");

            RuleFor(x => x.Cnpj)
               .Length(14, 14).WithMessage("O CNPJ Deve conter 14 caracteres")
               .NotEmpty().WithMessage("CNPJ em branco");
        }
    }
}
