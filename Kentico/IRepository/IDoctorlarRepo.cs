using Kentico.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentico.IRepository
{
   public interface IDoctorlarRepo : IRepositoryBase
    {
        List<DoctorlarViewModel> GetDoctorlarViewModel();
    }
}
