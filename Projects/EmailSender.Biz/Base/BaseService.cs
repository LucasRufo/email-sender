using EmailSender.Entities.Shared;
using FluentValidation;

namespace EmailSender.Biz.Base
{
    public class BaseService
    {
        protected void ExecutarValidacao<Validator, Entity>(Validator validacao, Entity entidade, Return retorno) where Validator : AbstractValidator<Entity> where Entity : class
        {
            var validator = validacao.Validate(entidade);

            if (!validator.IsValid)
            {
                foreach (var error in validator.Errors)
                {
                    retorno.Handle(error.PropertyName, error.ErrorMessage);
                }
            }
        }
    }
}
