using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public enum ownedStatus
    {
        Owner, Rented
    }
    public class HouseDTO
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int buildingNumber { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string address { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string state { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string fullName { get; set; }
        [Required]
        public ownedStatus status { get; set; }
        [Required]
        public int rooms { get; set; }
    }
}
