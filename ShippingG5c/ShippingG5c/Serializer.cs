using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using statements for serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace ShippingG5c
{
    static class Serializer
    {
        public static void SerializeNow(Invoice myInvoice)
        {
            //setup a memory stream object that is needed
            //to hold the obj in memory during the
            //format and transformation process
            MemoryStream myStream = new MemoryStream();

            //setup the binary formatting obj that
            //performs the format process
            BinaryFormatter myFormat = new BinaryFormatter();

            //we call the serailize method, passing the
            //stream so we know where to save and obj it
            //will transform
            myFormat.Serialize(myStream, myInvoice);

            //now that the obj is serialized, covert to
            //Base64 for encoding and easy storage
            string serializedValue = Convert.ToBase64String(myStream.ToArray());

            //call the Insert method of the DA class
            DataAdapter.Insert(serializedValue);

            //close the stream
            myStream.Close();

        }
    }
}
