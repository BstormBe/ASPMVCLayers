using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public static class FakeDB2
    {
        public static List<User> Users = new List<User>()
{
    new User{Id = 1, Firstname = "Alex", Lastname = "Smith", Password = "Password123", Username = "Asmith", CreationDate = DateTime.Now},
    new User{Id = 2, Firstname = "Bella", Lastname = "Jones", Password = "Qwerty1234", Username = "Bjones", CreationDate = DateTime.Now},
    new User{Id = 3, Firstname = "Charlie", Lastname = "Williams", Password = "Azerty12345", Username = "Cwilliams", CreationDate = DateTime.Now},
    new User{Id = 4, Firstname = "David", Lastname = "Brown", Password = "1234567890", Username = "Dbrown", CreationDate = DateTime.Now},
    new User{Id = 5, Firstname = "Emma", Lastname = "Johnson", Password = "Abcdef1234", Username = "Ejohnson", CreationDate = DateTime.Now},
    new User{Id = 6, Firstname = "Frank", Lastname = "Miller", Password = "Qwertyuiop1", Username = "Fmiller", CreationDate = DateTime.Now},
    new User{Id = 7, Firstname = "George", Lastname = "Davis", Password = "Azertyuiop12", Username = "Gdavis", CreationDate = DateTime.Now},
    new User{Id = 8, Firstname = "Hannah", Lastname = "Taylor", Password = "1234567890-", Username = "Htaylor", CreationDate = DateTime.Now},
    new User{Id = 9, Firstname = "Isaac", Lastname = "Anderson", Password = "Abcdefghij123", Username = "Ianderson", CreationDate = DateTime.Now},
    new User{Id = 10, Firstname = "Jessica", Lastname = "Thomas", Password = "Qwertyuiopas123", Username = "Jthomas", CreationDate = DateTime.Now},
};
    }
}
