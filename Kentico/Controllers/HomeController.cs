using System.Web.Mvc;
using Kentico.IRepository;
using Kentico.Models.Home;

namespace Kentico.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepo mHomeRepo;
        public HomeController(IHomeRepo homeRepo)
        {
            mHomeRepo = homeRepo;
        }
        // GET: Home
        public ActionResult Index()
        {

            HomeViewModel model = mHomeRepo.GetHomeViewModel();

            // Uncomment and optionally adjust the document query sample when using Page builder on the Home page
            // See ~/App_Start/ApplicationConfig.cs, ~/Views/Shared/_Layout.cshtml and ~/Views/Home/Index.cshtml
            // In the administration UI, create a Page type and set its
            //   URL pattern = '/Home'
            //   Use Page tab = True
            // In the administration UI, create a Page utilizing the new Page type

            //TreeNode page = DocumentHelper.GetDocuments().Path("/Home").OnCurrentSite().TopN(1).FirstOrDefault();
            //if (page == null)
            //{
            //    return HttpNotFound();
            //}

            //HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            return View(model);
        }
    }
}