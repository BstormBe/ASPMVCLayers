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
    public class UserRepositoryFakeDB : IUserRepository
    {
        public bool Add(User user)
        {

            try
            {
                user.Id = FakeDB.Users.Last().Id + 1;
                FakeDB.Users.Add(user);
                Console.WriteLine("Add");
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }

        public List<User> GetAll()
        {
            return FakeDB.Users;
            
        }
    }
}
