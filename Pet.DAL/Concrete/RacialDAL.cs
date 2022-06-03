using Pet.DAL.Abstract;
using Pet.Entities.Concrete;
using Pet.Entities.Context;

namespace Pet.DAL.Concrete
{
    public class RacialDAL : RepositoryBase<Racial, SqlDbContext>, IRacialDAL
    {
    }
}
