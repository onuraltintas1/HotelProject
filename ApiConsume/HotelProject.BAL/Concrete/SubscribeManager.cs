using HotelProject.BAL.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer;

namespace HotelProject.BAL.Concrete;

public class SubscribeManager : ISubscribeService
{
    private readonly ISubscribeRepo _subscribeRepo;

    public SubscribeManager(ISubscribeRepo subscribeRepo)
    {
        _subscribeRepo = subscribeRepo;
    }

    public void TInsert(Subscribe t)
    {
        _subscribeRepo.Insert(t);
    }

    public void TDelete(Subscribe t)
    {
        _subscribeRepo.Delete(t);

    }
    public void TUpdate(Subscribe t)
    {
        _subscribeRepo.Update(t);

    }
    public List<Subscribe> TGetList()
    {
       return _subscribeRepo.GetList();
    }

    public Subscribe TGetById(int id)
    {
        return _subscribeRepo.GetById(id);
    }
}