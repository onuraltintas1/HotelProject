using HotelProject.EntityLayer;

namespace HotelProject.DAL.Abstract;

public interface IBookingRepo : IGenericRepo<Booking>
{
    void BookingStatusChangeApproved(Booking booking);
    void BookingStatusChangeApproved2(int id);
}