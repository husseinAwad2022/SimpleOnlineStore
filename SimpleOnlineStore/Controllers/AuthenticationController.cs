using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using SimpleOnlineStore.Database_Connection;
using SimpleOnlineStore.Models;

namespace SimpleOnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public AuthenticationController (DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpPost]
        [Route("sinup/{userName}/{password}/{email}/{phoneNumber}/{address}")]
        public string SignUpUser(string userName, string password, string email, string phoneNumber, string address)
        {
            User user = new User();
            user.UserName = userName;
            user.Password = password;
            user.Email = email;
            user.PhoneNumber = int.Parse(phoneNumber);
            user.Address = address;
            _databaseContext.User.Add(user);
            _databaseContext.SaveChanges();
            return "Add User Successfully";
        }

        [HttpGet]
        [Route("login/{email}/{password}")]
        public string LoginUser(string email, string password)
        { 
            var checkUser = from user in _databaseContext.User 
                            where user.Email == email && user.Password == password select user;

            if (checkUser != null)
            {
                JavaScriptSerializer JsData = new JavaScriptSerializer();
                JsData.MaxJsonLength = int.MaxValue;
                string Result = JsData.Serialize(checkUser);
                return Result;
            }
            else
                return "NotFound";
        }

        [HttpDelete]
        [Route("delete/{email}")]
        public string DeleteUser(string email) 
        {
            User user = new User();
            user = _databaseContext.User.Single(node => node.Email == email);
            if (user != null)
            {
                _databaseContext.User.Remove(user);
                _databaseContext.SaveChanges();
                return "Remove Account Successfully";
            }
            else
                return "NotFound";
        }

        [HttpPut]
        [Route("edit/{email}/{userName}/{phoneNumber}/{address}")]
        public string EditDataUser(string email, string userName, string phoneNumber, string address)
        {
            var user = new User();
            user = _databaseContext.User.Single(node => node.Email == email);
            if (user != null)
            {
                user.UserName = userName;
                user.PhoneNumber = int.Parse(phoneNumber);
                user.Address = address;
                _databaseContext.User.Update(user);
                _databaseContext.SaveChanges();
                return "Update Account Successfully";
            }
            else
                return "NotFound";
        }
    }
}
