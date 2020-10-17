using BS_23_Test.Models;
using BS_23_Test.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public Task<bool> AddPost(Post post)
        {
           return _postRepository.AddPost(post);
        }

        public Task<List<Post>> GetAllPost(string SrhText, int PageSize, int PageNo)
        {
            return _postRepository.GetAllPost(SrhText, PageSize, PageNo);
        }
    }
}
