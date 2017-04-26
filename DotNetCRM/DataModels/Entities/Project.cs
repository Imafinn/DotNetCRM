using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Entities
{
    [Table("project")]
    public class Project
    {
        public Project()
        {
            Employees = new List<Employee>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        [Column("projecthead_idfs")]
        public int ProjectHeadId { get; set; }
        public int Volume { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
