using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace nu.interfaces
{
    [ServiceContract]
    public interface ISecurity
    {
        [WebGet(UriTemplate = "/teste", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]        
        string Login();
    }
}
