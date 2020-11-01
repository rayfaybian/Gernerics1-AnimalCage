using System;

namespace Animal_Cage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cage<Monkey> monkeyCage = new Cage<Monkey>();
            Cage<Tiger> tigerCage = new Cage<Tiger>();

            Monkey daniel = new Monkey("Daniel");
            Monkey gabriel = new Monkey("Gabriel");
            Monkey michael = new Monkey("Michael");

            Tiger mizi = new Tiger("Mizi");
            Tiger herbert = new Tiger("Herbert");
            Tiger viktor = new Tiger("Viktor");

            monkeyCage.AddAnimal(daniel);
            monkeyCage.AddAnimal(gabriel);
            monkeyCage.AddAnimal(michael);

            tigerCage.AddAnimal(mizi);
            tigerCage.AddAnimal(herbert);
            tigerCage.AddAnimal(viktor);

            monkeyCage.ShowAnimals();
            Console.WriteLine();
            tigerCage.ShowAnimals();

        }
    }
}
