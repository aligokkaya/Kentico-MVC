using Kentico.IRepository;
using Kentico.Models.Home;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Kentico.Controllers
{
    public class DoctorlarController : Controller
    {
        private readonly IDoctorlarRepo mDoctorlarRepo;
        public DoctorlarController(IDoctorlarRepo homeDoctorRepo)
        {
            mDoctorlarRepo = homeDoctorRepo;
        }
        // GET: Doctorlar
        public ActionResult Index()
        {
            List<DoctorlarViewModel> model =  mDoctorlarRepo.GetDoctorlarViewModel();
        

            return View(model);
        }
       

    }
}