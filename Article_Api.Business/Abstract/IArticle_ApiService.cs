using Article_Api.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article_Api.Business.Abstract
{
  public interface IArticle_ApiService
    {
        List<Article> GetAllArticles();
        Article GetArticleById(int id);
        Article CreateArticle(Article article);
        Article UpdateArticle(Article article);
        void DeleteArticle(int id);
    }
}
