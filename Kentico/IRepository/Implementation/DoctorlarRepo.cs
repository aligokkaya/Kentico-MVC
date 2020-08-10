using CMS.DocumentEngine.Types.Kentico;
using CMS.Localization;
using Kentico.Models.Home;
using System.Collections.Generic;

namespace Kentico.IRepository.Implementation
{
    public class DoctorlarRepo : IDoctorlarRepo
    {
        public List<DoctorlarViewModel> GetDoctorlarViewModel()
        {
           IEnumerable <Doctor> doctors = DoctorProvider.GetDoctors().Published().OnSite("Kentico")
                                                    .Culture(LocalizationContext.CurrentCulture.CultureCode);
                                                      

            if (doctors != null)
            {
                List<DoctorlarViewModel> _returnList = new List<DoctorlarViewModel>();
                foreach(var Item in doctors)
                {
                    _returnList.Add(new DoctorlarViewModel()
                    {
                       FirstName = Item.FirstName,
                       LastName = Item.LastName,
                       Degree =Item.Degree,
                       Photo = Item.Photo,
                       Bio = Item.Bio,
                       EmergencyShift=Item.EmergencyShift,
                       Speciality=Item.Speciality

                    });

                }
                return _returnList;
            }
            return null;
        }
    }
}