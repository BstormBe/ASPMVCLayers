using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public static class FakeDB
    {

        public static List<User> Users = new List<User>()
            {
                new User{Id = 1, Firstname = "Jean Pol", Lastname = "Moreau", Password = "Test123=", Username = "Jomomororo", CreationDate = DateTime.Now},
                new User{Id = 2, Firstname = "Marie", Lastname = "Dupont", Password = "Qwerty1234", Username = "Mdupont", CreationDate = DateTime.Now},
                new User{Id = 3, Firstname = "Paul", Lastname = "Martin", Password = "Azerty12345", Username = "Pmartin", CreationDate = DateTime.Now},
                new User{Id = 4, Firstname = "Julie",Lastname =  "Lefebvre", Password = "1234567890", Username = "Jlefebvre", CreationDate = DateTime.Now},
                new User{Id = 5, Firstname = "Thomas", Lastname = "Dubois", Password = "Abcdef1234", Username = "Tdubois", CreationDate = DateTime.Now},
                new User{Id = 6, Firstname = "Sophie", Lastname = "Bernard", Password = "Qwertyuiop1", Username = "Sbernard", CreationDate = DateTime.Now},
                new User{Id = 7, Firstname = "Pierre", Lastname = "Robert", Password = "Azertyuiop12", Username = "Probert", CreationDate = DateTime.Now},
                new User{Id = 8, Firstname = "Charlotte", Lastname = "Durand", Password = "1234567890-", Username = "Cdurand", CreationDate = DateTime.Now},
                new User{Id = 9, Firstname = "Benjamin", Lastname = "Garcia", Password = "Abcdefghij123", Username = "Bgarcia", CreationDate = DateTime.Now},
                new User{Id = 10, Firstname = "Amandine", Lastname = "Moreau", Password = "Qwertyuiopas123", Username = "Amoreau", CreationDate = DateTime.Now},
            };


    }



}
