using HotelProject.EntityLayer;

namespace HotelProject.BAL.Abstract;

public interface IBookingService : IGenericService<Booking>
{
    void TBookingStatusChangeApproved(Booking booking);
    void BookingStatusChangeApproved2(int id);

}