# Email Sender :e-mail:

Construí esse projeto com o instuito de aperfeiçoar meus conhecimentos em WebAPI com .NET framework e aprender como funciona o envio de email em C#. Todos os emails enviados são salvos em um banco de dados SQL Server. :computer:

### Rotas

- __GET:__ api/email
- __GET:__ api/email/id
- __POST:__ api/email

### Ferramentas e Bibliotecas

- .NET Framework
- SQL Server
- Fluent Validation - Para montar a validação dos modelos
- Entity Framework - Para a conexão com o banco de dados
- Simple Injector - Para o container de injeção de dependência

### Para rodar o projeto

Substitua as strings nos seguintes lugares: 
- Conexão com o banco de dados na classe Context no projeto EmailSender.Data
- Conexão com o email do Gmail na classe EmailService no projeto EmailSender.Biz
