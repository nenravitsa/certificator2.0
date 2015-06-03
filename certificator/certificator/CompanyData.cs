using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sertificator

{
    [Serializable()]
    struct CompanyData
    {
        private int sertificatNumber;
        public string Name {set; get; }
        public string Adress { set; get; }
        public string Phone { set; get; }
        
        public int SertificatNumber {
            set { sertificatNumber += 1; }
            get { return sertificatNumber; }
        }
        public CompanyData(string name) : this()
        {
            Name = name;
            Adress = "";
            Phone = "";
            sertificatNumber = 1;
        }

    }
}
