using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson12_Part2
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }

        public string saysHello()
        {
            return $"{FirstName} says Hello!";
        }
    }
}
