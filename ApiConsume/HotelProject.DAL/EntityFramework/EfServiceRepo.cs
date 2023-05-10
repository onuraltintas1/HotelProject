using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;

namespace HotelProject.DAL.EntityFramework;

public class EfServiceRepo: GenericRepo<EntityLayer.Service> , IServiceRepo
{
    public EfServiceRepo(DataContext context) : base(context)
    {
    }
}

