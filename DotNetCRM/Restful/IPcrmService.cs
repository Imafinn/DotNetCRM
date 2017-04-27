using DataModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Restful
{
    [ServiceContract]
    public interface IPcrmService
    {
        [WebGet(UriTemplate = "employees/{id}")]
        [OperationContract]
        RestEmployee GetEmployee(string id);
    }
}
