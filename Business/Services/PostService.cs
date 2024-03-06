using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public PostService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<PostDetail> GetPostAsync(int postId)
        {
            return mapper.Map<PostDetail>(await unitOfWork.PostRepo.ReadOneAsync(postId));
        }

        public Task<int> GetPostCountAsync(int categoryId = 0, string? tag = null)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PostListItem>> GetPostsAsync(int page = 1, int per_page = 10, int categoryId = 0, string? tag = null)
        {
            var data = await unitOfWork.PostRepo.ReadManyAsync(null, new string[] { "Tags", "Category" });
            return mapper.Map<List<PostListItem>>(data);
        }
    }
}
