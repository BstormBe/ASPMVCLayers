using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepositoryFakeDB2 : IUserRepository
    {
        public List<User> GetAll()
        {
            return FakeDB2.Users;
        }
    }
}
