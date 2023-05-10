using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto;

public class UpdateRoomDto
{
    [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
    public string RoomNumber { get; set; }
    public string RoomCoverImage { get; set; }
    [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
    public int Price { get; set; }
    [Required(ErrorMessage = "Lütfen banyo bilgisi giriniz")]
    public string Title { get; set; }
    public string BedCount { get; set; }
    public string BathCount { get; set; }
    public string Wifi { get; set; }
    public string Description { get; set; }

}