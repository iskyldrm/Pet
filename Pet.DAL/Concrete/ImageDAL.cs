using Pet.DAL.Abstract;
using Pet.Entities.Concrete;
using Pet.Entities.Context;

namespace Pet.DAL.Concrete
{
    public class ImageDAL : RepositoryBase<Image, SqlDbContext>, IImageDAL
    {
    }
}
