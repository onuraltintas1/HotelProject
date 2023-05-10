using HotelProject.BAL.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer;

namespace HotelProject.BAL.Concrete;

public class StaffManager : IStaffService
{
    private readonly IStaffRepo _staffRepo;

    public StaffManager(IStaffRepo staffRepo)
    {
        _staffRepo = staffRepo;
    }

    public void TInsert(Staff t)
    {
        _staffRepo.Insert(t);
    }

    public void TDelete(Staff t)
    {
        _staffRepo.Delete(t);
    }

    public void TUpdate(Staff t)
    {
        _staffRepo.Update(t);
    }

    public List<Staff> TGetList()
    {
        return _staffRepo.GetList();
    }

    public Staff TGetById(int id)
    {
        return _staffRepo.GetById(id);
    }
}