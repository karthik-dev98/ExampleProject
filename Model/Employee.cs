using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTwoEntity.Model
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string  EmailId { get; set; }
        public string  Address { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
       // public Department Department { get; set; }
    }
}
