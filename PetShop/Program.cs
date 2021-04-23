using System;
using System.Collections.Generic;

namespace PetShop
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Quantos cachorros pequenos: ");
            int littleDogs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos cachorros grandes: ");
            int bigDogs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Para qual dia DD/MM/YYYY ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            //Criar metodo para instanciar
            CaninoFeliz caninoFeliz = new CaninoFeliz(date, littleDogs, bigDogs);
            VaiRex vaiRex = new VaiRex(date, littleDogs, bigDogs);
            ChowChawgas chowChawgas = new ChowChawgas(date, littleDogs, bigDogs);

            caninoFeliz.Calculate();
            vaiRex.Calculate();
            chowChawgas.Calculate();

            Calculator.CalculateLower(caninoFeliz.Total, vaiRex.Total, chowChawgas.Total);


        }
    }
}
