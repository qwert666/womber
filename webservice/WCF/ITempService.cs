using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WCF
{
    [ServiceContract()]
    public interface ITempService
    {
        [OperationContract]
        float PobierzTemp();


    }

    [DataContract]
    public class Dane
    {
        [DataMember]
        float C;

        [DataMember]
        float F;

        
    }
    
}
