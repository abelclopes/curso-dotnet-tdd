using System;
using Xunit;
using domain.Models;
using ExpectedObjects;
using System.Linq;

namespace test.domain
{
    public class BlogTest
    {
        [Fact]
        public void AddNewPost()
        {
            var postEsperado = new
            {
                title = "Primeiro Post",
                description = "Essa é a descriçãod do primeiro post. que vem demonstrar como vai funcionar tudo",
                author = "Abel Lopes",
                dateCreated = DateTime.Parse("04/02/2021"),
                datePublish = DateTime.Parse("05/02/2021"),
                image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg",
                Category = Category.Gerador().FirstOrDefault()
            };

            var post = new Post(postEsperado.title, postEsperado.description, postEsperado.author,
            postEsperado.datePublish, postEsperado.image, postEsperado.Category);

            postEsperado.ToExpectedObject().ShouldNotMatch(post);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Theory_PostCannotHaveAnEmptyTitle(string titleIvalid)
        {
            var postEsperado = new
            {
                title = "Primeiro Post",
                description = "Essa é a descriçãod do primeiro post. que vem demonstrar como vai funcionar tudo",
                author = "Abel Lopes",
                dateCreated = DateTime.Parse("04/02/2021"),
                datePublish = DateTime.Parse("05/02/2021"),
                image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg",
                Category = Category.Gerador().FirstOrDefault()
            };

            var message = Assert.Throws<ArgumentException>(()=> new Post(titleIvalid, postEsperado.description, postEsperado.author,
            postEsperado.datePublish, postEsperado.image, postEsperado.Category)).Message;

            Assert.Equal("Titulo é inválido", message);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Theory_PostCannotHaveAnEmptyDescription(string descriptionIvalid)
        {
            var postEsperado = new
            {
                title = "Primeiro Post",
                description = "Essa é a descrição do primeiro post. que vem demonstrar como vai funcionar tudo",
                author = "Abel Lopes",
                dateCreated = DateTime.Parse("04/02/2021"),
                datePublish = DateTime.Parse("05/02/2021"),
                image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg",
                Category = Category.Gerador().FirstOrDefault()
            };

            var message = Assert.Throws<ArgumentException>(()=> new Post(postEsperado.title, descriptionIvalid, postEsperado.author,
            postEsperado.datePublish, postEsperado.image, postEsperado.Category)).Message;

            Assert.Equal("Descrição é inválido", message);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Theory_PostCannotHaveAnEmptyAuthor(string authorIvalid)
        {
            var postEsperado = new
            {
                title = "Primeiro Post",
                description = "Essa é a descrição do primeiro post. que vem demonstrar como vai funcionar tudo",
                author = "Abel Lopes",
                dateCreated = DateTime.Parse("04/02/2021"),
                datePublish = DateTime.Parse("05/02/2021"),
                image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg",
                Category = Category.Gerador().FirstOrDefault()
            };

            var message = Assert.Throws<ArgumentException>(()=> new Post(postEsperado.title, postEsperado.description,authorIvalid,
            postEsperado.datePublish, postEsperado.image, postEsperado.Category)).Message;

            Assert.Equal("Autor é inválido", message);
        }
        [Theory]
        [InlineData(null)]
        public void Theory_PostCannotHaveAnEmptyCategory(Category CategoryInvalid)
        {
            var postEsperado = new
            {
                title = "Primeiro Post",
                description = "Essa é a descrição do primeiro post. que vem demonstrar como vai funcionar tudo",
                author = "Abel Lopes",
                dateCreated = DateTime.Parse("04/02/2021"),
                datePublish = DateTime.Parse("05/02/2021"),
                image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg",
                Category = Category.Gerador().FirstOrDefault()
            };

            var message = Assert.Throws<ArgumentException>(()=> new Post(postEsperado.title, postEsperado.description, postEsperado.author,
            postEsperado.datePublish, postEsperado.image, CategoryInvalid)).Message;

            Assert.Equal("Categoria é inválido", message);
        }
    }
}
