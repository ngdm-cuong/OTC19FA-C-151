using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        /// <summary>
        /// create a test person object. save to the database as a serialized element. Retrieve the serialized data and de-serialize for display.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Age = 43;
            myPerson.Name = "Mike Johnson";
            myPerson.Employer = "OTC";

            //call the serializeNow method
            //to package this Person obj up and
            //store it in the DB
            Serializer.SerializeNow(myPerson);

            //call the DB Get method to get all the records
            DataAdapter.Get();

            Console.ReadKey();
        }
    }
}
