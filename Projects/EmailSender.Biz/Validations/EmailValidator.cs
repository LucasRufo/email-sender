using EmailSender.Entities.Models;
using FluentValidation;
using System.Text.RegularExpressions;

namespace EmailSender.Biz.Validations
{
    public class EmailValidator : AbstractValidator<EmailDTO>
    {
        public EmailValidator()
        {
            RuleFor(m => m.To)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser preenchido")
                .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(m => m.Assunto)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser preenchido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(m => m.Corpo)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser preenchido")
                .Length(2, int.MaxValue).WithMessage("O campo {PropertyName} precisa ter no mínimo {MinLength} caracteres");

            RuleFor(m => m.To).Custom((email, context) =>
            {
                string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

                if (!Regex.IsMatch(email, pattern))
                    context.AddFailure("To", "Email Inválido");
            });  
        }
    }
}
