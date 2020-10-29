using System;
using System.Collections.Generic;
using System.Text;
using Article_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Article_Api.DataAccess
{
  public  class ArticleApiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
           // SqlConnection bag = new SqlConnection(@"Server=Localhost\;initial catalog = okulzili;Integrated Security=True");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T3SQSG1\SQLEXPRESS;Database=ArticleDb;Integrated Security=True");
        }
        public DbSet<Article> Articles { get; set; }
    }
}
