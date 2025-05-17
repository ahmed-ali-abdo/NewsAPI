﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAPI.Domain.AppEntity;

namespace NewsAPI.AppHandler.Genrics
{
    public interface IGenricRepo<T> where T : BaseEntity
    {
        Task<T> GetbyIdAsync(int id);

        Task<IEnumerable<T>> GetAllWithAsync();

        Task AddAsync(T item);

        void DeleteAsync(T item);

        void Update(T item);
    }
}
