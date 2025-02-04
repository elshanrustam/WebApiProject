﻿using Api.Application.Interfaces.Repositories;
using Api.Domain.Common;

namespace Api.Application.Interfaces.UnitOfWorks;

public interface IUnitOfWork : IAsyncDisposable
{
    IReadRepository<T> GetReadRepository<T>() where T : class, IBaseEntity, new();
    IWriteRepository<T> GetWriteRepository<T>() where T : class, IBaseEntity, new();
    Task<int> SaveAsync();
    int Save();
}
