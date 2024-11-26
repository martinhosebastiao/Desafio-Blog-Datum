using System;
using Blog.Domain.Entities;
using Blog.Domain.Interfaces;

namespace Blog.Infrastructure.Repositories
{
	public class PostRepository: IPostRepository
	{
		public PostRepository()
		{
		}

        public Task<List<Post>> GetAllPostsAsync(
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Post?> GetPostByIdAsync(
            int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Post> CreatePostAsync(
            Post post, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Post?> UpdatePostAsync(
            Post post, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(
            int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        } 
    }
}

