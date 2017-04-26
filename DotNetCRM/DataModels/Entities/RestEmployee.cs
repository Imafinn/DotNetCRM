using DataModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Restful.Entities
{
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

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}