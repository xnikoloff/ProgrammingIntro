using System;
using System.Collections.Generic;
using System.Text;

namespace TenCats.Chapter11
{
    public class Cat
    {
        //fileds
        private string name;
        private string colour;

        //property name
        public string Name
        {
            //getter name
            get
            {
                return this.name;
            }

            //setter name
            set
            {
                this.name = value;
            }
        }

        //proeperty colour
        public string Colour
        {
            //getter colour
            get
            {
                return this.colour;
            }

            //setter colour
            set
            {
                this.colour = value;
            }
        }

        //default constructor
        public Cat()
        {
            this.name = "unnamed";
            this.colour = "grey";
        }

        //constructor with parameters
        public Cat(string name, string colour)
        {
            this.name = name;
            this.colour = colour;
        }

        public void SayMeow()
        {
            Console.WriteLine($"{this.name} said meow");
        }
    }
}
