using System;

namespace PetShop
{
    public class VaiRex : PetShopBase
    {
        public VaiRex(DateTime date, int littleDogs, int bigDogs)
        {
            Date = date;
            LittleDogs = littleDogs;
            BigDogs = bigDogs;
            Distance = 1.7;
        }


        public double Distance { get; set; }

        public void Calculate()
        {

            if (Date.DayOfWeek != DayOfWeek.Saturday && Date.DayOfWeek != DayOfWeek.Sunday)
            {
                Total = LittleDogs * 15 + BigDogs * 50;

            }
            else
            {

                Total = LittleDogs * 20 + BigDogs * 55;
            }
        }
    }
}
