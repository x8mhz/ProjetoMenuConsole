using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetoMenu
{
    public class Program
    {
        private const string Title = "----------------\n  PROJETO MENU\n----------------\n";

        private static void Main(string[] args)
        {        
            while (true)
            {
                Console.Clear();
                Console.WriteLine(Title);
                try
                {
                    Console.WriteLine(" 1 - MOSTRAR");
                    Console.WriteLine(" 2 - ADICIONAR");
                    Console.WriteLine(" 3 - RELATÓRIO");
                    Console.Write(" >> ");
                    var opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(Title);
                            Console.Write(" ID DO CLIENTE\n >> ");
                            var id = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine(Title);
                            DisplayShow(id);
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine(Title);
                            DisplayAdd();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine(Title);
                            Console.WriteLine(" 3");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine(Title);
                            Console.WriteLine("\n\n Inválido");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.Clear();
                    Console.WriteLine(Title);
                    Console.WriteLine(" AVISO: Cliente não encontrado!");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine(Title);
                    Console.WriteLine(" AVISO: Atenção ao formato dos menus, entre sempre com os valosres informados.");
                    Console.ReadKey();
                }
            }
        }

        public static void DisplayShow(int id)
        {
            var addConfig = new Configurations();
            var fields = new List<string>
            {
                "         ID: ",
                "     CÓDIGO: ",
                "      MARCA: ",
                "     MODELO: ",
                "  DESCRIÇÃO: ",
                "       DATA: ",
                " QUANTIDADE: ",
                "      PREÇO: ",
                "      TOTAL: "
            };
      
            for (var i = 0; i < addConfig.Show(id).Count; i++)
            {
                Console.WriteLine(fields[i] + addConfig.Show(id)[i]);
            }                        
        }

        public static void DisplayAdd()
        {
            var config = new Configurations();

            Console.Write(" MARCA: ");
            var brand = Console.ReadLine();
            Console.Write(" MODELO: ");
            var model = Console.ReadLine();
            Console.Write(" DESCRIÇÃO: ");
            var description = Console.ReadLine();
            Console.Write(" QUANTIDADE: ");
            var amount = int.Parse(Console.ReadLine());
            Console.Write(" VALOR: ");
            var price = decimal.Parse(Console.ReadLine());

            var product = new Product(brand, model, description, amount, price);

            config.Add(product);
        }
    }
}
