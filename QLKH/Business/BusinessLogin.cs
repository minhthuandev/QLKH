using QLKH.App_Data;
using QLKH.Core;
using QLKH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLKH.Business
{
    public class BusinessLogin
    {
        protected static BusinessLogin _instance;
        public static BusinessLogin Instance
        {
            get
            {
                _instance = _instance != null ? _instance : new BusinessLogin();
                return _instance;
            }
        }
        static BusinessLogin() { }

        public LoginDTO UserLogin(string username, string password)
        {
            LoginDTO response = new LoginDTO();
            try
            {
                using (var _db = new QLKHEntities())
                {
                    var user = _db.Users.Where(o => o.Username == username && o.Password == password && o.IsDelete == false)
                        .Join(_db.Roles, u => u.RoleID, r => r.ID, (u, r) => new { u, r }).FirstOrDefault();
                    if (user != null)
                    {
                        response.Success = true;
                        response.Name = user.u.Username;
                        response.Role = user.r.Name;
                        response.Code = user.r.Code;
                    }
                    else
                    {
                        response.Message = "Username or password is incorrect.";
                        response.Caption = "Login failed!";
                        response.MessageButton = MessageBoxButton.OK;
                        response.MessageImage = MessageBoxImage.Warning;
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Caption = "Error!";
                response.MessageButton = MessageBoxButton.OK;
                response.MessageImage = MessageBoxImage.Error;
            }
            return response;
        }
    }
}
