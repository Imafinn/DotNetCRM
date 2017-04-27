using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Entities
{
    [DataContract(Namespace = "http://localhost:8080/pcrm")]
    public class RestProject
    {
        public RestProject(Project p)
        {
            Id = p.Id;
            Name = p.Name;
            Description = p.Description;
            Status = p.Status;
            ProjectHeadId = p.ProjectHeadId;
            Volume = p.Volume;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public int ProjectHeadId { get; set; }
        [DataMember]
        public int Volume { get; set; }
    }
}
