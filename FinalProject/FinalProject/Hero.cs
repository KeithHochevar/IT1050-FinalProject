using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Hero
    {
        private string Alterego;
        private string Weakness;
        private bool Antihero;
        private string Gender;
        private string Race;

        public string Power;
        public int PowerLevel;
        public double Health;
        public string Weapons;
        public int Age;
        public string Name;
        public string nemesis;

        public Hero()
        {
        }

        // TODO: Problem 1 - add a constructor method with a different number and/or types of parameters
        public Hero(string weapons, string weakness, int age)
        {
            this.Weapons = weapons;
            this.Weakness = weakness;
            this.Age = age;
        }

        public Hero(string name, string nemesis, string race, string power)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
        }

        public Hero(string name, string nemesis, string race, string power, bool antihero)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
            this.Antihero = antihero;
        }

        public void FightCrime(string address)
        {
            // TODO: Problem 2 - Output "Successfully fought crime at address" if PowerLevel > 49
            if (PowerLevel > 49)
            {
                Console.WriteLine("Successfully fought crime at " + address);
            }
            else
            {
                Console.WriteLine("Failed to fight crime at " + address);
            }
        }

        public bool Investigate()
        {
            // TODO: Problem 3 - output "Investigated Crime" and return true
            Console.WriteLine("Investigated Crime");
            return true;
            /*
            bool returnValue = true;
            if (true)
            {
                Console.WriteLine("Investigated Crime");
            }
            return returnValue;
            */
        }

        public void Fly()
        {
            // TODO: Problem 4 - if Power contains Fly, then output "Name is Flying!" else output "Name can't fly!"
            if (this.Power.Contains("Fly"))
            {
                Console.WriteLine(Name + " is Flying!");
            }
            else
            {
                Console.WriteLine(Name + " can't fly!");
            }
        }

        public void Craft(string material, int numMaterials)
        {
            Console.WriteLine("Crafting with " + material);
        }

        public void Climb(int height)
        {
            Console.WriteLine(this.Name + " is climbing");
        }

        public int ChargePower()
        {
            // TODO: Problem 5 - increase this.PowerLevel by 1
            // for (int i = 0; i < 2; i++)
            // {
            //      i++;
            // }
            // this.PowerLevel++;
            PowerLevel++;
            return PowerLevel;
        }

        // TODO: Problem 6 - Add an overloaded method ChargePower that has a parameter for increaseAmount.  Add increaseAmount to this.PowerLevel and return the new value for this.PowerLevel (try to use a loop calling the other ChargePower)
        public int ChargePower(int increaseAmount)
        {
            for (int i = 0; i < increaseAmount; i++)
            {
                this.ChargePower();
            }
            return this.PowerLevel;
        }
    }
}
