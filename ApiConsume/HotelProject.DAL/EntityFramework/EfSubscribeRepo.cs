using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer;

namespace HotelProject.DAL.EntityFramework;

public class EfSubscribeRepo : GenericRepo<Subscribe> , ISubscribeRepo
{
    public EfSubscribeRepo(DataContext context) : base(context)
    {
    }
}