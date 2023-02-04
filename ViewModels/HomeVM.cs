using NEWSOFT.Models;

namespace NEWSOFT.ViewModels;

public class HomeVM
{
    public List<About> Abouts { get; set; }
    public List<Slider> Sliders { get; set; }
    public Who Who { get; set; }
    public List<Feature> Features { get; set; }

}