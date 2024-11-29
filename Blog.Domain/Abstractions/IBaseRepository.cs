﻿using Blog.Intenal.Domains.Core.Results;

namespace Blog.Intenal.Domains.Core.Abstractions
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<CustomResult> GetsAsync(CancellationToken cancellationToken);
        Task<CustomResult> GetByIdAsync<T>(T id, CancellationToken cancellationToken);
        Task<CustomResult> GetQueryableAsync();
        Task<CustomResult> CreateAsync(TEntity obj, CancellationToken cancellationToken);
        Task<CustomResult> UpdateAsync(TEntity obj, CancellationToken cancellationToken);
        Task<CustomResult> DeleteAsync(TEntity obj, CancellationToken cancellationToken);
    }
}

