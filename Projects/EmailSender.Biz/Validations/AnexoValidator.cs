using EmailSender.Entities.Models;
using FluentValidation;

namespace EmailSender.Biz.Validations
{
    public class AnexoValidator : AbstractValidator<AnexoDTO>
    {
        public AnexoValidator()
        {
            RuleFor(m => m.NomeArquivo)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser preenchido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
