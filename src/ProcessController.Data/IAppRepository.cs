using ProcessController.Domain;

namespace ProcessController.Data.Repositories
{
    public interface IAppRepository : IRepository<IApp, AppId>
    {
    }
}