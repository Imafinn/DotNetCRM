using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModels.Entities;
using Database.DataAccess;


namespace WebClient.Helper
{
    /// <summary>
    /// Fake repository to emulate database
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {
        private IPcrmDao _dao;

        public EmployeeRepository()
        {
            _dao = new PcrmDao();
        }

        public List<RestEmployee> GetAll()
        {
            List<RestEmployee> employees = new List<RestEmployee>();

            foreach(Employee e in _dao.GetAllEmployees())
            {
                employees.Add(new RestEmployee(e));
            }

            return employees;
        }

        public RestEmployee GetById(int id)
        {
            return new RestEmployee(_dao.GetEmployee(id));
        }
    }
}