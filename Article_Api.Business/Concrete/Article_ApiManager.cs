using Article_Api.Business.Abstract;
using Article_Api.DataAccess.Abstract;
using Article_Api.DataAccess.Concrete;
using Article_Api.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article_Api.Business.Concrete
{
    public class Article_ApiManager : IArticle_ApiService
    {
        private IArticle_ApiRepositoy _articleRepositroy;

        public Article_ApiManager(IArticle_ApiRepositoy article_ApiRepositoy)
        {
            _articleRepositroy = article_ApiRepositoy;
        }

        public Article CreateArticle(Article article)
        {
            return _articleRepositroy.CreateArticle(article);
        }

        public void DeleteArticle(int id)
        {
            _articleRepositroy.DeleteAritcle(id);
        }

        public List<Article> GetAllArticles()
        {
            return _articleRepositroy.GetAllArticle();
        }

        public Article GetArticleById(int id)
        {
            if (id > 0) { 
            return _articleRepositroy.GetArticleById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public Article UpdateArticle(Article article)
        {
            return _articleRepositroy.UpdateArticle(article);
        }
    }
}
