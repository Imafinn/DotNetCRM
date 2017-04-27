using DataModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataModels.Entities
{
    [DataContract(Namespace="http://localhost:8080/pcrm")]
    public class RestEmployee
    {
        public RestEmployee()
        {
        }

        public RestEmployee(Employee e)
        {
            Id = e.Id;
            Firstname = e.Firstname;
            Lastname = e.Lastname;
            Department = e.Department;
            Salary = e.Salary;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public int Salary { get; set; }
    }
}