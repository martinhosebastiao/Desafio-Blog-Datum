using Blog.Application.UseCases.Abstractions;
using Blog.Domain.Entities;
using Blog.Domain.Interfaces;

namespace Blog.Application.UseCases
{
    public class LoginUseCase: ILoginUseCase
	{
        private readonly IUserRepository _postRepository;

        public LoginUseCase(IUserRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Task<User> LoginAsync(
            string usernamme,
            string password,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

