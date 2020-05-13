using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewBowen_s00189001
{
    public class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public void IncreasePrice(decimal _percentage)
        {
            Price = 100m;

            decimal Percentage = Price / _percentage * 100;
            Price = Price + Percentage;
        }
    }
}
