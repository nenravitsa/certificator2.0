using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertificator
{
    [Serializable()]
    public class CoServicesData
    {
        private Dictionary<string, string> ServiceDescription ;
        private Dictionary<string, int> ServiceCost ;

        public CoServicesData()
        {
            ServiceDescription = new Dictionary<string, string> {{"", ""}};
            ServiceCost = new Dictionary<string, int> {{"", 0}};
        }

        public void AddService(string name, string description, int cost)
        {
            ServiceDescription.Add(name,description);
            ServiceCost.Add(name, cost);
        }

        public void RemoveService(string name)
        {
            ServiceDescription.Remove(name);
            ServiceCost.Remove(name);
        }

        public int GetCost(string name)
        {
            if (name != "")
                return ServiceCost[name];
            else return 0;

        }
        public string GetDescription(string name)
        {
            if (name != "")
                return ServiceDescription[name];
            else return "";
        }
        public int GetNumberServices()
        {
            return ServiceCost.Count;
        }

        public List<string> GetServicesList()
        {
            return ServiceDescription.Keys.ToList();
        }
    }
}
