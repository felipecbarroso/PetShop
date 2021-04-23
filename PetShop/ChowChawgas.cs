using System;


namespace PetShop
{
    public class ChowChawgas : PetShopBase
    {
        public ChowChawgas(DateTime date, int littleDogs, int bigDogs)
        {
            Date = date;
            LittleDogs = littleDogs;
            BigDogs = bigDogs;
            Distance = 0.8;
        }


        public double Distance { get; set; }

        public void Calculate()
        {
            Total = LittleDogs * 30 + BigDogs * 45;
        }
    }
}
