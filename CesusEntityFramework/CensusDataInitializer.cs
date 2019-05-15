using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesusEntityFramework
{
    public class CensusDataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CensusDataContext>
    {
        protected override void Seed(CensusDataContext context)
        {
            var users = new List<User>
            {
            new User{ ID = 1, email = "rajat.khurana@nagarro.com",password="rajat@12345", firstName = "Rajat", lastName = "Khurana", adhaarNumber = 123456781234, Status=User.status.Approved, isApprover=true},
            new User{ ID = 2, email = "pankaj.yadav@nagarro.com", password = "pankaj@12345", firstName = "Pankaj", lastName = "Yadav", adhaarNumber = 234512346789, Status = User.status.Pending, isApprover=true },
            new User{ ID = 3, email = "vinay.garg@nagarro.com", password = "vinay@12345", firstName = "Vinay", lastName = "Garg", adhaarNumber = 123409876123, Status = User.status.Rejected, isApprover=false },
            new User{ ID = 4, email = "naman.rawat@nagarro.com", password = "naman@12345", firstName = "Naman", lastName = "Rawat", adhaarNumber = 908765432311, Status = User.status.Approved, isApprover=false }

            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var houses = new List<House>
            {
            new House() { id = 1, buildingNumber = 371, address = "4140,Sector 23", state = "Gurgaon", fullName = "Rajat Khurana", status=ownedStatus.Owner, rooms=3 },
            new House() { id = 2, buildingNumber = 371, address = "4141,Sector 23", state = "Gurgaon", fullName = "Pankaj Yadav", status = ownedStatus.Rented, rooms = 4 },
            new House() { id = 3, buildingNumber = 371, address = "4142,Sector 23", state = "Gurgaon", fullName = "Vinay garg", status = ownedStatus.Owner, rooms = 5 },
            new House() { id = 4, buildingNumber = 371, address = "4143,Sector 23", state = "Gurgaon", fullName = "Naman Rawat", status = ownedStatus.Rented, rooms = 6 }
            };
            houses.ForEach(s => context.Houses.Add(s));
            context.SaveChanges();

            var population = new List<Population>
            {
       
            };
            population.ForEach(s => context.Population.Add(s));
            context.SaveChanges();
        }
    }
}
