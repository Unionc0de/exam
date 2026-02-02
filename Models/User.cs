using System;
using System.Collections.Generic;
using System.Text;


namespace exam.Models
{
    public class User
    {
        public User(Guid id,string userName, string password,RoleType role)
        {
            ID = id;
            UserName = userName;
            Password = password;
            Role = role;
        }

        public User(string userName, string password, RoleType role)
        {
            ID = Guid.NewGuid();
            UserName = userName;
            Password = password;
            Role = role;
        }

        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public enum RoleType
        {
            User,
            Admin,
        }
        public RoleType Role { get; set; }
    }
}
