

using HotelProject.BAL.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer;

namespace HotelProject.BAL.Concrete;

public class BookingManager : IBookingService
{
    private IBookingRepo _service;

    public BookingManager(IBookingRepo service)
    {
        _service = service;
    }

    public void TInsert(Booking t)
    {
        _service.Insert(t);
    }

    public void TDelete(Booking t)
    {
        _service.Delete(t);
    }

    public void TUpdate(Booking t)
    {
        _service.Update(t);
    }

    public List<Booking> TGetList()
    {
        return _service.GetList();
    }

    public Booking TGetById(int id)
    {
        return _service.GetById(id); 
    }

    public void TBookingStatusChangeApproved(Booking booking)
    {
        _service.BookingStatusChangeApproved(booking);
    }

    public void BookingStatusChangeApproved2(int id)
    {
        _service.BookingStatusChangeApproved2(id);
    }
}