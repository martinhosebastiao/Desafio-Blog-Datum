using Blog.Application.UseCases.Abstractions;
using Blog.Domain.Entities;

namespace Blog.Application.UseCases.Implementations
{
    public class RegisterUserUseCase: IRegisterUserUseCase
    {
		public RegisterUserUseCase()
		{
		}

        public Task<User> RegisterAsync(
            string usernamme,
            string password,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

