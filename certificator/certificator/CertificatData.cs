using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertificator
{
    [Serializable]
    class CertificatData
    {
        public string ClientFIO { set; get; }
        public string ClientPhone { set; get; }
        public string ClientEmail { set; get; }
        public int SertificatNumber { set; get; }
        public DateTime DateOrder { private set; get; }
    }
}
