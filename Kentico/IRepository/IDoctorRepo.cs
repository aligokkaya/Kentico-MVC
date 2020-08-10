

using Kentico.Models.Home;

namespace Kentico.IRepository
{
    public interface IDoctorRepo : IRepositoryBase
    {
        //DoctorViewModel GetHomeViewModel();
        DoctorViewModel GetDoctorViewModel();
    }
}
