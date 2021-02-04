using System;
using System.Collections.Generic;

namespace domain.Models
{
   public class Category
    {
        public Category(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public Category(){}

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static List<Category> Gerador(){
            return new List<Category>
            {
                new Category(Guid.NewGuid(), "Home"),
                new Category(Guid.NewGuid(), "Services"),
                new Category(Guid.NewGuid(), "About"),
                new Category(Guid.NewGuid(), "Contact")
            };
        }
    }
}