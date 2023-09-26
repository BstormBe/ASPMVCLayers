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

        public static UserViewModel toUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Username = user.Username
            };
        }


    }
}
