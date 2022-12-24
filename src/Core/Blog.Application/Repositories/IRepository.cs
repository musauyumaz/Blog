﻿using Blog.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Blog.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
