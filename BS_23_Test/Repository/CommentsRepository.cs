using BS_23_Test.DBContext;
using BS_23_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Repository
{
    public class CommentsRepository : ICommentsRepository
    {
        protected readonly AppDbContext _dbContext;
        public CommentsRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public async Task<bool> AddComments(Comments comments)
        {
            try
            {
                _dbContext.Set<Comments>().Add(comments);
                return await _dbContext.SaveChangesAsync() > 0;
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }

        public async Task<bool> SaveLike(int CommentsId, bool IsLiked)
        {
            try
            {
                var comment = _dbContext.Set<Comments>().Find(CommentsId);
                if (IsLiked)
                {
                    comment.NoOfLike += 1;
                }
                else
                {
                    comment.NoOfLike -= 1;
                }

                _dbContext.Entry(comment).State = EntityState.Modified;
                    return await _dbContext.SaveChangesAsync() > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
