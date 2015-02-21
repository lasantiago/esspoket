using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace esspocketORM
{
    public class User
    {
        public User()
        {
        }

        public User(string username)
        {
            this.UserId = Guid.NewGuid();
            this.UserName = username;
        }


        public User(string id, string username)
        {
            this.UserId = new Guid(id);
            this.UserName = username;
        }

        [Key]
        public Guid UserId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        public string UserName { get; set; }


        public IEnumerable<User> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Users
                    orderby c.UserName ascending
                    select c);
        }

        public User GetUserById(EsspocketDBContext e, string id)
        {
            var query = (from c in e.Users
                         where c.UserId == new Guid(id)
                         select c).FirstOrDefault();

            return query;
        }

        public User GetUserByUserName(EsspocketDBContext e, string name)
        {
            var query = (from c in e.Users
                         where c.UserName == name
                         select c).FirstOrDefault();

            return query;
        }
    }
}