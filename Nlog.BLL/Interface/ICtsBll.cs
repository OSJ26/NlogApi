using Nlog.MOl;

namespace Nlog.BLL.Interface
{
    public interface ICtsBll
    {
        Task<List<CTSD01>> GetAll();
    }
}
