using System;


namespace PetShop
{

    public class CaninoFeliz : PetShopBase
    {
        public CaninoFeliz(DateTime date, int littleDogs, int bigDogs)
        {
            Date = date;
            LittleDogs = littleDogs;
            BigDogs = bigDogs;
            Distance = 2;
        }
        public double Distance { get; set; }

        public void Calculate()
        {
            Total = LittleDogs * 20 + BigDogs * 40;

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                Total *= 1.2;

            }

        }
    }


}
