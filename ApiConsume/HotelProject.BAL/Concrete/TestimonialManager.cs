using HotelProject.BAL.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer;

namespace HotelProject.BAL.Concrete;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialRepo _testimonialRepo;

    public TestimonialManager(ITestimonialRepo testimonialRepo)
    {
        _testimonialRepo = testimonialRepo;
    }

    public void TInsert(Testimonial t)
    {
        _testimonialRepo.Insert(t);
    }

    public void TDelete(Testimonial t)
    {
        _testimonialRepo.Delete(t);
    }

    public void TUpdate(Testimonial t)
    {
        _testimonialRepo.Update(t);
    }

    public List<Testimonial> TGetList()
    {
        return _testimonialRepo.GetList();
    }

    public Testimonial TGetById(int id)
    {
        return _testimonialRepo.GetById(id);
    }
}