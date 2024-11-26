using System;
using Blog.Domain.Entities;

namespace Blog.Application.UseCases.Abstractions
{
	public interface ILoginUseCase
	{
        Task<User> LoginAsync(
            string usernamme,
            string password,
            CancellationToken cancellationToken);
    }
}

