using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_OOP
{
    class Cat : Animals, IVoice
    {
        public Cat(double _weight, int _age):base(_weight, _age)
        {
        }
        public void Voice()
        {
            Console.WriteLine("I say meow!");
        }
    }
}
