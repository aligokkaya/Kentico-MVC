using Kentico.IRepository;
using Kentico.IRepository.Implementation;
using Kentico.Models.Home;
using System.Web.Mvc;

namespace Kentico.Controllers
{
    
    public class DoctorController : Controller
    {
        private readonly IDoctorRepo mDoctorRepo;
        public DoctorController(IDoctorRepo homeDoctorRepo)
        {
            mDoctorRepo = homeDoctorRepo;
        }

        // GET: Doctor

       
        public ActionResult Index()
        {
            DoctorViewModel model = mDoctorRepo.GetDoctorViewModel();


            return View(model);
        }

      
    }
}