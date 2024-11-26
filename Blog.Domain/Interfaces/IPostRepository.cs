using Blog.Domain.Entities;

namespace Blog.Domain.Interfaces
{
    public interface IPostRepository
	{
        Task<Post> CreatePostAsync(
            Post post, CancellationToken cancellationToken = default);

        Task<Post?> GetPostByIdAsync(
            int id, CancellationToken cancellationToken = default);

        Task<List<Post>> GetAllPostsAsync(
            CancellationToken cancellationToken = default);

        Task<Post?> UpdatePostAsync(
            Post post, CancellationToken cancellationToken);

        Task<bool> DeletePostAsync(
            int id, CancellationToken cancellationToken);
    }
}

