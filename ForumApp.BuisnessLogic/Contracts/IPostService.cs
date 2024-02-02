using ForumApp.BuisnessLogic.Models;
using ForumApp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BuisnessLogic.Contracts
{
    public interface IPostService
    {
        Task AddAsync(PostViewModel model);
        Task EditAsync(PostViewModel model);
        Task<IEnumerable<PostViewModel>> GetAllPostsAsync();
        Task<PostViewModel?> GetByIdAsync(int id);
    }
}
