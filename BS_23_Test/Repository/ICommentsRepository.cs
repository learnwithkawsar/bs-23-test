using BS_23_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Repository
{
    public interface ICommentsRepository
    {
        Task<bool> AddComments(Comments comments);
        Task<bool> SaveLike(int CommentsId, bool IsLiked);
    }
}
