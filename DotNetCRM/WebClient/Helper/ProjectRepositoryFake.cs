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
    public class ProjectRepositoryFake : IProjectRepository
    {
        private static List<RestProject> _projects = new List<RestProject>()
        {
            new RestProject(){Id=1, Name="TDDM", Description="Start of a new era.", Status="open", ProjectHeadId=1, Volume=12000},
            new RestProject(){Id=2, Name="SUP", Description="It's a new technology.", Status="in progress", ProjectHeadId=2, Volume=21000}
        };

        public List<RestProject> GetAll()
        {
            return _projects;
        }

        public RestProject GetById(int id)
        {
            return _projects.First(p => p.Id == id);
        }
    }
}