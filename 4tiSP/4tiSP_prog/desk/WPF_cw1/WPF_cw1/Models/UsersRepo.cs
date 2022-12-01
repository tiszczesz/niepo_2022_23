using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_cw1.Models
{
    internal class UsersRepo
    {
        public List<User> Users { get; set; }

        public UsersRepo() {

        }

        public List<User> GetFakeUsers() {
            return new List<User> {
                new User{Id = 1,Name = "user1",Password = "user1",Email = "user1@gmail.com"},
                new User{Id = 2,Name = "user2",Password = "user2",Email = "user2@gmail.com"},
                new User{Id = 3,Name = "user3",Password = "user3",Email = "user3@gmail.com"},
                new User{Id = 4,Name = "user4",Password = "user4",Email = "user4@gmail.com"},
            };
        }
    }
}
