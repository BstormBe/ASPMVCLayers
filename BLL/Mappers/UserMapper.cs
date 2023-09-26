using BLL.Forms;
using BLL.ViewModel;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class UserMapper
    {

        public static UserViewModel ToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Username = user.Username
            };
        }

        public static User ToUser(this UserForms userForm)
        {
            return new User
            {
                Id = 0,
                CreationDate = DateTime.Now,
                Firstname = userForm.Firstname,
                Lastname = userForm.Lastname,
                Username = userForm.Username,
                Password = userForm.Password
            };
        }


    }
}
