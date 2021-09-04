using System;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, segundos, minutos, horas, sobra;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            sobra = N % 3600;

            minutos = sobra / 60;
            segundos = sobra % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos );
            
        }
    }
}
