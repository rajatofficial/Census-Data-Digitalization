using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesusEntityFramework
{
    public class User
    {
        public enum status
        {
            Pending, Approved, Rejected
        }

        public int ID { get; set; }

        public string email { get; set; }
       
        public string password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string image { get; set; }


        public long adhaarNumber { get; set; }

        public status Status { get; set; }

        public bool isApprover { get; set; }
    }
}
