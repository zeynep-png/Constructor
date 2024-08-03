using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Baby
    {
        //Proporties for the Baby class
        public DateTime BirthTime {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        //Default constructor
        public Baby() {

            BirthTime = DateTime.Now; //Set the birth date current date and time
            Console.WriteLine("Ingaaaa...\n");
        }

        //Constructor with parameters for first name and last name
        public Baby(string _firstName, string _lastName)
        {
            BirthTime = DateTime.Now;
            FirstName = _firstName; //Assign the given values to the properties
            LastName = _lastName;
            Console.WriteLine("\n\nIngaaaaa...\n");
            
        }


    }
}
