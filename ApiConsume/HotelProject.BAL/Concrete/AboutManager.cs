using HotelProject.BAL.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer;

namespace HotelProject.BAL.Concrete;


public class AboutManager : IAboutService
{

    private readonly IAboutRepo _aboutRepo;

    public AboutManager(IAboutRepo aboutRepo)
    {
        _aboutRepo = aboutRepo;
    }

    public void TInsert(About t)
    {
        _aboutRepo.Insert(t);
    }

    public void TDelete(About t)
    {
        _aboutRepo.Delete(t);
    }

    public void TUpdate(About t)
    {
        _aboutRepo.Update(t);
    }

    public List<About> TGetList()
    {
        return _aboutRepo.GetList();
    }

    public About TGetById(int id)
    {
        return  _aboutRepo.GetById(id);
    }
}