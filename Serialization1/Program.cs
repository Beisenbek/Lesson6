using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization1
{
    [Serializable]
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;
        }
        public Person()
        {
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Person p = new Person(12);
            p.Name = "Bill";
            p.Surname = "John";

            FileStream fs = new FileStream("p.txt",FileMode.Create);
            bf.Serialize(fs,p);
            fs.Close();
        }
    }
}
