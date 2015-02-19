using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using taskForIttilan.models;
namespace taskForIttilan.service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceAjax    :   IServiceAjax
    {
        private readonly FakeDataSource _dataSource = new FakeDataSource();

        [WebInvoke(Method = "GET",
     ResponseFormat = WebMessageFormat.Json)]
        public List<string> Get(string term)
        {
            return _dataSource.Get(term);
        }
    }
}
