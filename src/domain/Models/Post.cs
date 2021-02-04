using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace domain.Models
{
    public class Post : EntityBase
    {
        public Post(string title, string description, string author, DateTime datePublish, string image, Category category)
        {

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Titulo é inválido");
            }
            if(string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Descrição é inválido");
            }
            if(string.IsNullOrEmpty(author))
            {
                throw new ArgumentException("Autor é inválido");
            }
            if(string.IsNullOrEmpty(image))
            {
                throw new ArgumentException("");
            }
            if(category == null)
            {
                throw new ArgumentException();
            }
             

            Title = title;
            Description = description;
            Author = author;
            DatePublish = datePublish;
            Image = image;
            Category = category;
        }

        public string Title { get; }
        public string Description { get; }
        public string Author { get; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DatePublish { get; }
        public string Image { get; }
        public Category Category { get; }
    }
}