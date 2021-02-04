using System;
using System.Collections.Generic;

namespace domain.Models
{
   public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static List<Category> Gerador(){
            return new List<Category>{
                new Category{Id= Guid.NewGuid(), Name="Home"},
                new Category{Id= Guid.NewGuid(), Name="Services"},
                new Category{Id= Guid.NewGuid(), Name="About"},
                new Category{Id= Guid.NewGuid(), Name="Contact"},
            };
        }
    }
}