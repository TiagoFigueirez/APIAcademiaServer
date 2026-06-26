using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class AlunoValidator : AbstractValidator<Aluno>
    {
        public AlunoValidator()
        {
            RuleFor(x => x.EMail)
               .Length(2, 70).WithMessage("O emai deve conter entre 2 a 70 caracteres")
               .EmailAddress().WithMessage("e-mail errado")
               .NotEmpty().WithMessage("e-mail em branco");

            RuleFor(x => x.Senha)
                .NotEmpty().WithMessage("Senha e obrigatoria")
                .MinimumLength(6).WithMessage("A senha deve ter no mínimo 6 caracteres")
                .Matches(@"[A-Z]").WithMessage("A senha deve ter ao menos uma letra maiúscula")
                .Matches(@"[0-9]").WithMessage("A senha deve ter ao menos um numero")
                .Matches(@"[\W_]").WithMessage("A senha deve ter ao menos um caracter especial");

            RuleFor(x => x.NomeCompleto)
                .Length(2, 60).WithMessage("O nome Deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Nome em branco");

            RuleFor(x => x.CPF)
                .Length(11, 11).WithMessage("O CPF Deve conter 11 caracteres")
                .NotEmpty().WithMessage("CPF em branco");

            RuleFor(x => x.RG)
                .Length(8, 8).WithMessage("O RG deve conter 8 caracteres")
                .NotEmpty().WithMessage("RG em branco");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("Data de nascimento em branco")
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage("A data de nascimento deve ser menor que hoje.");

            RuleFor(x => x.UnidadeId)
                .NotNull().WithMessage("O aluno deve pertencer a uma unidade");

        }
    }
}
