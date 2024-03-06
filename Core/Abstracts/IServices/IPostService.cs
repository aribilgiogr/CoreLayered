using Core.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts.IServices
{
    public interface IPostService
    {
        Task<PostDetail> GetPostAsync(int postId);
        Task<IEnumerable<PostListItem>> GetPostsAsync(int page = 1, int per_page = 10, int categoryId = 0, string? tag = null);
        Task<int> GetPostCountAsync(int categoryId = 0, string? tag = null);
    }
}
