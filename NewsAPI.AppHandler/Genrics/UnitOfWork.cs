﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsAPI.Domain.AppEntity;
using NewsAPI.Infastrcture;

namespace NewsAPI.AppHandler.Genrics
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private Hashtable Repo;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Repo = new Hashtable();
        }

        public async Task<int> CompleteAsync()
            => await _dbContext.SaveChangesAsync();

        public ValueTask DisposeAsync()
        => _dbContext.DisposeAsync();

        public IGenricRepo<T> Repository<T>() where T : BaseEntity
        {
            var type = typeof(T).Name;
            if (!Repo.ContainsKey(type))
            {
                var repository = new GenricRepo<T>(_dbContext);
                Repo.Add(type, repository);
            }
            return (IGenricRepo<T>)Repo[type]!;
        }

        public void Detach<T>(T entity) where T : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }
    }
}
