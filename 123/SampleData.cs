using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kursova9.Models;

namespace Kursova9
{
    public static class SampleData
    {
        public static void Initialize(UsersContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Email = "Admin",
                        Password = "admin1234",
                        Role = "admin"
                    },
                    new User 
                    { 
                        Email = "Moder1",
                        Password = "1234",
                        Role = "moder"
                    });
                context.SaveChanges();
            }

        }
    }
}
