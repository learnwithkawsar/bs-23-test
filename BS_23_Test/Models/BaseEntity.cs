using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BS_23_Test.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        
    }
}
