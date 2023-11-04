﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBook.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User> { new User() { Email = "sharathkumar333@outlook.com", Name = "Sharath Kumar" }, new User() { Email = "shark.krish@gmail.com", Name = "Sharath" } };
    
        public static ObservableCollection<User> GetUsers()
        { 
            return _DatabaseUsers; 
        }

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }
    }
}
