using System.Collections.Generic;
using ManseBuilder.Core.DataAccess;
using ManseBuilder.Core.Model;

namespace ManseBuilder.Infrastructure.DataAccess
{
    public class JsonFileManseRepository : IRepository<Manse>
    {
        public List<Manse> GetAll()
        {
            return new List<Manse>
            {
                new Manse
                {
                    Aspect = Aspect.Wood,
                    Demesne = new Demesne { Rating = 3},
                    Name = "Tabernacle of Fallen Leaves",
                    Rating = 3,
                },
                new Manse
                {
                    Aspect = Aspect.Water,
                    Demesne = new Demesne { Rating = 1},
                    Name = "Everfull Fountain",
                    Rating = 1,
                },
                new Manse
                {
                    Aspect = Aspect.Earth,
                    Demesne = new Demesne { Rating = 4},
                    Name = "Forge of the White Rose",
                    Rating = 4,
                },
            };
        }

        public void SaveAll(List<Manse> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}