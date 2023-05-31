using Microsoft.Extensions.Configuration;
using Nlog.DAL.Interface;
using Nlog.MOl;
using ServiceStack.OrmLite;

namespace Nlog.DAL.Servcie
{
    public class sCtsd01 : IProGet
    {
        #region private members
        private readonly IConfiguration _objConfig;
        private readonly OrmLiteConnectionFactory _objConnection;
        #endregion

        #region Initalization
        public sCtsd01(IConfiguration config)
        { 
            _objConfig = config;
            _objConnection = new OrmLiteConnectionFactory(_objConfig.GetConnectionString("MyAsset"),MySqlDialect.Provider);
        }
        #endregion

        #region Get Method
        /// <summary>
        /// GetCtsdAsync method fetch 
        /// data from the database
        /// </summary>
        /// <returns>data from the db</returns>
        public async Task<List<CTSD01>> GetCtsdAsync()
        {
            using (var db = _objConnection.Open())
            {
                var data = await db.SelectAsync<CTSD01>();
                return data;
            }
        }
        #endregion
    }
}
