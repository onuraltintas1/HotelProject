using AutoMapper;
using HotelProject.EntityLayer;
using HotelProject.WebUI.Dtos;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<ResultServiceDto, Service>().ReverseMap();
        CreateMap<UpdateServiceDto, Service>().ReverseMap();
        CreateMap<AddServiceDto, Service>().ReverseMap();
        CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
        CreateMap<LoginUserDto, AppUser>().ReverseMap();
        CreateMap<ResultAboutDto, About>().ReverseMap();
        CreateMap<ResultRoomDto, Room>().ReverseMap();
        CreateMap<ResultStaffDto, Staff>().ReverseMap();
        CreateMap<ResultTestimonialDto, Staff>().ReverseMap();
        CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
        CreateMap<CreateBookingDto, Booking>().ReverseMap();
        CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
    }
}