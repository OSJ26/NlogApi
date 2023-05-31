using Microsoft.AspNetCore.Mvc;
using Nlog.BLL.Interface;
using Nlog.PL.Interface;
using NLog;

namespace Nlog.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ctsd01Controller : ControllerBase
    {
        #region Bll Object
        private readonly ICtsBll _objBll;
        private readonly ILogger<Ctsd01Controller> _objLogger;
        #endregion

        #region Bll Object initailization
        public Ctsd01Controller(ICtsBll objBll,ILogger<Ctsd01Controller> log)
        {
            _objBll = objBll;
            _objLogger = log;
        }
        #endregion

        #region HttpGet Method
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>IActionResult 
        /// if : Data null then not found
        /// else : Status ok and send data
        /// </returns>
        [HttpGet]
        public IActionResult GetProduct()
        {
            try
            {

                var data = _objBll.GetAll();
                if (data == null)
                {
                    return NotFound();
                }
                _objLogger.LogInformation("Data Added Successfully");
                return Ok(data);
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
