using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_LAB2
{
     class Person
    {
        //PRIVATE INSTANCE VARIABLE++++++++++++++++++++++++++++++
        private string _name;
        private int _age;

        //PUBLIC PROPERTY+++++++++++++++++++++++
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }


        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }


        }

        public  void SayHello()
        {
            Console.WriteLine("{0} says Hello",_name);
        }
        
        public void ShowAge()
        {
            Console.WriteLine("{0} is {1} years old",Name,Age);
        }
    }
}
