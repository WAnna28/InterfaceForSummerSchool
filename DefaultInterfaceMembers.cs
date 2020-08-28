using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceForSummerSchool
{
    public class DogWidget : IAnimalWidget
    {
        public string Name => "Dog";
        public int Happiness { get; set; } = 250;
    }

    public class CatWidget : IAnimalWidget
    {
        public string Name => "Cat";
        public int Happiness { get; set; } = 40;
    }

    public class HamsterWidget : IAnimalWidget
    {
        public void Feed()
        {
            Console.WriteLine("Test");
        }
        public string Name => "Hamster";
        public int Happiness { get; set; } = 70;
    }

    public class DefaultInterfaceMembers
    {
        public static void Demo()
        {
            IAnimalWidget.SetAmountToFeed(45);

            var dog = new DogWidget();
            var cat = new CatWidget();
            var hamster = new HamsterWidget();

            var animals = new IAnimalWidget[] { dog, cat, hamster };

            //dog.Feed();
            hamster.Feed();

            foreach (var animal in animals)
            {
                animal.Feed();
                Console.WriteLine($"Happiness level for {animal.Name}: {animal.Happiness}");
            }
        }
    }
}
