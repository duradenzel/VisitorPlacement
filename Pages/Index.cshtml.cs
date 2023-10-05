using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VisitorPlacementLogic;
using VisitorPlacementModels;

namespace VisitorPlacement.Pages
{
    public class IndexModel : PageModel
    {
        public List<Section> Sections { get; set; }

        public void OnGet()
        {
            var _seatingService = new SeatingService();
            Sections = _seatingService.GenerateEventSeating();
        }
    }
}