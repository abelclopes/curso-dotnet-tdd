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
        public void Theory_PostCannotHaveAnEmptyTitle(string nameIvalid)
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

            var message = Assert.Throws<ArgumentException>(()=> new Post(nameIvalid, postEsperado.description, postEsperado.author,
            postEsperado.datePublish, postEsperado.image, postEsperado.Category)).Message;

            Assert.Equal("Titulo é inválido", message);
        }
    }
}
