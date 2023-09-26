using BLL.Forms;
using BLL.Mappers;
using BLL.ViewModel;
using DAL;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<UserViewModel> GetAll()
        {
            return _userRepository.GetAll().Select(x => x.ToUserViewModel()).ToList();
        }

        public bool Add(UserForms userForm)
        {
            return _userRepository.Add(userForm.ToUser());
        }


    }
}
