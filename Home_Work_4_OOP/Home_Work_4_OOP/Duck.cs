using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_OOP
{
    class Duck : Animals, IMove
    {
        public Duck(double _weight, int _age) : base(_weight, _age)
        {
        }
        public void Move()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
