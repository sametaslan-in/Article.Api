using Article_Api.DataAccess;
using Article_Api.Entities;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Fake
{
    public static class FakeData
    {
        private static List<Article> _user;

        public static List<Article> GenerateFakeUsers()
        {

            if (_user == null)
            {
                _user = new Faker<Article>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.Text, f => f.Lorem.Paragraphs())
                .RuleFor(u => u.Title, f => f.Lorem.Paragraph())
                .RuleFor(u => u.TextCount, f => f.Lorem.Paragraphs().Count())
                .Generate(500);

          }


            

            foreach (var element in _user)
            {
                Console.WriteLine(element.Text);
                var context = new ArticleApiDbContext();
                var article = new Article {Title = element.Title, Text = element.Text, TextCount = element.TextCount };
                context.Articles.Add(article);
                context.SaveChanges();
                
            }
          return _user;


        }
    }
}
