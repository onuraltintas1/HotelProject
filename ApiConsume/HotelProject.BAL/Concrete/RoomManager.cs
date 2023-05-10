using HotelProject.BAL.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer;

namespace HotelProject.BAL.Concrete;

public class RoomManager : IRoomService
{
    private readonly IRoomRepo _roomRepo;

    public RoomManager(IRoomRepo roomRepo)
    {
        _roomRepo = roomRepo;
    }

    public void TInsert(Room t)
    {
        _roomRepo.Insert(t);
    }

    public void TDelete(Room t)
    {
        _roomRepo.Delete(t);
    }

    public void TUpdate(Room t)
    {
       _roomRepo.Update(t);
    }

    public List<Room> TGetList()
    {
        return _roomRepo.GetList();
    }

    public Room TGetById(int id)
    {
        return _roomRepo.GetById(id);
    }
}