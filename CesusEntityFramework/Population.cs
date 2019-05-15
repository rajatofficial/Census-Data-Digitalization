using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesusEntityFramework
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

    public class Population
    {
        public int ID { get; set; }

       
        public string fullName { get; set; }

        
        public int houseNumber { get; set; }

        public relationship relationship { get; set; }

        public Gender gender { get; set; }

        public DateTime DOB { get; set; }

        public maritalStatus MStatus { get; set; }

        public int AOM { get; set; }

        public OccStatus occupationStatus { get; set; }

        public string NatureOfOccupation { get; set; }

    }
}
