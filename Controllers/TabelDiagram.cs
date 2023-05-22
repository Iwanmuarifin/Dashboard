using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BNI.ELO.WS.Operations
{
    [DataContract(Name = "TabelDataRequest", Namespace = "")]
    public class TabelDataRequest
    {
        [DataMember]
        public List<GetCollectionAgentList> History_visit { get; set; }
        [DataMember]
        public string COLD_ID { get; set; }
    }
    [DataContract(Name = "GetCollectionAgentList", Namespace = "")]
    public class GetCollectionAgentList
    {
        [DataMember]
        public string WSDATAHEWAN { get; set; }
        [DataMember]
        public string WSDATACUSTOMER { get; set; }
        [DataMember]
        public string WSDATAADMIN { get; set; }


    }
}
