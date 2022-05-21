using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleLab
{
    class Program
    {
        //Наследование классов - дочерний класс наследует все поля и методы родительского класса
        //Ассоциация классов - один класс содержится внутри другого в виде поля
            //Агрегация и композиция

        /*
    class Car
    {
        public Engine eng { get; set; }

        public Car()
        {
            eng = new Engine();
        }
    }
    
         */
        static void Main(string[] args)
        {
            Human human = new Human(new CellPhone());
            //human.age = -5;
            human.SetAge(-5);
        }
    }
}
