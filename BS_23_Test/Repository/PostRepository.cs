using BS_23_Test.DBContext;
using BS_23_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BS_23_Test.Repository
{
    public class PostRepository : IPostRepository
    {
        protected readonly AppDbContext _dbContext;
        public PostRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public async Task<bool> AddPost(Post post)
        {
            try
            {
                _dbContext.Set<Post>().Add(post);
                return await _dbContext.SaveChangesAsync() > 0;
            }
            catch (Exception e)
            {

                throw e;
            }

          

           
        }

        public async Task<List<Post>> GetAllPost(string SrhText, int PageSize, int PageNo)
        {
            try
            {
                if (!string.IsNullOrEmpty(SrhText))
                {
                    return await _dbContext.Set<Post>().Include(c => c.Comments)
                        .Where(e => e.Title.Contains(SrhText))
                        .Skip((PageNo - 1) * PageSize)
                        .Take(PageSize)
                        .AsNoTracking()
                        .ToListAsync();
                }

                return await _dbContext.Set<Post>().Include(c => c.Comments)
                        .Skip((PageNo - 1) * PageSize)
                        .Take(PageSize)
                        .AsNoTracking()
                        .ToListAsync();
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
