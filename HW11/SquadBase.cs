using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    [Serializable]
    [DataContract]
    public class SquadBase
    {
        [DataMember]
        public string squadName { get; set; }
        [DataMember]
        public string homeTown { get; set; }
        [DataMember]
        public int formed { get; set; }
        [DataMember]
        public string secretBase { get; set; }
        [DataMember]
        public bool active { get; set; }
        [DataMember]
        public Member[] members { get; set; }

    }
}
