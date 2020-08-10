using Kentico.Models.Home;

namespace Kentico.IRepository
{
    public interface IHomeRepo : IRepositoryBase
    {
        HomeViewModel GetHomeViewModel();

    }
}
