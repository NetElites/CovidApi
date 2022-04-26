using CovidApi.Application.Dto;
using CovidApi.Application.Repository;
using CovidApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Services
{
    public class ArticleServices : ArticleRepository
    {
        private readonly ApplicationDbContext _context;
        public ArticleServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ArticleDto>> GetArticle()
        {
            var result = _context.articles.Select(article => new ArticleDto
            {
                ArticleId=article.ArticleId,
                Text=article.Text,
                Title=article.Title,
                NameAuthor=article.NameAuthor,
                UrlImage=article.UrlImage
            }).ToList();
            return result;
        }
    }
}
