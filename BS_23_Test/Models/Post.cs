using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Models
{
    public class Post:BaseEntity
    {
        
       
        [Required]
        public string Title { get; set; }    
        public ICollection<Comments> Comments { get; set; }
    }
}
