using BS_23_Test.DBContext;
using BS_23_Test.Models;
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
    }
}
