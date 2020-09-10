using System.Diagnostics;
using System;

namespace contratos_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Debug.Print("Teste");
                Console.WriteLine(Soma(3,2));
                Console.WriteLine(Soma(null, 3));
            }
            catch(Exception e)
            {
                Console.WriteLine($"Morreu {e.Message}");
            }
        }

        static decimal Soma(decimal? a, decimal? b)
        {
            Debug.Assert(a.HasValue);
            Debug.Assert(b.HasValue);

            var v =  a.GetValueOrDefault(0) + b.GetValueOrDefault(0);

            Debug.Assert(v > 3, "Menor que 3");

            return v;
        }
    }
}
