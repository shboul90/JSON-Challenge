using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Mo";
            person.LastName = "Shboul";
            person.DOB = new DateTime(1990, 8, 5);
            person.MyProperty = new List<string>
            { "Cash", "Fans", "Brands"};

            string json = JsonConvert.SerializeObject(person);

            EventTicket genConEvent = new EventTicket();

            genConEvent.StartDate = new DateTime(2021, 7, 27);
            genConEvent.EndDate = new DateTime(2021, 7, 31);
            genConEvent.EventTitle = "Gen Con";
            genConEvent.EventCapacity = 10000;
            genConEvent.PriceOfAdmission = 325.50m;

            string jsonChallenge1 = JsonConvert.SerializeObject(genConEvent);

            Badge employeeBadge = new Badge();

            employeeBadge.BadgeId = 12345;
            employeeBadge.ListOfDoors = new List<string> { "A1", "B2", "B5", "G21" };
            employeeBadge.HasSecurityClearance = true;
            employeeBadge.EmployeeId = "F54G678HJ32321S";
            employeeBadge.CreatedOn = new DateTime(2021, 7, 27, 17, 35, 42, 345);

            string jsonChallenge2 = JsonConvert.SerializeObject(employeeBadge);

            Console.WriteLine(json);
            Console.WriteLine(jsonChallenge1);
            Console.WriteLine(jsonChallenge2);

            Console.ReadKey();
        }
    }
}
