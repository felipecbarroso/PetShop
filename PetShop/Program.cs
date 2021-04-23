using System;
using System.Collections.Generic;

namespace PetShop
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Data DD/MM/YYYY, qtd pequeno, qtd grande");
            string texto = Console.ReadLine();
            string[] colunas = texto.Split(',');
            DateTime date = Convert.ToDateTime(colunas[0]);
            int littleDogs = Convert.ToInt32(colunas[1]);
            int bigDogs = Convert.ToInt32(colunas[2]);

            //Console.Write("Quantos cachorros pequenos: ");
            //int littleDogs = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Quantos cachorros grandes: ");
            //int bigDogs = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Para qual dia DD/MM/YYYY ");
            //DateTime date = Convert.ToDateTime(Console.ReadLine());

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
