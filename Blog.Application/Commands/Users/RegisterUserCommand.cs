using System;
using System.ComponentModel.DataAnnotations;
using Blog.Intenal.Domains.Core.Results;
using Blog.Internal.Applications.Core.Abstractions;
using Blog.Internal.Applications.Core.Commands.Posts;

namespace Blog.Internal.Applications.Commands.Users
{
	public class RegisterUserCommand : ICommand<CustomResult>
    {
        [Required]
        public string UserName { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;

        public sealed class RegisterUserCommandHandler :
            ICommandHandler<RegisterUserCommand, CustomResult>
        {
            public Task<CustomResult> HandlerAsync(
                RegisterUserCommand command,
                CancellationToken cancellationToken = default)
            {
                throw new NotImplementedException();
            }
        }
    }
}

