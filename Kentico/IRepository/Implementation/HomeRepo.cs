using CMS.DocumentEngine.Types.Kentico;
using CMS.Localization;
using Kentico.Models.Home;
using System.Linq;

namespace Kentico.IRepository.Implementation
{
    public class HomeRepo : IHomeRepo
    {
        public HomeViewModel GetHomeViewModel()
        {
            HomeSection Page = HomeSectionProvider.GetHomeSections().Published().
                                                        OnSite("Kentico")
                                                       .Culture(LocalizationContext.CurrentCulture.CultureCode)
                                                       .FirstOrDefault();

            if (Page!=null)
            {
                return new HomeViewModel()
                {
                   Name=Page.DocumentName,
                   Title = Page.Title,
                   Text = Page.Text,
                   Link = Page.Link

                };
            }
            return null;
                              
        }
    }
}