using DataModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DataAccess
{
    public interface IPcrmDao
    {
        Employee GetEmployee(int id);
        List<Employee> GetAllEmployees();
        Project GetProject(int id);
        List<Project> GetAllProjects();
    }
}
