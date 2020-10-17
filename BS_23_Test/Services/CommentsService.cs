using BS_23_Test.Models;
using BS_23_Test.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Services
{
    public class CommentsService : ICommentsservice
    {
        private readonly ICommentsRepository _commentsRepository;
        public CommentsService(ICommentsRepository commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }
        public Task<bool> AddComments(Comments comments)
        {
            return _commentsRepository.AddComments(comments);
        }

        public Task<bool> SaveLike(int CommentsId, bool IsLiked)
        {
            return _commentsRepository.SaveLike(CommentsId, IsLiked);
        }
    }
}
