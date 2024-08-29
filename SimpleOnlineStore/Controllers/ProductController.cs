using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Nancy.Json;
using SimpleOnlineStore.Database_Connection;
using SimpleOnlineStore.Models;

namespace SimpleOnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public ProductController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("getProduct/{productName}")]
        public string getProduct(string productName) 
        {
            var Product = _databaseContext.Product.Single(node => node.Name == productName);
            JavaScriptSerializer JsData = new JavaScriptSerializer();
            JsData.MaxJsonLength = int.MaxValue;
            string Result = JsData.Serialize(Product);
            return Result;
        }

        [HttpDelete]
        [Route("deleteProduct/{productID}")]
        public string DeleteProduct(string productID)
        {
            var product = new Product();
            product = _databaseContext.Product.Single(node => node.ID == int.Parse(productID));
            if (product != null)
            {
                _databaseContext.Product.Remove(product);
                _databaseContext.SaveChanges();
                return "Remove Product Successfully";
            }
            else
                return "NotFound";
        }

        [HttpPost]
        [Route("addProduct/{name}/{price}/{description}/{quantity}/{categoryID}")]
        public string addProduct(string name, string price, string description, string quantity, string categoryID) 
        {
            Product product = new Product();
            product.Name = name;
            product.Price = float.Parse(price);
            product.Description = description;
            product.StockQuantity = quantity;
            product.CategoryID = int.Parse(categoryID);
            _databaseContext.Product.Add(product);
            _databaseContext.SaveChanges();
            return "Add Product Successfully";
        }
    }
}
