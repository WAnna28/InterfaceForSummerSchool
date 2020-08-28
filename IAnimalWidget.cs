using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceForSummerSchool
{
    public interface IAnimalWidget
    {
        public static int AmountToFeed { get; set; }
        static void SetAmountToFeed(int amount)
        {
            AmountToFeed = amount;
        }

        string Name { get; }

        int Happiness { get; set; }

        void Feed()
        {
            Happiness += AmountToFeed;
        }
    }
}
