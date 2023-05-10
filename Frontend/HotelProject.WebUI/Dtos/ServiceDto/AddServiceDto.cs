using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto;

public class AddServiceDto
{
    [Required(ErrorMessage = "Hizmet ikon linkini giriniz!")]
    public string Icon { get; set; }
    
    public string Content { get; set; }
    [Required(ErrorMessage = "Hizmet başlığı giriniz!")]
    public string Title { get; set; }
}