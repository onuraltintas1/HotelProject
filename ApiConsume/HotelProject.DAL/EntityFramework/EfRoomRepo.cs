using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer;

namespace HotelProject.DAL.EntityFramework;

public class EfRoomRepo : GenericRepo<Room> , IRoomRepo
{
    public EfRoomRepo(DataContext context) : base(context)
    {
    }
}