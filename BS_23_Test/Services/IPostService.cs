﻿using BS_23_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Services
{
    public interface IPostService
    {
        Task<bool> AddPost(Post post);
        Task<List<Post>> GetAllPost(string SrhText, int PageSize, int PageNo);
    }
}
