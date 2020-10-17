using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Models
{
    public class Comments:BaseEntity
    {
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public string CommentsDetails { get; set; }
        public int NoOfLike { get; set; }
        public int NoOfDislike { get; set; }
        [JsonIgnore]
        public Post Post { get; set; }
    }
}
