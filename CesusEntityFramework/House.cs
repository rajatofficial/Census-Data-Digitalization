using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesusEntityFramework
{
    public enum ownedStatus
    {
        Owner,Rented
    }
    public class House
    {
        public int id { get; set; }

        public int buildingNumber { get; set; }

        public string address { get; set; }

        public string state { get; set; }

        public string fullName { get; set; }

        public ownedStatus status { get; set; }

        public int rooms { get; set; }
    }
}
