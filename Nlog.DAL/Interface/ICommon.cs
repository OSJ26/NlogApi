namespace Nlog.DAL.Interface
{
    public interface ICommon<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
