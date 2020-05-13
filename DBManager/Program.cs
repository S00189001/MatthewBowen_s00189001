using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatthewBowen_s00189001;

namespace DBManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneData PDdb = new PhoneData();

            using(PDdb)
            {
                // Create two Phone objects
                Phone p1 = new Phone() { PhoneID = 1, Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/s20.jpg" };
                Phone p2 = new Phone() { PhoneID = 2, Name = "iPhone 11", Price = 600, OperatingSystem = "IOS", OS_Image = "/images/apple.png", Phone_Image = "/images/iPhone11.jpg" };

                // Add Phone objects to database
                Console.WriteLine("Adding Phone Details to Database...");
                PDdb.PhoneDetails.Add(p1);
                PDdb.PhoneDetails.Add(p2);

                Console.WriteLine("Phone Details Added to Database.");

                Console.WriteLine("Saving Changes to Database...");
                PDdb.SaveChanges();
                Console.WriteLine("Saved Changes to Database.");


            }
        }
    }
}
