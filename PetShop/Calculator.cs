using System;


namespace PetShop
{
    static class Calculator
    {
        public static void CalculateLower(double totalCanino, double totalRex, double totalChow)
        {
            if (totalCanino <= totalRex && totalCanino <= totalChow)
            {//Nao queria que o writeline ficasse aqui
                if (totalCanino == totalRex)
                {
                    Console.WriteLine("PetShop: Vai Rex | Total: ", totalRex);
                }
                if( totalCanino == totalChow)
                {
                    Console.WriteLine("PetShop: ChowChawgas | Total: ", totalChow);
                }
                Console.WriteLine("PetShop: Canino Feliz | Total: ", totalCanino);
            }

            if (totalRex < totalCanino && totalRex <= totalChow)
            {
                if (totalRex == totalChow)
                {
                    Console.WriteLine("PetShop: ChowChawgas | Total: ", totalChow);
                }
                Console.WriteLine("PetShop: Vai Rex | Total: "+ totalRex);
            }

            if (totalChow <= totalCanino && totalChow <= totalRex)
            {
                Console.WriteLine("PetShop: ChowChawgas | Total: "+ totalChow);
            }

        }


    }
}
