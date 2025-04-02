using Microsoft.AspNetCore.Mvc.Rendering;

namespace planMyMDVisit.Models.ViewModels
{
    public class SelectItemViewModel
    {
        public string SelectedDoctor {  get; set; }

        public List<SelectListItem> SpecialtySelectList { get; set; }
    }
}
