using Blog.Domain.Entities;
using Blog.Domain.Interfaces;

namespace Blog.Application.UseCases
{
    public class CreatePostUseCase
    {
        private readonly IPostRepository _postRepository;

        public CreatePostUseCase(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Post> Execute(
            Post post, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(post.Title) ||
                string.IsNullOrEmpty(post.Content))
            {
                throw new ArgumentException(
                    "Título e conteúdo são obrigatórios.");
            }

            return await _postRepository.CreatePostAsync(
                post, cancellationToken);
        }
    }
}

