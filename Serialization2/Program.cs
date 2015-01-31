using Serialization1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization2
{

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(120);
            p.Name = "Bill";
            p.Surname = "John";

            XmlSerializer x = new XmlSerializer(typeof(Person));
            FileStream fs = new FileStream("t.txt",FileMode.OpenOrCreate);

           // x.Serialize(fs, p);

            fs.Close();


            fs = new FileStream("t.txt", FileMode.Open);

            Person p2 = x.Deserialize(fs) as Person;

            fs.Close();
        }
    }
}
