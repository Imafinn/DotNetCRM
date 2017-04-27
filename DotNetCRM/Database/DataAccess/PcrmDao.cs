using DataModels.Entities;
using Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DataAccess
{
    public class PcrmDao : IPcrmDao
    {
        private PcrmContext _context;

        public List<Employee> GetAllEmployees()
        {
            using (_context = new PcrmContext())
            {
                return _context.Employees.ToList();
            }
        }

        public List<Project> GetAllProjects()
        {
            using (_context = new PcrmContext())
            {
                return _context.Projects.ToList();
            }
        }

        public Employee GetEmployee(int id)
        {
            using (_context = new PcrmContext())
            {
                return _context.Employees.Find(id);
            }
        }

        public Project GetProject(int id)
        {
            using (_context = new PcrmContext())
            {
                return _context.Projects.Find(id);
            }
        }
    }
}
