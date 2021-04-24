using System;
using System.Collections.Generic;
using System.IO;

namespace PetShop
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\Users\felip\Desktop\dti.txt";
            if (path != null)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {

                        string texto = sr.ReadLine();
                        string[] colunas = texto.Split(',');
                        InputData Data = new InputData(Convert.ToDateTime(colunas[0]),
                           Convert.ToInt32(colunas[1]),
                           Convert.ToInt32(colunas[2]));

                        Data.Calculate(Data);


                        foreach (var item in Data.Pets)
                        {
                            Console.WriteLine("{0} - {1}", item.Name, item.Total);
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Data DD/MM/YYYY, qtd pequeno, qtd grande");
                string texto = Console.ReadLine();
                string[] colunas = texto.Split(',');
                InputData Data = new InputData(Convert.ToDateTime(colunas[0]),
                   Convert.ToInt32(colunas[1]),
                   Convert.ToInt32(colunas[2]));

                Data.Calculate(Data);


                foreach (var item in Data.Pets)
                {
                    Console.WriteLine("{0} - {1}", item.Name, item.Total);
                }
            }
        }
    }
}




