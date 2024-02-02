using ForumApp.BuisnessLogic.Contracts;
using ForumApp.BuisnessLogic.Models;
using ForumApp.Infrastructure.Data;
using ForumApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BuisnessLogic.Services
{
    public class PostService : IPostService
    {
        private readonly ForumAppDbContext dbContext;
        public PostService(ForumAppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task AddAsync(PostViewModel model)
        {
            var entity = new Post
            {
                Title = model.Title,
                Content = model.Content,
            };

            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(PostViewModel model)
        {
            var entity = await dbContext.Posts.FindAsync(model.Id);

            if (entity == null)
            {
                throw new ApplicationException("The post does not exist"!);

            }
            
            dbContext.Posts.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(PostViewModel model)
        {
            var entity = await dbContext.Posts.FindAsync(model.Id);
                
            if (entity == null)
            {
                throw new ApplicationException("The model does not exist");
            }
            
            
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<PostViewModel>> GetAllPostsAsync()
        {
            return await dbContext.Posts
                .Select(x => new PostViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Content = x.Content
                })
                .AsNoTracking()
                .ToListAsync();    
              
                
        }

        public async Task<PostViewModel?> GetByIdAsync(int id)
        {
            return await dbContext.Posts
                .Where(p => p.Id == id)
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                }).FirstOrDefaultAsync();
        }
    }
}
