using CMS.DocumentEngine.Types.Kentico;
using CMS.Localization;
using Kentico.Models.Home;
using System.Linq;

namespace Kentico.IRepository.Implementation
{
    public class DoctorRepo : IDoctorRepo
    {
        public DoctorViewModel GetDoctorViewModel()
        {
            DoctorSection Page = DoctorSectionProvider.GetDoctorSections().Published().
                                                       OnSite("Kentico")
                                                      .Culture(LocalizationContext.CurrentCulture.CultureCode)
                                                      .FirstOrDefault();

            if (Page != null)
            {
                return new DoctorViewModel()
                {                
                    Title = Page.Title  

                };
            }
            return null;
        }
    }
}