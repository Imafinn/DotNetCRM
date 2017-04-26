using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Entities
{
    [Table("employee")]
    public class Employee
    {
        public Employee()
        {
            Projects = new List<Project>();
        }

        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public virtual List<Project> Projects { get; set; }
    }
}
