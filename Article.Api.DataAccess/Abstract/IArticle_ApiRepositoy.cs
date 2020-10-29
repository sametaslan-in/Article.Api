using Article_Api.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article_Api.DataAccess.Abstract
{
 public  interface IArticle_ApiRepositoy
    {
        List<Article> GetAllArticle();
        Article GetArticleById(int id);
        Article CreateArticle(Article article);
        Article UpdateArticle(Article article);
        void DeleteAritcle(int id);
    }

}
