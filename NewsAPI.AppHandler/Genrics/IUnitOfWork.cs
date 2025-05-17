using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAPI.Domain.AppEntity;

namespace NewsAPI.AppHandler.Genrics
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<int> CompleteAsync();

        IGenricRepo<T> Repository<T>() where T : BaseEntity;

        void Detach<T>(T entity) where T : BaseEntity;
    }
}
