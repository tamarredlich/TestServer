using Microsoft.AspNetCore.Mvc;
using TestServer.BussinesLogic;

namespace TestServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentDataController : ControllerBase
    {
        public ContentDataController()
        {
        }

        [HttpPost]
        [Route("GetAllData")]
        public ActionResult<string[]> GetAllData()
        {
            //try
            //{
            //var proxyResult = await proxyBL.PostAsync<ProxyResponse>(this.Request.Path, requestData, this.Request);
            string[] res = { "Yossi", "Tammi", "Ayelet" };
                return Ok(res);

            //}
            //catch (Exception ex)
            //{
            //    ProxyResponse erorResponse = new ProxyResponse
            //    {
            //        IsError = true,
            //        ErrorMessage = "Server Error"
            //    };

            //    return Ok(erorResponse);
            //}

        }

    }
}
