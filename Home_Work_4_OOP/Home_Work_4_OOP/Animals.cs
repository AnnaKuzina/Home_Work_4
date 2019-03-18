using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_OOP
{
     class Animals
    {
        private double _weight;
        private int _age;

        public Animals(double _weight, int _age)
        {
            this._weight = _weight;
            this._age = _age;
        }
        public double Weight { get => _weight; set => _weight = value; }
        public int Age { get => _age; set => _age = value; }

        public virtual void Eat()
        {
            Console.WriteLine("I can eat!");
        }
    }
}
