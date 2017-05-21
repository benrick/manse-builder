using ManseBuilder.Core.Model;
using System.Collections.Generic;

namespace ManseBuilder.Core.DataAccess
{
    public interface IRepository<T>
        where T : BaseAggregate
    {
        List<T> GetAll();
        void SaveAll(List<T> entities);
    }
}