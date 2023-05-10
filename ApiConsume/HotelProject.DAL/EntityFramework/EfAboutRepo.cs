using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer;

namespace HotelProject.DAL.EntityFramework;

public class EfAboutRepo : GenericRepo<About>, IAboutRepo
{
    public EfAboutRepo(DataContext context) : base(context)
    {
    }
}