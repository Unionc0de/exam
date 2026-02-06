using System;
using System.Collections.Generic;
using System.Text;

namespace exam.Models
{
    public class Order
    {
        public Order(Guid id, User user, Product product)
        {
            Id = id;
            User = user;
            Product = product;
        }

        public Order(User user, Product product)
        {
            Id = Guid.NewGuid();
            User = user;
            Product = product;
        }

        public Guid Id { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
