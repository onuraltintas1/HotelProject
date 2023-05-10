using HotelProject.BAL.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer;

namespace HotelProject.BAL.Concrete;

public class ServiceManager : IServiceService
{
    private readonly IServiceRepo _serviceRepo;

    public ServiceManager(IServiceRepo serviceRepo)
    {
        _serviceRepo = serviceRepo;
    }

    public void TInsert(Service t)
    {
        _serviceRepo.Insert(t);
    }

    public void TDelete(Service t)
    {
        _serviceRepo.Delete(t);
    }

    public void TUpdate(Service t)
    {
        _serviceRepo.Update(t);
    }

    public List<Service> TGetList()
    {
        return _serviceRepo.GetList();
    }

    public Service TGetById(int id)
    {
        return _serviceRepo.GetById(id);
    }
}