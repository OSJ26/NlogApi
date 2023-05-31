using Nlog.MOl;

namespace Nlog.DAL.Interface
{
    public interface IProGet
    {
        Task<List<CTSD01>> GetCtsdAsync();
    }
}
