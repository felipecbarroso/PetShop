using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public IEnumerable<PetShopBase> Pets { get; set; }

        public void Calculate(InputData Data)
        {

            if (Data.Date.DayOfWeek == DayOfWeek.Saturday || Data.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                double caninoFeliz = (Data.LittleDogs * 20 + Data.BigDogs * 40) * 1.2;
                double vaiRex = (Data.LittleDogs * 20 + Data.BigDogs * 55);
                double chowChawgas = (Data.LittleDogs * 30 + Data.BigDogs * 45);
                PetShopBase[] pets = { new PetShopBase { Name = "Canino Feliz", Distance = 2, Total = caninoFeliz },
                                       new PetShopBase {Name = "Vai Rex", Distance = 1.7, Total = vaiRex},
                                       new PetShopBase { Name = "ChowChawgas", Distance = 0.8, Total = chowChawgas} };
                Pets = pets.OrderBy(x => x.Total).ThenBy(x=> x.Distance); 
            }
            else
            {

                double caninoFeliz = (Data.LittleDogs * 20 + Data.BigDogs * 40);
                double vaiRex = (Data.LittleDogs * 15 + Data.BigDogs * 50);
                double chowChawgas = (Data.LittleDogs * 30 + Data.BigDogs * 45);
                PetShopBase[] pets = { new PetShopBase { Name = "Canino Feliz", Distance = 2, Total = caninoFeliz },
                                       new PetShopBase {Name = "Vai Rex", Distance = 1.7, Total = vaiRex},
                                       new PetShopBase { Name = "ChowChawgas", Distance = 0.8, Total = chowChawgas} };
                Pets = pets.OrderBy(x => x.Total).ThenBy(x => x.Distance);
            }

        }

    }
}
