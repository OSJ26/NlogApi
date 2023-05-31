using Nlog.BLL.Interface;
using Nlog.DAL.Interface;
using Nlog.MOl;

namespace Nlog.BLL.Servcie
{
    public class sCtsBll : ICtsBll
    {
        #region private members
        private readonly IProGet _objGet;
        #endregion

        #region Inisialization
        public sCtsBll(IProGet proGet)
        { 
            _objGet = proGet;
        }
        #endregion

        #region BL Method
        /// <summary>
        /// Method which call Dal method
        /// </summary>
        /// <returns>Return the list send by Dal</returns>
        public Task<List<CTSD01>> GetAll()
        {
            try
            {
                return _objGet.GetCtsdAsync();
            }
            catch
            {
                throw;
            }
        }
        #endregion


   
    }
}
