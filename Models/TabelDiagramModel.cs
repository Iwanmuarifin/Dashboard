using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dashboard.Models
{
    [DataContract(Name = "TabelDiagramModel", Namespace = "")]
    public class TabelDiagramModel
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
