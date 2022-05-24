using Capstone_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Project.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();
        public SecurityService()
        {
            knownUsers.Add(new UserModel { Calories = 3000, UserName = "JoshuaOcampo", Password = "password" });
            knownUsers.Add(new UserModel { Calories = 4000, UserName = "PatrickCamino", Password = "password" });
            knownUsers.Add(new UserModel { Calories = 2000, UserName = "MarcValentin", Password = "password" });
            knownUsers.Add(new UserModel { Calories = 3100, UserName = "MaryWeaver", Password = "password" });

        }

       public bool IsValid(UserModel user)
        {
            return knownUsers.Any();
        }

            




    }
}
