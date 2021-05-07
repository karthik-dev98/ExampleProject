using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTwoEntity.Model
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string  DeptName { get; set; }
        public string  Location { get; set; }
         
    }
}
