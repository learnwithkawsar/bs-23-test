using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BS_23_Test.Models;
using BS_23_Test.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BS_23_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [Route("SavePost")]
        [HttpPost]
        public IActionResult SavePost(string Title,string AddBy)
        {
            var res = _postService.AddPost(new Post()
            {
                Title = Title,
                AddBy= AddBy,
                AddDate= DateTime.Now
            }).Result ;
            if (res)
            {
                return Ok("Save Successfull");
            }
            else
            {
                return BadRequest("Not saved");
            }
        }
        [Route("GetAllPost")]
        [HttpGet]
        public IActionResult GetAllPost(string Srchtext, int PageSize=10, int PageNo=1)
        {
            var res = _postService.GetAllPost(Srchtext, PageSize, PageNo).Result;  
            return Ok(res);
        }
    }
}
