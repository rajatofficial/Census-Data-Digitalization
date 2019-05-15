using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class UserDTO
    {
        public enum status
        {
             Pending, Approved, Rejected
        }

      
        [Key]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*?[@#$%^&*!])[A-Za-z0-9@#$%^&*!]{8,}$", ErrorMessage = "AtLeast 8 characters and contains special character!")]
        public string password { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string image { get; set; }

        
      
        public long adhaarNumber { get; set; }

        [Required]
        public status Status { get; set; }

        [Required]
        public bool isApprover { get; set; }
    }
}
