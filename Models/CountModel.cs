using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Dashboard.Models
{
    public class CountModel
    {
        [DataMember]
        public string WSDATAHEWAN { get; set; }
        [DataMember]
        public string WSDATACUSTOMER { get; set; }
        [DataMember]
        public string WSDATAADMIN { get; set; }

    }
    public class Mesage
    {
        [DataMember]
        public string Message { get; set; }

    }
}

