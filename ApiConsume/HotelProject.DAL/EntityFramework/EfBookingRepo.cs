using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer;

namespace HotelProject.DAL.EntityFramework;

public class EfBookingRepo : GenericRepo<Booking>, IBookingRepo
{
    public EfBookingRepo(DataContext context) : base(context)
    {
    }

    public void BookingStatusChangeApproved(Booking booking)
    {
        var context = new DataContext();
        var values = context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
        values.Status = "Onaylandı";
        context.SaveChanges();

    }

    public void BookingStatusChangeApproved2(int id)
    {
        var context = new DataContext();
        var values = context.Bookings.Find(id);
        values.Status = "Onaylandı";
        context.SaveChanges();
    }
}