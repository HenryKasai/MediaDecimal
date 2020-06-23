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
            while (!terminar)
            {
                int número;
                Console.Write("Quantos números serão inseridos? ");
                bool númerobool = Int32.TryParse(Console.ReadLine(), out número);
                int i = 1;

                if (!númerobool)
                {
                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                    Console.ReadLine();
                }
                else
                {
                    while (i <= número)
                    {
                        double n;
                        Console.Write($"\nNúmero #{i}: ");
                        bool nbool = Double.TryParse(Console.ReadLine(), out n);
                        máximo = Math.Max(máximo, n);
                        resultado = resultado + n;
                        if (!nbool)
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                        }
                        i++;
                        double min = n;
                        mínimo = Math.Min(min, n);
                    }
                    Console.WriteLine($"\nSoma...: {resultado}");
                    Console.WriteLine($"Média...: {resultado / número}");
                    Console.WriteLine($"Máximo...: {máximo}");
                    Console.WriteLine($"Mínimo...: {mínimo}");
                    terminar = true;
                }
            }
        }
    }
}
