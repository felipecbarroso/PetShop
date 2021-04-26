using System;
using System.Collections.Generic;
using System.Linq;


namespace PetShop
{
    public class InputData
    {
        public InputData(DateTime date, int littleDogs, int bigDogs)
        {
            Date = date;
            LittleDogs = littleDogs;
            BigDogs = bigDogs;
                        
        }

        public DateTime Date { get; set; }
        public int LittleDogs { get; set; }
        public int BigDogs { get; set; }



        public PetShopEscolhido Calculate(InputData data, List<PrecoPetShop> precos)
        {
            List<PetShopEscolhido> petShopEscolhido = new List<PetShopEscolhido>();
            foreach (var item in precos)
            {
                double precoLittleDogs = data.LittleDogs * (Validators.IsWeekend(data.Date.DayOfWeek) ? item.PriceLittleDogsWeekend : item.PriceLittleDogsWeek);
                double precoBigDogs = data.BigDogs * (Validators.IsWeekend(data.Date.DayOfWeek) ? item.PriceBigDogsWeekend : item.PriceBigDogsWeek);
                double precoFinal = precoBigDogs + precoLittleDogs;
                petShopEscolhido.Add(new PetShopEscolhido{Name = item.Name, Distance = item.Distance, PrecoFinal = precoFinal });
            }
            return petShopEscolhido.OrderBy(x => x.PrecoFinal).ThenBy(x => x.Distance).FirstOrDefault();
            

        }



    }
}
