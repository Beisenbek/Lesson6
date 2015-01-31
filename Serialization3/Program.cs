using Serialization1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer x = new XmlSerializer(typeof(Person));
            FileStream fs = new FileStream("t2.txt", FileMode.Open);

            Person p2 = x.Deserialize(fs) as Person;

            fs.Close();
        }
    }
}
