using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Tom";
           person.SayHello();
            person.Age = 47;
            person.ShowAge();   

        }
    }
}
