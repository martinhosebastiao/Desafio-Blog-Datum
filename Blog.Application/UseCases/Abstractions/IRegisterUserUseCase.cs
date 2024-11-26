using Blog.Domain.Entities;

namespace Blog.Application.UseCases.Abstractions
{
    public interface IRegisterUserUseCase
	{
		Task<User> RegisterAsync(
			string usernamme,
			string password,
			CancellationToken cancellationToken);
	}
}

