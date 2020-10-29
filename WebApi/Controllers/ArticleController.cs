using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article_Api.Business;
using Article_Api.Business.Abstract;
using Article_Api.Business.Concrete;
using Article_Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApi.Fake;

namespace WebApi.Controller
{
    [Route("api/[controller]")]
 
    [ApiController]
    public class ArticleController : ControllerBase
    {



        private IArticle_ApiService _articleService;


      
      
    


        public ArticleController(IArticle_ApiService article_ApiService)
        {
            _articleService = article_ApiService;
        }

        /// <summary>
        /// Generates 500 fake data
        /// </summary>
        /// <returns></returns>


        [HttpGet]
        [Route("generate")]
     public IActionResult GetFakeData()
        {
            List<Article> _generate = FakeData.GenerateFakeUsers();
            return Ok(_generate);

        }
        /// <summary>
        /// Get All Article
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult  Get()
        {
            var articles= _articleService.GetAllArticles();
            return Ok(articles);

        }



        /// <summary>
        /// Get Article By ID
        /// </summary>
        /// <returns></returns>



        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var  articles= _articleService.GetArticleById(id);
          if(articles!=null)
            {

                return Ok(articles);
            }
            return NotFound(); 

        }
        /// <summary>
        /// Create An Article
        /// </summary>
        /// <returns></returns>



        [HttpPost]
        public IActionResult Post([FromBody]Article article)
        {
         
               var createdArticle= _articleService.CreateArticle(article);
               return CreatedAtAction("Get",new { id=createdArticle.Id},createdArticle);
        
     
        }

        /// <summary>
        /// Update The Article
        /// </summary>
        /// <returns></returns>


        [HttpPut]
        public IActionResult Put([FromBody] Article article)
        {
            if (_articleService.GetArticleById(article.Id) != null)
            {
                return Ok(_articleService.UpdateArticle(article));

            }
            return NotFound();
        }


        /// <summary>
        /// Delete The Article
        /// </summary>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            if (_articleService.GetArticleById(id) != null)
            {
                _articleService.DeleteArticle(id);
                return Ok();

            }
            return NotFound();
          

        }




    }
}
