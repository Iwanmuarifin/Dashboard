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
        public string ID_Traffic { get; set; }
    }
    public class CountSResponse
    {
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }

    }
    public class CountS
    {
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }

    }
}