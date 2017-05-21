using System.Collections.Generic;
using ManseBuilder.Core.DataAccess;
using ManseBuilder.Core.Model;

namespace ManseBuilder.Infrastructure.DataAccess
{
    public class JsonFileRepository<T> : IRepository<T>
        where T : BaseAggregate
    {
        public List<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void SaveAll(List<T> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}