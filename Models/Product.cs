using System;
using System.Collections.Generic;
using System.Text;

namespace exam.Models
{
    public class Product
    {
        public Product(string name, string description, string category, float price)
        {
            ID = Guid.NewGuid();
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public Guid getID() { 
            return ID; 
        }

        public string getName() { 
            return Name;
        }

        public void setName(string name) { 
            this.Name = name;
        }

    }
}
