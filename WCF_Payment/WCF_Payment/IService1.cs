using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Payment
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "getCustomers")]
        List<Customers> getCustomers();

        [OperationContract]

        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "postCustomers/{id}/{name}/{city}")]

        List<Customers> postCustomer(string id, string name, string city);

        [OperationContract]

        [WebInvoke(Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "deleteCustomers/{id}/{name}/{city}")]

        List<Customers> deleteCustomer(string id, string name, string city);
    }
}
