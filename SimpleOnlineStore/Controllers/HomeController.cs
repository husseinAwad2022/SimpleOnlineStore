using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using SimpleOnlineStore.Database_Connection;

namespace SimpleOnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public HomeController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("viewProducts")]
        public string allProducts()
        {
            var AllProducts = _databaseContext.Product.ToList();
            JavaScriptSerializer JsData = new JavaScriptSerializer();
            JsData.MaxJsonLength = int.MaxValue;
            string Result = JsData.Serialize(AllProducts);
            return Result;
        }

        //[HttpGet]
        //[Route("viewOrders/{userID}")]
        //public string allProducts(string userID)
        //{
        //    var AllOrders = _databaseContext.Order.Single(order => order.UserID == int.Parse(userID));
        //    JavaScriptSerializer JsData = new JavaScriptSerializer();
        //    JsData.MaxJsonLength = int.MaxValue;
        //    string Result = JsData.Serialize(AllOrders);
        //    return Result;
        //}
    }
}
