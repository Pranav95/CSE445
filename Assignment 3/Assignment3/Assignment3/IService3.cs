using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;

namespace Assignment3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService3" in both code and config file together.
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        void DoWork();

        


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "movie/{id}")]
        string getMovie(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "tag/{id}")]
        string getTag(string id);
    }
}
