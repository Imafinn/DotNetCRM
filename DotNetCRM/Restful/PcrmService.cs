using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataModels.Entities;
using Database.DataAccess;

namespace Restful
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class PcrmService : IPcrmService
    {
        PcrmDao _pcrmDao = new PcrmDao();

        public RestEmployee GetEmployee(string id)
        {
            return new RestEmployee(_pcrmDao.GetEmployee(int.Parse(id)));
        }
    }
}
