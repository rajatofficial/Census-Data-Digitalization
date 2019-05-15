using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public enum Gender
    {
        Male, Female, Other
    }

    public enum maritalStatus
    {
        Married, Unmarried
    }

    public enum OccStatus
    {
        Employed, Self_Employed, Student
    }
    public enum relationship
    {
        Self, Spouse, Son, Daughter, Sibling, Grandson, Granddaughter
    }

    public class PopulationDTO
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string fullName { get; set; }

        [Required]
        public int houseNumber { get; set; }

        [Required]
        public relationship relationship { get; set; }

        [Required]
        public Gender gender { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

        [Required]
        public maritalStatus MStatus { get; set; }

        public int AOM { get; set; }

        [Required]
        public OccStatus occupationStatus { get; set; }

        [DataType(DataType.Text)]
        public string NatureOfOccupation { get; set; }

    }
}
