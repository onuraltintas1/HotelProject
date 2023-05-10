using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer;

namespace HotelProject.DAL.EntityFramework;

public class EfTestimonialRepo : GenericRepo<Testimonial> , ITestimonialRepo
{
    public EfTestimonialRepo(DataContext context) : base(context)
    {
    }
}