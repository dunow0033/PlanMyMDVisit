using Microsoft.AspNetCore.Mvc.Rendering;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Models.ViewModels
{
    public class PatientEventsViewModel
    {
            public List<Doctor> Doctors { get; set; }
            public string SelectedSpecialty { get; set; }
            public List<SelectListItem> SpecialtyListItems { get; set; }
    }
}
