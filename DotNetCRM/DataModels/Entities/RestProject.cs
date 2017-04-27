using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Entities
{
    public class RestProject
    {
        public RestProject()
        {
        }

        public RestProject(Project p)
        {
            Id = p.Id;
            Name = p.Name;
            Description = p.Description;
            Status = p.Status;
            ProjectHeadId = p.ProjectHeadId;
            Volume = p.Volume;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int ProjectHeadId { get; set; }
        public int Volume { get; set; }
    }
}
