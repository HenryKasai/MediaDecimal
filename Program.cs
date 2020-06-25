using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;
            double resultado = 0;
            double máximo = 0;
            double mínimo = 0;
            double min = 0;
            while (!terminar)
            {
                int número;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Quantos números serão inseridos? ");
                bool númerobool = Int32.TryParse(Console.ReadLine(), out número);
                int i = 1;

                if (!númerobool)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                    Console.ReadLine();
                }
                else
                {
                    while (i <= número)
                    {
                        double n;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"\nNúmero #{i}: ");
                        bool nbool = Double.TryParse(Console.ReadLine(), out n);
                        if (!nbool)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }   
                        else                    
                        { 
                            máximo = Math.Max(máximo, n);
                            min = Math.Min(mínimo, n);
                            mínimo = Math.Min(n, n);
                            resultado = resultado + n;
                            i++;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nSoma...: {resultado}");
                    Console.WriteLine($"Média...: {resultado / número}");
                    Console.WriteLine($"Máximo...: {máximo}");
                    if (número == 1)
                    {
                        Console.WriteLine($"Mínimo...: {número}");
                    }
                    else
                    {
                        Console.WriteLine($"Mínimo...: {min}");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    terminar = true;
                }
            }
        }
    }
}
