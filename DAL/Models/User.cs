﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
