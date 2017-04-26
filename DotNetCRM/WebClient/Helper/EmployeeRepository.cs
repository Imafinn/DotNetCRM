﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebClient.Helper
{
    /// <summary>
    /// Fake repository to emulate database
    /// </summary>
    public class EmployeeRepository
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new RestEmployee(){Id = 1, Department = "WILC", Firstname = "Lou", Lastname="Bahnhof", Salary=11},
            new RestEmployee(){Id = 2, Department = "A", Firstname = "L", Lastname="B", Salary=69}
        };

        public static List<RestEmployee> GetAll()
        {
            return _employees;
        }

        public static RestEmployee GetById(int id)
        {
            return _employees.Single(e => e.Id == id);
        }
    }
}