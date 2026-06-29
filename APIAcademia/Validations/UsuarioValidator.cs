using APIAcademia.Model;
using FluentValidation;

namespace APIAcademia.Validations
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Nome)
                .Length(2, 60).WithMessage("O nome deve conter entre 2 a 60 caracteres")
                .NotEmpty().WithMessage("Nome do usuario em branco");

            RuleFor(x => x.Senha)
                .NotEmpty().WithMessage("Senha e obrigatoria")
                .MinimumLength(6).WithMessage("A senha deve ter no mínimo 6 caracteres")
                .Matches(@"[A-Z]").WithMessage("A senha deve ter ao menos uma letra maiúscula")
                .Matches(@"[0-9]").WithMessage("A senha deve ter ao menos um numero")
                .Matches(@"[\W_]").WithMessage("A senha deve ter ao menos um caracter especial");

            RuleFor(x => x.FuncionarioId)
                .NotNull().WithMessage("O usuário deve pertencer a um funcionario da academia");

            RuleFor(x => x.GrupoAcessoId)
                .NotNull().WithMessage("O usuário deve pertencer a um grupo");
        }
    }
}
