using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModels.Entities;


namespace WebClient.Helper
{
    /// <summary>
    /// Fake repository to emulate database
    /// </summary>
    public class EmployeeRepositoryFake : IEmployeeRepository
    {
        private static List<RestEmployee> _employees = new List<RestEmployee>()
        {
            new RestEmployee(){Id = 1, Department = "WILC", Firstname = "Lou", Lastname="Bahnhof", Salary=11},
            new RestEmployee(){Id = 2, Department = "A", Firstname = "L", Lastname="B", Salary=69}
        };

        public List<RestEmployee> GetAll()
        {
            return _employees;
        }

        public RestEmployee GetById(int id)
        {
            return _employees.Single(e => e.Id == id);
        }
    }
}