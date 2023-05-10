using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer;

namespace HotelProject.DAL.EntityFramework;

public class EfStaffRepo : GenericRepo<Staff> , IStaffRepo
{
    public EfStaffRepo(DataContext context) : base(context)
    {
    }
}