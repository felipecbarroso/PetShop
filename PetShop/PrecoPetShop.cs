

namespace PetShop
{
    public class PrecoPetShop : PetShop
    {
        public PrecoPetShop(string nome, double distancia, double priceLittleDogsWeek, double priceBigDogsWeek, double priceLittleDogsWeekend, double priceBigDogsWeekend)
        {
            Name = nome;
            Distance = distancia;
            PriceLittleDogsWeekend = priceLittleDogsWeekend;
            PriceLittleDogsWeek = priceLittleDogsWeek;
            PriceBigDogsWeekend = priceBigDogsWeekend;
            PriceBigDogsWeek = priceBigDogsWeek;
        }



        public double PriceLittleDogsWeekend { get; set; }
        public double PriceLittleDogsWeek { get; set; }
        public double PriceBigDogsWeekend { get; set; }
        public double PriceBigDogsWeek { get; set; }
    }
}
