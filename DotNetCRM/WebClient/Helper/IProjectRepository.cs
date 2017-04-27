using DataModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Helper
{
    public interface IProjectRepository
    {
        List<RestProject> GetAll();
        RestProject GetById(int id);
    }
}
