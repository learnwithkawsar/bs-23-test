using BS_23_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Services
{
    public interface ICommentsservice
    {
        Task<bool> AddComments(Comments comments);
    }
}
