using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace taskForIttilan
{
    [ServiceContract(Namespace = "")]
    public interface IServiceAjax
    {
        [OperationContract]
        
        List<string> Get(string term);
    }
}