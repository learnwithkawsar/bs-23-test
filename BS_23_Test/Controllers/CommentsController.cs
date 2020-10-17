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
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsservice _commentsService;
        public CommentsController(ICommentsservice commentsservice)
        {
            _commentsService = commentsservice;
        }
        [Route("SaveComments")]
        [HttpPost]
        public IActionResult SaveComments(int PostId, string Description, string AddBy)
        {
            var res = _commentsService.AddComments(new Comments()
            {
                PostId = PostId,
                CommentsDetails = Description,
                AddBy = AddBy,
                AddDate = DateTime.Now
            }).Result;
            if (res)
            {
                return Ok("Save Successfull");
            }
            else
            {
                return BadRequest("Not saved");
            }
        }
        [Route("SaveLike")]
        [HttpPost]
        public IActionResult SaveLike(int CoomentId, bool IsLiked)
        {
            var res = _commentsService.SaveLike(CoomentId,IsLiked).Result;
            if (res)
            {
                return Ok("Save Successfull");
            }
            else
            {
                return BadRequest("Not saved");
            }
        }
    }
}
