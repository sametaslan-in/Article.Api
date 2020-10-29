using Article_Api.DataAccess.Abstract;
using Article_Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Article_Api.DataAccess.Concrete
{
    public class Article_ApiRepositoy : IArticle_ApiRepositoy
    {
        public Article CreateArticle(Article article)
        {
            using (var articleDbContext = new ArticleApiDbContext())
            {
                articleDbContext.Articles.Add(article);
                articleDbContext.SaveChanges();
                return article;

            }
        }

        public void DeleteAritcle(int id)
        {
            using (var articleDbContext = new ArticleApiDbContext())
            {
                var deletedArticle = GetArticleById(id);
                articleDbContext.Articles.Remove(deletedArticle);
                articleDbContext.SaveChanges();
            }
        }

        public List<Article> GetAllArticle()
        {
            using (var articleDbContext=new ArticleApiDbContext())
            {
                return articleDbContext.Articles.ToList();
            }

        }

        public Article GetArticleById(int id)
        {
            using (var articleDbContext = new ArticleApiDbContext())
            {
                return articleDbContext.Articles.Find(id);
            }
        }

        public Article UpdateArticle(Article article)
        {
            using (var articleDbContext = new ArticleApiDbContext())
            {
                articleDbContext.Articles.Update(article);
                articleDbContext.SaveChanges();
                return article;
            }
        }
    }
}
