using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sertificator

{
    [Serializable()]
    struct CompanyInfo
    {
        private int sertificatNumber;
        public string Name {set; get; }
        public string Adress { set; get; }
        public string Phone { set; get; }
        public string Manager { set; get; }
        public int SertificatNumber {
            set { sertificatNumber += 1; }
            get { return sertificatNumber; }
        }
        public CompanyInfo(string name) : this()
        {
            Name = name;
            Adress = "";
            Phone = "";
            Manager = "";
            sertificatNumber = 1;
        }

    }
}
