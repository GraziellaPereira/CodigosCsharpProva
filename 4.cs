// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace DiasentreDatas
{
    class Program
    {
        static void Main()
        {
            int idade, mes, anos, dias;

            Console.WriteLine("Digite a sua idade em dias: ");
           idade = int.Parse(Console.ReadLine());
        
            anos = (idade/365);
            mes = (anos/30);
            dias = (mes/dias);

            Console.WriteLine(anos "anos" + mes "meses" + dias "dias")
            Console.ReadLine();
        }
    }
}