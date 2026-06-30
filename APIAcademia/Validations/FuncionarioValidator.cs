using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(x => x.NomeCompleto)
                .Length(2, 60).WithMessage("O nome deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Nome esta em branco");

            RuleFor(x => x.Email)
               .Length(2, 70).WithMessage("O emai deve conter entre 2 a 70 caracteres")
               .EmailAddress().WithMessage("e-mail invalido")
               .NotEmpty().WithMessage("e-mail em branco");

            RuleFor(x => x.Senha)
                .NotEmpty().WithMessage("Senha e obrigatoria")
                .MinimumLength(6).WithMessage("A senha deve ter no mínimo 6 caracteres")
                .Matches(@"[A-Z]").WithMessage("A senha deve ter ao menos uma letra maiúscula")
                .Matches(@"[0-9]").WithMessage("A senha deve ter ao menos um numero")
                .Matches(@"[\W_]").WithMessage("A senha deve ter ao menos um caracter especial");

            RuleFor(x => x.CPF)
                .Length(11, 11).WithMessage("O cpf deve ter 11 caracteres")
                .NotEmpty().WithMessage("O cpf esta em branco");

            RuleFor(x => x.RG)
                .Length(8, 8).WithMessage("O rg deve ter 8 caracteres")
                .NotEmpty().WithMessage("O rg esta em branco");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("Data de nascimento em branco")
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage("A data de nascimento deve ser menor que hoje.");

            RuleFor(x => x.NomePai)
                .Length(2, 60).WithMessage("O nome do pai deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Nome do pai esta em branco");

            RuleFor(x => x.NomeMae)
                .Length(2, 60).WithMessage("O nome da mãe deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Nome da mãe esta em branco");

            RuleFor(x => x.Pis)
                .Length(11, 11).WithMessage("O pis deve ter 11 caracteres")
                .NotEmpty().WithMessage("o pis esta em branco");

            RuleFor(x => x.Salario)
                .GreaterThan(0).WithMessage("O valor não pode ser zero")
                .PrecisionScale(18, 2, false).WithMessage("O preço deve conter duas casas decimais");

            RuleFor(x => x.SalarioHora)
                .GreaterThan(0).WithMessage("O valor não pode ser zero")
                .PrecisionScale(18, 2, false).WithMessage("O preço deve conter duas casas decimais");

            RuleFor(x => x.Cargo)
                .Length(2, 60).WithMessage("O cargo deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("cargo esta em branco");

            RuleFor(x => x.DataAdmissao)
                .NotEmpty().WithMessage("Data de admissão em branco");

            RuleFor(x => x.CaminhoFoto)
                .Length(2, 500);

            RuleFor(x => x.UnidadeId)
                .NotNull().WithMessage("O funcionario deve pertencer a uma unidade");


        }
    }
}
