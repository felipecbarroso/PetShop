using System;
using System.Collections.Generic;
using System.IO;

namespace PetShop
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\dti.txt";
            List<PrecoPetShop> listaPrecoPetShop = new List<PrecoPetShop>();
            string texto = "Meu Canino Feliz;2;20;40;24;48-Vai Rex;1.7;15;50;20;55-ChowChawgas;0.8;30;45;30;45";
            string[] splitPets = texto.Split("-");
            foreach (var item in splitPets)
            {
                string[] inputPets = item.Split(";");
                listaPrecoPetShop.Add(new PrecoPetShop(inputPets[0],
                       Convert.ToDouble(inputPets[1]),
                       Convert.ToDouble(inputPets[2]),
                       Convert.ToDouble(inputPets[3]),
                       Convert.ToDouble(inputPets[4]),
                       Convert.ToDouble(inputPets[5])));
            }
                try
                {

                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (sr.Peek() >= 0)
                        {

                            string input = sr.ReadLine();
                            string[] colunas = input.Split(' ');
                            InputData Data = new InputData(Convert.ToDateTime(colunas[0]),
                              Convert.ToInt32(colunas[1]),
                              Convert.ToInt32(colunas[2]));


                            PetShopEscolhido petShopEscolhido = Data.Calculate(Data, listaPrecoPetShop);

                            Console.WriteLine("{0} - {1}", petShopEscolhido.Name, petShopEscolhido.PrecoFinal);

                        }
                        Console.ReadKey();

                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Informe a demanda para o pedido incluindo quantidade de cachorros pequenos e grandes," +
                    "e para qual dia: ");
                    Console.WriteLine("Exemplo: 26/04/2021 3 5");
                    string input = Console.ReadLine();
                    string[] colunas = input.Split(' ');
                    InputData Data = new InputData(Convert.ToDateTime(colunas[0]),
                       Convert.ToInt32(colunas[1]),
                       Convert.ToInt32(colunas[2]));

                    PetShopEscolhido petShopEscolhido = Data.Calculate(Data, listaPrecoPetShop);

                    Console.WriteLine("{0} - {1}", petShopEscolhido.Name, petShopEscolhido.PrecoFinal);


                }



            }
        }
    }





