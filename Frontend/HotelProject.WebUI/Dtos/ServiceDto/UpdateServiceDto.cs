using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto;

public class UpdateServiceDto
{
    public int ServiceId { get; set; }
    [Required(ErrorMessage = "Hizmet ikon linkini giriniz!")]
    public string Icon { get; set; }
    [Required(ErrorMessage = "Hizmet açıklaması giriniz!")]
    public string Content { get; set; }
    [Required(ErrorMessage = "Hizmet başlığı giriniz!")]
    public string Title { get; set; }
}