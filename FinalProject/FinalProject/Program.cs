using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */

            Hero myHero = new Hero("Sword", "Darkness", 23);
            myHero.Name = "Superman";
            myHero.Power = "Strength, Speed, Fly";
            myHero.ChargePower(200);
            myHero.Investigate();
            myHero.FightCrime("1234 Earth");
            myHero.Fly();
            myHero.Climb(100);

            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            myOtherHero.ChargePower(30);
            myOtherHero.Investigate();
            myOtherHero.FightCrime("Sunny Street");
            myOtherHero.Fly();
            myOtherHero.Climb(8);

            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");
            thirdHero.ChargePower(400);
            thirdHero.Investigate();
            thirdHero.FightCrime("Baker Street");
            thirdHero.Fly();
            thirdHero.Climb(9);
        }
    }
}
