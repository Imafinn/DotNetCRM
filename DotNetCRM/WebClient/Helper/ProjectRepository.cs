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
    public class ProjectRepository : IProjectRepository
    {
        private IPcrmDao _dao;

        public ProjectRepository()
        {
            _dao = new PcrmDao();
        }

        public List<RestProject> GetAll()
        {
            List<RestProject> projects = new List<RestProject>();

            foreach(Project p in _dao.GetAllProjects())
            {
                projects.Add(new RestProject(p));
            }

            return projects;
        }

        public RestProject GetById(int id)
        {
            return new RestProject(_dao.GetProject(id));
        }
    }
}